using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Menora.Behavior;
using Menora.Properties;
using Menora.Temperature;

namespace Menora
{
    public partial class MainForm : Form
    {
        private readonly string configPath;
        private readonly bool minimize;
        private readonly SortedList<int, Point> points;
        private readonly Dictionary<string, Rule> rules;

        public MainForm(string configPath, bool minimize)
        {
            Config config;
            string message;

            this.InitializeComponent();

            this.toolStripMenuItemName.Text += Assembly.GetExecutingAssembly().GetName().Version.ToString(2);
            this.Icon = Resources.AppIcon;

            this.rules = new Dictionary<string, Rule>();
            this.configPath = configPath;
            this.minimize = minimize;
            this.points = new SortedList<int, Point>();

            if (!File.Exists(configPath))
                config = new Config();
            else if (!Config.TryParse(File.ReadAllText(configPath), out config, out message))
            {
                this.toolStripStatusLabel.Text = string.Format(CultureInfo.InvariantCulture, "Configuration error: {0}", message);

                config = new Config();
            }

            this.ConfigSet(config);
            this.ModeConfigRadioCheckedChanged(this, new EventArgs());
        }

        #region Event handling

        private void IntervalNumericUpDownValueChanged(object sender, EventArgs e)
        {
            this.ModeConfigRadioCheckedChanged(sender, e);
        }

        private void MainFormClosed(object sender, FormClosedEventArgs e)
        {
            // Restore default temperature on exit
            Gamma.ApplyGamma(Point.DefaultTemperature);
        }

