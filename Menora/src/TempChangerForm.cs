﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Menora.Properties;

namespace Menora
{
    public partial class TempChangerForm : Form
    {
        private const string DefaultJSON =
            "{\n" +
            "    \"times\": {\n" +
            "        \"4:00\": 3500,\n" +
            "        \"8:00\": 6500,\n" +
            "        \"18:00\": 6500,\n" +
            "        \"22:00\": 3500\n" +
            "    }\n" +
            "}";

        private readonly string configPath;
        private TempConfig currentConfig;
        private readonly bool minimize;

        public TempChangerForm(string configPath, bool minimize)
        {
            this.InitializeComponent();

            this.Icon = Resources.AppIcon;

            this.currentConfig = null;
            this.configPath = configPath;
            this.minimize = minimize;

            if (this.LoadConfigFromFile(configPath) || this.LoadConfigFromJSON(TempChangerForm.DefaultJSON))
                this.radioModeConfig.Checked = true;
            else
                this.radioModeDirect.Checked = true;
        }

        #region Event handling

        private void ButtonLoadClick(object sender, EventArgs e)
        {
            if (this.LoadConfigFromFile(this.configPath))
                this.toolStripStatusLabel.Text = "Configuration loaded from file.";
            else
                this.toolStripStatusLabel.Text = "No configuration, please save one first.";
        }

