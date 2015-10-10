namespace Menora
{
    partial class TempChangerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxMode = new System.Windows.Forms.GroupBox();
            this.labelTimeTemperature = new System.Windows.Forms.Label();
            this.labelDirectTemperature = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.radioModeConfig = new System.Windows.Forms.RadioButton();
            this.labelHelp = new System.Windows.Forms.Label();
            this.labelTimeDefault = new System.Windows.Forms.Label();
            this.labelTimeMax = new System.Windows.Forms.Label();
            this.labelTimeMin = new System.Windows.Forms.Label();
            this.trackBarTime = new System.Windows.Forms.TrackBar();
            this.radioModeTime = new System.Windows.Forms.RadioButton();
            this.labelDirectDefault = new System.Windows.Forms.Label();
            this.labelDirectMax = new System.Windows.Forms.Label();
            this.labelDirectMin = new System.Windows.Forms.Label();
            this.trackBarDirect = new System.Windows.Forms.TrackBar();
            this.radioModeDirect = new System.Windows.Forms.RadioButton();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStripTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemName = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBoxCode = new System.Windows.Forms.GroupBox();
            this.buttonSetup = new System.Windows.Forms.Button();
            this.contextMenuStripSetup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemProcess = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.groupBoxMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDirect)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.contextMenuStripTray.SuspendLayout();
            this.groupBoxCode.SuspendLayout();
            this.contextMenuStripSetup.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMode
            // 
            this.groupBoxMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxMode.Controls.Add(this.labelTimeTemperature);
            this.groupBoxMode.Controls.Add(this.labelDirectTemperature);
            this.groupBoxMode.Controls.Add(this.labelTime);
            this.groupBoxMode.Controls.Add(this.radioModeConfig);
            this.groupBoxMode.Controls.Add(this.labelHelp);
            this.groupBoxMode.Controls.Add(this.labelTimeDefault);
            this.groupBoxMode.Controls.Add(this.labelTimeMax);
            this.groupBoxMode.Controls.Add(this.labelTimeMin);
            this.groupBoxMode.Controls.Add(this.trackBarTime);
            this.groupBoxMode.Controls.Add(this.radioModeTime);
            this.groupBoxMode.Controls.Add(this.labelDirectDefault);
            this.groupBoxMode.Controls.Add(this.labelDirectMax);
            this.groupBoxMode.Controls.Add(this.labelDirectMin);
            this.groupBoxMode.Controls.Add(this.trackBarDirect);
            this.groupBoxMode.Controls.Add(this.radioModeDirect);
            this.groupBoxMode.Location = new System.Drawing.Point(11, 11);
            this.groupBoxMode.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxMode.Name = "groupBoxMode";
            this.groupBoxMode.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxMode.Size = new System.Drawing.Size(316, 216);
            this.groupBoxMode.TabIndex = 0;
            this.groupBoxMode.TabStop = false;
            this.groupBoxMode.Text = "Test && use";
            // 
            // labelTimeTemperature
            // 
            this.labelTimeTemperature.AutoSize = true;
            this.labelTimeTemperature.Location = new System.Drawing.Point(212, 91);
            this.labelTimeTemperature.Name = "labelTimeTemperature";
            this.labelTimeTemperature.Size = new System.Drawing.Size(38, 13);
            this.labelTimeTemperature.TabIndex = 13;
            this.labelTimeTemperature.Text = "6500K";
            // 
            // labelDirectTemperature
            // 
            this.labelDirectTemperature.AutoSize = true;
            this.labelDirectTemperature.Location = new System.Drawing.Point(129, 25);
            this.labelDirectTemperature.Name = "labelDirectTemperature";
            this.labelDirectTemperature.Size = new System.Drawing.Size(38, 13);
            this.labelDirectTemperature.TabIndex = 1;
            this.labelDirectTemperature.Text = "6500K";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(172, 91);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(34, 13);
            this.labelTime.TabIndex = 7;
            this.labelTime.Text = "12:00";
            // 
            // radioModeConfig
            // 
            this.radioModeConfig.AutoSize = true;
            this.radioModeConfig.Location = new System.Drawing.Point(7, 159);
            this.radioModeConfig.Margin = new System.Windows.Forms.Padding(2);
            this.radioModeConfig.Name = "radioModeConfig";
            this.radioModeConfig.Size = new System.Drawing.Size(288, 17);
            this.radioModeConfig.TabIndex = 12;
            this.radioModeConfig.TabStop = true;
            this.radioModeConfig.Text = "Auto-update according to current time and configuration";
            this.radioModeConfig.UseVisualStyleBackColor = true;
            this.radioModeConfig.CheckedChanged += new System.EventHandler(this.RadioModeConfigCheckedChanged);
            // 
            // labelHelp
            // 
            this.labelHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHelp.Location = new System.Drawing.Point(7, 188);
            this.labelHelp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHelp.Name = "labelHelp";
            this.labelHelp.Size = new System.Drawing.Size(305, 19);
            this.labelHelp.TabIndex = 5;
            this.labelHelp.Text = "Start with option -m to minimize on start, -h for help.";
            // 
            // labelTimeDefault
            // 
            this.labelTimeDefault.AutoSize = true;
            this.labelTimeDefault.Location = new System.Drawing.Point(137, 136);
            this.labelTimeDefault.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTimeDefault.Name = "labelTimeDefault";
            this.labelTimeDefault.Size = new System.Drawing.Size(34, 13);
            this.labelTimeDefault.TabIndex = 10;
            this.labelTimeDefault.Text = "12:00";
            // 
            // labelTimeMax
            // 
            this.labelTimeMax.AutoSize = true;
            this.labelTimeMax.Location = new System.Drawing.Point(278, 136);
            this.labelTimeMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTimeMax.Name = "labelTimeMax";
            this.labelTimeMax.Size = new System.Drawing.Size(34, 13);
            this.labelTimeMax.TabIndex = 11;
            this.labelTimeMax.Text = "23:59";
            // 
            // labelTimeMin
            // 
            this.labelTimeMin.AutoSize = true;
            this.labelTimeMin.Location = new System.Drawing.Point(7, 136);
            this.labelTimeMin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTimeMin.Name = "labelTimeMin";
            this.labelTimeMin.Size = new System.Drawing.Size(28, 13);
            this.labelTimeMin.TabIndex = 9;
            this.labelTimeMin.Text = "0:00";
            // 
            // trackBarTime
            // 
            this.trackBarTime.LargeChange = 60;
            this.trackBarTime.Location = new System.Drawing.Point(7, 110);
            this.trackBarTime.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarTime.Maximum = 1439;
            this.trackBarTime.Name = "trackBarTime";
            this.trackBarTime.Size = new System.Drawing.Size(305, 45);
            this.trackBarTime.SmallChange = 5;
            this.trackBarTime.TabIndex = 8;
            this.trackBarTime.TickFrequency = 60;
            this.trackBarTime.Value = 720;
            this.trackBarTime.ValueChanged += new System.EventHandler(this.TrackBarTimeValueChanged);
            // 
            // radioModeTime
            // 
            this.radioModeTime.AutoSize = true;
            this.radioModeTime.Location = new System.Drawing.Point(7, 89);
            this.radioModeTime.Margin = new System.Windows.Forms.Padding(2);
            this.radioModeTime.Name = "radioModeTime";
            this.radioModeTime.Size = new System.Drawing.Size(160, 17);
            this.radioModeTime.TabIndex = 6;
            this.radioModeTime.TabStop = true;
            this.radioModeTime.Text = "Test your daily configuration:";
            this.radioModeTime.UseVisualStyleBackColor = true;
            this.radioModeTime.CheckedChanged += new System.EventHandler(this.RadioModeTimeCheckedChanged);
            // 
            // labelDirectDefault
            // 
            this.labelDirectDefault.AutoSize = true;
            this.labelDirectDefault.Location = new System.Drawing.Point(137, 70);
            this.labelDirectDefault.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDirectDefault.Name = "labelDirectDefault";
            this.labelDirectDefault.Size = new System.Drawing.Size(38, 13);
            this.labelDirectDefault.TabIndex = 4;
            this.labelDirectDefault.Text = "6500K";
            // 
            // labelDirectMax
            // 
            this.labelDirectMax.AutoSize = true;
            this.labelDirectMax.Location = new System.Drawing.Point(268, 70);
            this.labelDirectMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDirectMax.Name = "labelDirectMax";
            this.labelDirectMax.Size = new System.Drawing.Size(44, 13);
            this.labelDirectMax.TabIndex = 5;
            this.labelDirectMax.Text = "10000K";
            // 
            // labelDirectMin
            // 
            this.labelDirectMin.AutoSize = true;
            this.labelDirectMin.Location = new System.Drawing.Point(7, 70);
            this.labelDirectMin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDirectMin.Name = "labelDirectMin";
            this.labelDirectMin.Size = new System.Drawing.Size(38, 13);
            this.labelDirectMin.TabIndex = 3;
            this.labelDirectMin.Text = "3000K";
            // 
            // trackBarDirect
            // 
            this.trackBarDirect.LargeChange = 500;
            this.trackBarDirect.Location = new System.Drawing.Point(3, 40);
            this.trackBarDirect.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarDirect.Maximum = 10000;
            this.trackBarDirect.Minimum = 3000;
            this.trackBarDirect.Name = "trackBarDirect";
            this.trackBarDirect.Size = new System.Drawing.Size(309, 45);
            this.trackBarDirect.SmallChange = 10;
            this.trackBarDirect.TabIndex = 2;
            this.trackBarDirect.TickFrequency = 500;
            this.trackBarDirect.Value = 6500;
            this.trackBarDirect.ValueChanged += new System.EventHandler(this.TrackBarDirectValueChanged);
            // 
            // radioModeDirect
            // 
            this.radioModeDirect.AutoSize = true;
            this.radioModeDirect.Location = new System.Drawing.Point(7, 23);
            this.radioModeDirect.Margin = new System.Windows.Forms.Padding(2);
            this.radioModeDirect.Name = "radioModeDirect";
            this.radioModeDirect.Size = new System.Drawing.Size(117, 17);
            this.radioModeDirect.TabIndex = 0;
            this.radioModeDirect.Text = "Test a temperature:";
            this.radioModeDirect.UseVisualStyleBackColor = true;
            this.radioModeDirect.CheckedChanged += new System.EventHandler(this.RadioModeDirectCheckedChanged);
            // 
            // textBoxCode
            // 
            this.textBoxCode.AcceptsReturn = true;
            this.textBoxCode.AcceptsTab = true;
            this.textBoxCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCode.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCode.Location = new System.Drawing.Point(6, 18);
            this.textBoxCode.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCode.Multiline = true;
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(293, 163);
            this.textBoxCode.TabIndex = 4;
            this.textBoxCode.TextChanged += new System.EventHandler(this.TextBoxCodeTextChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSave.Location = new System.Drawing.Point(6, 186);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(120, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save configuration";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSaveClick);
            // 
            // timerUpdate
            // 
            this.timerUpdate.Interval = 60000;
            this.timerUpdate.Tick += new System.EventHandler(this.TimerUpdateTick);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 230);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 8, 0);
            this.statusStrip.Size = new System.Drawing.Size(650, 22);
            this.statusStrip.TabIndex = 6;
            this.statusStrip.Text = "Ready";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // contextMenuStripTray
            // 
            this.contextMenuStripTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemName,
            this.toolStripSeparator,
            this.toolStripMenuItemConfig,
            this.toolStripMenuItemExit});
            this.contextMenuStripTray.Name = "ctxTrayIcon";
            this.contextMenuStripTray.Size = new System.Drawing.Size(212, 98);
            // 
            // toolStripMenuItemName
            // 
            this.toolStripMenuItemName.Enabled = false;
            this.toolStripMenuItemName.Name = "toolStripMenuItemName";
            this.toolStripMenuItemName.Size = new System.Drawing.Size(211, 22);
            this.toolStripMenuItemName.Text = "Menora v0.2";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(208, 6);
            // 
            // toolStripMenuItemConfig
            // 
            this.toolStripMenuItemConfig.Name = "toolStripMenuItemConfig";
            this.toolStripMenuItemConfig.Size = new System.Drawing.Size(211, 22);
            this.toolStripMenuItemConfig.Text = "Settings...";
            this.toolStripMenuItemConfig.Click += new System.EventHandler(this.ToolStripMenuItemConfigClick);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(211, 22);
            this.toolStripMenuItemExit.Text = "Exit";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.ToolStripMenuItemExitClick);
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.contextMenuStripTray;
            this.trayIcon.Icon = global::Menora.Properties.Resources.AppIcon;
            this.trayIcon.Text = "Menora";
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayIconMouseDoubleClick);
            // 
            // groupBoxCode
            // 
            this.groupBoxCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCode.Controls.Add(this.buttonSetup);
            this.groupBoxCode.Controls.Add(this.buttonLoad);
            this.groupBoxCode.Controls.Add(this.textBoxCode);
            this.groupBoxCode.Controls.Add(this.buttonSave);
            this.groupBoxCode.Location = new System.Drawing.Point(332, 12);
            this.groupBoxCode.Name = "groupBoxCode";
            this.groupBoxCode.Size = new System.Drawing.Size(306, 215);
            this.groupBoxCode.TabIndex = 7;
            this.groupBoxCode.TabStop = false;
            this.groupBoxCode.Text = "Configuration editor";
            // 
            // buttonSetup
            // 
            this.buttonSetup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSetup.ContextMenuStrip = this.contextMenuStripSetup;
            this.buttonSetup.Location = new System.Drawing.Point(258, 186);
            this.buttonSetup.Name = "buttonSetup";
            this.buttonSetup.Size = new System.Drawing.Size(32, 23);
            this.buttonSetup.TabIndex = 6;
            this.buttonSetup.Text = "...";
            this.buttonSetup.UseVisualStyleBackColor = true;
            this.buttonSetup.Click += new System.EventHandler(this.ButtonSetupClick);
            // 
            // contextMenuStripSetup
            // 
            this.contextMenuStripSetup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemProcess,
            this.toolStripMenuItemHelp});
            this.contextMenuStripSetup.Name = "contextMenuStripSetup";
            this.contextMenuStripSetup.Size = new System.Drawing.Size(158, 48);
            // 
            // toolStripMenuItemProcess
            // 
            this.toolStripMenuItemProcess.Name = "toolStripMenuItemProcess";
            this.toolStripMenuItemProcess.Size = new System.Drawing.Size(157, 22);
            this.toolStripMenuItemProcess.Text = "Show processes";
            this.toolStripMenuItemProcess.Click += new System.EventHandler(this.ToolStripMenuItemProcessClick);
            // 
            // toolStripMenuItemHelp
            // 
            this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            this.toolStripMenuItemHelp.Size = new System.Drawing.Size(157, 22);
            this.toolStripMenuItemHelp.Text = "Display help";
            this.toolStripMenuItemHelp.Click += new System.EventHandler(this.ToolStripMenuItemHelpClick);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLoad.Location = new System.Drawing.Point(132, 186);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(120, 23);
            this.buttonLoad.TabIndex = 5;
            this.buttonLoad.Text = "Load configuration";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.ButtonLoadClick);
            // 
            // TempChangerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 252);
            this.Controls.Add(this.groupBoxCode);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBoxMode);
            this.MaximizeBox = false;
            this.Name = "TempChangerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menora";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TempChangerFormClosed);
            this.Load += new System.EventHandler(this.TempChangerFormLoad);
            this.Resize += new System.EventHandler(this.TempChangerFormResize);
            this.groupBoxMode.ResumeLayout(false);
            this.groupBoxMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDirect)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.contextMenuStripTray.ResumeLayout(false);
            this.groupBoxCode.ResumeLayout(false);
            this.groupBoxCode.PerformLayout();
            this.contextMenuStripSetup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarDirect;
        private System.Windows.Forms.RadioButton radioModeDirect;
        private System.Windows.Forms.RadioButton radioModeConfig;
        private System.Windows.Forms.TrackBar trackBarTime;
        private System.Windows.Forms.RadioButton radioModeTime;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTray;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemConfig;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.GroupBox groupBoxMode;
        private System.Windows.Forms.Label labelHelp;
        private System.Windows.Forms.Label labelTimeDefault;
        private System.Windows.Forms.Label labelTimeMax;
        private System.Windows.Forms.Label labelTimeMin;
        private System.Windows.Forms.Label labelDirectDefault;
        private System.Windows.Forms.Label labelDirectMax;
        private System.Windows.Forms.Label labelDirectMin;
        private System.Windows.Forms.GroupBox groupBoxCode;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label labelDirectTemperature;
        private System.Windows.Forms.Label labelTimeTemperature;
        private System.Windows.Forms.Button buttonSetup;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSetup;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemProcess;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp;


    }
}