        private void MainFormFormClosing(object sender, FormClosingEventArgs e)
        {
            Config config;
            string message;

            if (this.ConfigGet(out config, out message))
                File.WriteAllText(this.configPath, config.ToJSON());
            else if (MessageBox.Show(string.Format(CultureInfo.InvariantCulture, "Current configuration cannot be saved: {0}." + Environment.NewLine + Environment.NewLine + "Do you want to exit without saving?", message), "Exit without saving", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;                
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            if (this.minimize)
                this.WindowState = FormWindowState.Minimized;
        }

        private void MainFormResize(object sender, EventArgs e)
        {
            this.ShowSystrayIcon(this.WindowState == FormWindowState.Minimized && this.trayCheckBox.Checked);
        }

        private void ModeConfigRadioCheckedChanged(object sender, EventArgs e)
        {
            if (this.modeConfigRadio.Checked)
            {
                this.UpdateTimerTick(sender, e);

                this.updateTimer.Interval = Math.Max((int)this.intervalNumericUpDown.Value * 1000, 1000);
                this.updateTimer.Enabled = true;
            }
        }

        private void ModeDirectRadioCheckedChanged(object sender, EventArgs e)
        {
            if (this.modeDirectRadio.Checked)
                this.ModeDirectTrackBarValueChanged(sender, e);
        }

        private void ModeDirectTrackBarValueChanged(object sender, EventArgs e)
        {
            int temperature = this.modeDirectTrackBar.Value;

            Gamma.ApplyGamma(temperature);

            this.modeDirectRadio.Checked = true;
            this.modeDirectValue.Text = temperature.ToString(CultureInfo.InvariantCulture) + "K";
            this.updateTimer.Enabled = false;
        }

        private void ModeTimeRadioCheckedChanged(object sender, EventArgs e)
        {
            if (this.modeTimeRadio.Checked)
                this.ModeTimeTrackBarChanged(sender, e);
        }

        private void ModeTimeTrackBarChanged(object sender, EventArgs e)
        {
            int temperature = Point.TemperatureAt(this.points.Values, this.modeTimeTrackBar.Value);

            Gamma.ApplyGamma(temperature);

            this.modeTimeValue.Text = string.Format(CultureInfo.InvariantCulture, "{0:00}:{1:00}", this.modeTimeTrackBar.Value / 60, this.modeTimeTrackBar.Value % 60);
            this.modeTimeRadio.Checked = true;
            this.modeTimeTemperature.Text = temperature.ToString(CultureInfo.InvariantCulture) + "K";
            this.updateTimer.Enabled = false;
        }

        private void PointsTextBoxTextChanged(object sender, EventArgs e)
        {
            string message;

            if (!this.PointsGet(out message))
                this.toolStripStatusLabel.Text = string.Format(CultureInfo.InvariantCulture, "Invalid temperatures definition: {0}", message);
            else
                this.toolStripStatusLabel.Text = string.Empty;
        }

        private void RulesButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show
            (
                "Here is the list of currently running processes, you can change auto-update behavior when one of them is detected by adding a line \"<process_name> = <behavior>\" in the \"behaviors\" text box, where <process_name> is the name of the process and <behavior> is one of \"apply\", \"pause\" or \"reset\"." + Environment.NewLine +
                Environment.NewLine +
                string.Join(Environment.NewLine, Process.GetProcesses().OrderBy(n => n).Distinct()),
                "Processes",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void RulesTextBoxTextChanged(object sender, EventArgs e)
        {
            string message;

            if (!this.RulesGet(out message))
                this.toolStripStatusLabel.Text = string.Format(CultureInfo.InvariantCulture, "Invalid behaviors definition: {0}", message);
            else
                this.toolStripStatusLabel.Text = string.Empty;
        }

        private void ToolStripMenuItemConfigClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void ToolStripMenuItemExitClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TrayIconMouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void UpdateTimerTick(object sender, EventArgs e)
        {
            int temperature;

            switch (Process.GetRule(this.rules, Process.GetProcesses()))
            {
                case Rule.Apply:
                    temperature = Point.TemperatureAt(this.points.Values, (int)DateTime.Now.TimeOfDay.TotalMinutes);

                    Gamma.ApplyGamma(temperature);

                    this.modeConfigValue.Text = string.Format(CultureInfo.InvariantCulture, "{0}K (apply)", temperature);

                    break;

                case Rule.Reset:
                    Gamma.ApplyGamma(Point.DefaultTemperature);

                    this.modeConfigValue.Text = string.Format(CultureInfo.InvariantCulture, "{0}K (reset)", Point.DefaultTemperature);

                    break;

                default:
                    this.modeConfigValue.Text = "(pause)";

                    break;
            }
        }

        #endregion

        private bool ConfigGet(out Config config, out string message)
        {
            if (!this.PointsGet(out message) || !this.RulesGet(out message))
            {
                config = null;

                return false;
            }

            config = new Config();
            config.Interval = TimeSpan.FromSeconds((int)this.intervalNumericUpDown.Value);
            config.Points = this.points.Values.ToArray();
            config.Rules = this.rules;
            config.Tray = this.trayCheckBox.Checked;

            return true;
        }

        private void ConfigSet(Config config)
        {
            this.rulesTextBox.Text = string.Join(Environment.NewLine, config.Rules.Select(p => string.Format(CultureInfo.InvariantCulture, "{0} = {1}", p.Key, p.Value)));
            this.intervalNumericUpDown.Value = (int)config.Interval.TotalSeconds;
            this.pointsTextBox.Text = string.Join(Environment.NewLine, config.Points.Select(t => string.Format(CultureInfo.InvariantCulture, "{0:00}:{1:00} = {2}", t.MinutesFromDayStart / 60, t.MinutesFromDayStart % 60, t.TempKelvin)));
            this.trayCheckBox.Checked = config.Tray;
        }

        private bool PointsGet(out string message)
        {
            int hours;
            int kelvins;
            int minutes;
            Point temperature;

            this.points.Clear();

            var i = 0;

            foreach (string[] temperatureString in this.pointsTextBox.Text
                .Split(new [] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
                .Select(l => l.Split(new [] { ':', '=' }, 3).Select(s => s.Trim()).ToArray()))
            {
                ++i;

                if (temperatureString.Length != 3)
                {
                    message = string.Format(CultureInfo.InvariantCulture, "invalid syntax at line #{0}", i);

                    return false;
                }

                if (!int.TryParse(temperatureString[0], NumberStyles.Integer, CultureInfo.InvariantCulture, out hours))
                {
                    message = string.Format(CultureInfo.InvariantCulture, "invalid hours '{1}' at line #{0}", i, temperatureString[0]);

                    return false;
                }

                if (!int.TryParse(temperatureString[1], NumberStyles.Integer, CultureInfo.InvariantCulture, out minutes))
                {
                    message = string.Format(CultureInfo.InvariantCulture, "invalid minutes '{1}' at line #{0}", i, temperatureString[1]);

                    return false;
                }

                if (!int.TryParse(temperatureString[2], NumberStyles.Integer, CultureInfo.InvariantCulture, out kelvins))
                {
                    message = string.Format(CultureInfo.InvariantCulture, "invalid kelvins '{1}' at line #{0}", i, temperatureString[2]);

                    return false;
                }

                temperature = new Point(hours * 60 + minutes, kelvins);

                this.points[temperature.MinutesFromDayStart] = temperature;
            }

            message = null;

            return true;
        }

        private bool RulesGet(out string message)
        {
            Rule rule;

            this.rules.Clear();

            var i = 0;

            foreach (string[] behaviorString in this.rulesTextBox.Text
                .Split(new [] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
                .Select(l => l.Split(new [] { '=' }, 2).Select(s => s.Trim()).ToArray()))
            {
                ++i;

                if (behaviorString.Length != 2)
                {
                    message = string.Format(CultureInfo.InvariantCulture, "invalid syntax at line #{0}", i);

                    return false;
                }

                if (!Enum.TryParse(behaviorString[1], true, out rule))
                {
                    message = string.Format(CultureInfo.InvariantCulture, "unknown rule '{1}' at line #{0}", i, behaviorString[1]);

                    return false;
                }

                this.rules[behaviorString[0]] = rule;
            }

            message = null;

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