        private void ButtonSaveClick(object sender, EventArgs e)
        {
            if (!File.Exists(this.configPath) || MessageBox.Show(string.Format("Overwrite current configuration file ({0})?", this.configPath), "Save configuration", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                File.WriteAllText(this.configPath, this.textBoxCode.Text);

                this.toolStripStatusLabel.Text = "Configuration saved to file.";
            }
        }

        private void ButtonSetupClick(object sender, EventArgs e)
        {
            this.contextMenuStripSetup.Show(this.buttonSetup, 0, 0);
        }        

        private void RadioModeConfigCheckedChanged(object sender, EventArgs e)
        {
            if (this.currentConfig != null && this.radioModeConfig.Checked)
            {
                this.TimerUpdateTick(sender, e);

                this.timerUpdate.Interval = Math.Max(this.currentConfig.Interval * 1000, 1000);
                this.timerUpdate.Enabled = true;
            }
        }

        private void RadioModeDirectCheckedChanged(object sender, EventArgs e)
        {
            if (this.radioModeDirect.Checked)
                this.TrackBarDirectValueChanged(sender, e);
        }

        private void RadioModeTimeCheckedChanged(object sender, EventArgs e)
        {
            if (this.radioModeTime.Checked)
                this.TrackBarTimeValueChanged(sender, e);
        }

        private void TempChangerFormClosed(object sender, FormClosedEventArgs e)
        {
            // Restore default temperature on exit
            TempUtils.ApplyGamma(TempConfig.DefaultTemperature);
        }

        private void TempChangerFormLoad(object sender, EventArgs e)
        {
            if (this.minimize && this.currentConfig != null)
                this.WindowState = FormWindowState.Minimized;
        }

        private void TempChangerFormResize(object sender, EventArgs e)
        {
            bool showInTray;

            showInTray = this.currentConfig == null || this.currentConfig.Tray;

            this.ShowSystrayIcon(this.WindowState == FormWindowState.Minimized && showInTray);
        }

        private void TextBoxCodeTextChanged(object sender, EventArgs e)
        {
            bool valid;

            valid = TempConfig.TryParse(this.textBoxCode.Text, out this.currentConfig);

            this.toolStripStatusLabel.Text = valid ? "Configuration updated." : "Configuration is not valid JSON.";

            this.buttonSave.Enabled = valid;
            this.radioModeConfig.Enabled = valid;
            this.radioModeTime.Enabled = valid;
            this.trackBarTime.Enabled = valid;
        }

        private void TimerUpdateTick(object sender, EventArgs e)
        {
            int temperature;
            string text;

            if (this.currentConfig == null)
                return;

            if (this.currentConfig.IsEnabled(TempChangerForm.GetProcesses()))
            {
                temperature = this.currentConfig.TemperatureAt((int)DateTime.Now.TimeOfDay.TotalMinutes);
                text = "Auto-update enabled, set temperature to " + temperature.ToString(CultureInfo.InvariantCulture) + "K.";
            }
            else
            {
                temperature = TempConfig.DefaultTemperature;
                text = "Auto-update disabled, set default temperature.";
            }

            TempUtils.ApplyGamma(temperature);

            this.toolStripStatusLabel.Text = text;
        }

        private void ToolStripMenuItemConfigClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void ToolStripMenuItemExitClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripMenuItemHelpClick(object sender, EventArgs e)
        {
            MessageBox.Show
            (
                "Configuration editor accepts a JSON object where following properties can be set:" + Environment.NewLine +
                Environment.NewLine +
                "- times: desired temperatures by time of the day (JSON object where keys are times in \"hour:minute\" format and values are target temperatures in Kelvin)." + Environment.NewLine +
                Environment.NewLine +
                "- excludes: names of excluded processes, temperature will stop being updated automatically when one of these is running (JSON array, default value is an empty array)." + Environment.NewLine +
                Environment.NewLine +
                "- tray: application will minimize to tray if true or to taskbar otherwise (boolean value, default value is true)." + Environment.NewLine +
                Environment.NewLine +
                "- interval: temperature will be updated every N second where N is value of this option (integer value, default value is 60).",   
                "Help",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void ToolStripMenuItemProcessClick(object sender, EventArgs e)
        {
            MessageBox.Show
            (
                "Here is the list of currently running processes, you can automatically stop updating temperature when one of them is detected by adding their name in an \"excludes\" section in your configuration (see help for details):" + Environment.NewLine +
                Environment.NewLine +
                string.Join(Environment.NewLine, TempChangerForm.GetProcesses().OrderBy((n) => n)),
                "Processes",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void TrackBarDirectValueChanged(object sender, EventArgs e)
        {
            TempUtils.ApplyGamma(this.trackBarDirect.Value);

            this.labelDirectTemperature.Text = this.trackBarDirect.Value.ToString(CultureInfo.InvariantCulture) + "K";
            this.radioModeDirect.Checked = true;
            this.timerUpdate.Enabled = false;
        }

        private void TrackBarTimeValueChanged(object sender, EventArgs e)
        {
            int temperature;

            if (this.currentConfig == null)
                return;

            temperature = this.currentConfig.TemperatureAt(this.trackBarTime.Value);

            TempUtils.ApplyGamma(temperature);

            this.labelTime.Text = string.Format(CultureInfo.InvariantCulture, "{0:00}:{1:00}", this.trackBarTime.Value / 60, this.trackBarTime.Value % 60);
            this.labelTimeTemperature.Text = temperature.ToString(CultureInfo.InvariantCulture) + "K";
            this.radioModeTime.Checked = true;
            this.timerUpdate.Enabled = false;
        }

        private void TrayIconMouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        #endregion

        private static IEnumerable<string> GetProcesses()
        {
            return Process.GetProcesses().Select((p) => p.ProcessName);
        }

        private bool LoadConfigFromFile(string path)
        {
            string json;

            try
            {
                json = File.ReadAllText(path);
            }
            catch (IOException)
            {
                return false;
            }

            return this.LoadConfigFromJSON(json);
        }

        private bool LoadConfigFromJSON(string json)
        {
            this.textBoxCode.Text = json.Replace("\r", string.Empty).Replace("\n", Environment.NewLine);

            return true;
        }

        private void ShowSystrayIcon(bool showOnSysTray)
        {
            if (showOnSysTray)
            {
                this.ShowInTaskbar = false;
                this.trayIcon.Visible = true;
            }
            else
            {
                this.ShowInTaskbar = true;
                this.trayIcon.Visible = false;
            }
        }
    }
}
