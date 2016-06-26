namespace Menora
{
    partial class MainForm
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
            this.modeGroupBox = new System.Windows.Forms.GroupBox();
            this.modeConfigValue = new System.Windows.Forms.Label();
            this.modeTimeTemperature = new System.Windows.Forms.Label();
            this.modeDirectValue = new System.Windows.Forms.Label();
            this.modeTimeValue = new System.Windows.Forms.Label();
            this.modeConfigRadio = new System.Windows.Forms.RadioButton();
            this.modeTimeDefaultLabel = new System.Windows.Forms.Label();
            this.modeTimeMaxLabel = new System.Windows.Forms.Label();
            this.modeTimeMinLabel = new System.Windows.Forms.Label();
            this.modeTimeTrackBar = new System.Windows.Forms.TrackBar();
            this.modeTimeRadio = new System.Windows.Forms.RadioButton();
            this.modeDirectMinLabel = new System.Windows.Forms.Label();
            this.modeDirectMaxLabel = new System.Windows.Forms.Label();
            this.modeDirectDefaultLabel = new System.Windows.Forms.Label();
            this.modeDirectTrackBar = new System.Windows.Forms.TrackBar();
            this.modeDirectRadio = new System.Windows.Forms.RadioButton();
            this.trayHelpLabel = new System.Windows.Forms.Label();
            this.pointsTextBox = new System.Windows.Forms.TextBox();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStripTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemName = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.configGroupBox = new System.Windows.Forms.GroupBox();
            this.trayCheckBox = new System.Windows.Forms.CheckBox();
            this.trayLabel = new System.Windows.Forms.Label();
            this.intervalUnitLabel = new System.Windows.Forms.Label();
            this.intervalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.rulesTextBox = new System.Windows.Forms.TextBox();
            this.rulesLabel = new System.Windows.Forms.Label();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.rulesButton = new System.Windows.Forms.Button();
            this.modeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modeTimeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeDirectTrackBar)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.contextMenuStripTray.SuspendLayout();
            this.configGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // modeGroupBox
            // 
            this.modeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modeGroupBox.Controls.Add(this.modeConfigValue);
            this.modeGroupBox.Controls.Add(this.modeTimeTemperature);
            this.modeGroupBox.Controls.Add(this.modeDirectValue);
            this.modeGroupBox.Controls.Add(this.modeTimeValue);
            this.modeGroupBox.Controls.Add(this.modeConfigRadio);
            this.modeGroupBox.Controls.Add(this.modeTimeDefaultLabel);
            this.modeGroupBox.Controls.Add(this.modeTimeMaxLabel);
            this.modeGroupBox.Controls.Add(this.modeTimeMinLabel);
            this.modeGroupBox.Controls.Add(this.modeTimeTrackBar);
            this.modeGroupBox.Controls.Add(this.modeTimeRadio);
            this.modeGroupBox.Controls.Add(this.modeDirectMinLabel);
            this.modeGroupBox.Controls.Add(this.modeDirectMaxLabel);
            this.modeGroupBox.Controls.Add(this.modeDirectDefaultLabel);
            this.modeGroupBox.Controls.Add(this.modeDirectTrackBar);
            this.modeGroupBox.Controls.Add(this.modeDirectRadio);
            this.modeGroupBox.Location = new System.Drawing.Point(11, 11);
            this.modeGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.modeGroupBox.Name = "modeGroupBox";
            this.modeGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.modeGroupBox.Size = new System.Drawing.Size(420, 186);
            this.modeGroupBox.TabIndex = 0;
            this.modeGroupBox.TabStop = false;
            this.modeGroupBox.Text = "Test && use";
            // 
            // modeConfigValue
            // 
            this.modeConfigValue.AutoSize = true;
            this.modeConfigValue.Location = new System.Drawing.Point(267, 162);
            this.modeConfigValue.Name = "modeConfigValue";
            this.modeConfigValue.Size = new System.Drawing.Size(38, 13);
            this.modeConfigValue.TabIndex = 14;
            this.modeConfigValue.Text = "6500K";
            // 
            // modeTimeTemperature
            // 
            this.modeTimeTemperature.AutoSize = true;
            this.modeTimeTemperature.Location = new System.Drawing.Point(209, 92);
            this.modeTimeTemperature.Name = "modeTimeTemperature";
            this.modeTimeTemperature.Size = new System.Drawing.Size(38, 13);
            this.modeTimeTemperature.TabIndex = 13;
            this.modeTimeTemperature.Text = "6500K";
            // 
            // modeDirectValue
            // 
            this.modeDirectValue.AutoSize = true;
            this.modeDirectValue.Location = new System.Drawing.Point(130, 26);
            this.modeDirectValue.Name = "modeDirectValue";
            this.modeDirectValue.Size = new System.Drawing.Size(38, 13);
            this.modeDirectValue.TabIndex = 1;
            this.modeDirectValue.Text = "6500K";
            // 
            // modeTimeValue
            // 
            this.modeTimeValue.AutoSize = true;
            this.modeTimeValue.Location = new System.Drawing.Point(169, 92);
            this.modeTimeValue.Name = "modeTimeValue";
            this.modeTimeValue.Size = new System.Drawing.Size(34, 13);
            this.modeTimeValue.TabIndex = 7;
            this.modeTimeValue.Text = "12:00";
            // 
            // modeConfigRadio
            // 
            this.modeConfigRadio.AutoSize = true;
            this.modeConfigRadio.Checked = true;
            this.modeConfigRadio.Location = new System.Drawing.Point(8, 160);
            this.modeConfigRadio.Margin = new System.Windows.Forms.Padding(2);
            this.modeConfigRadio.Name = "modeConfigRadio";
            this.modeConfigRadio.Size = new System.Drawing.Size(254, 17);
            this.modeConfigRadio.TabIndex = 4;
            this.modeConfigRadio.TabStop = true;
            this.modeConfigRadio.Text = "Auto-update using current time and configuration";
            this.modeConfigRadio.UseVisualStyleBackColor = true;
            this.modeConfigRadio.CheckedChanged += new System.EventHandler(this.ModeConfigRadioCheckedChanged);
            // 
            // modeTimeDefaultLabel
            // 
            this.modeTimeDefaultLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.modeTimeDefaultLabel.AutoSize = true;
            this.modeTimeDefaultLabel.Location = new System.Drawing.Point(190, 138);
            this.modeTimeDefaultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.modeTimeDefaultLabel.Name = "modeTimeDefaultLabel";
            this.modeTimeDefaultLabel.Size = new System.Drawing.Size(34, 13);
            this.modeTimeDefaultLabel.TabIndex = 10;
            this.modeTimeDefaultLabel.Text = "12:00";
            // 
            // modeTimeMaxLabel
            // 
            this.modeTimeMaxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modeTimeMaxLabel.AutoSize = true;
            this.modeTimeMaxLabel.Location = new System.Drawing.Point(378, 138);
            this.modeTimeMaxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.modeTimeMaxLabel.Name = "modeTimeMaxLabel";
            this.modeTimeMaxLabel.Size = new System.Drawing.Size(34, 13);
            this.modeTimeMaxLabel.TabIndex = 11;
            this.modeTimeMaxLabel.Text = "23:59";
            // 
            // modeTimeMinLabel
            // 
            this.modeTimeMinLabel.AutoSize = true;
            this.modeTimeMinLabel.Location = new System.Drawing.Point(8, 138);
            this.modeTimeMinLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.modeTimeMinLabel.Name = "modeTimeMinLabel";
            this.modeTimeMinLabel.Size = new System.Drawing.Size(28, 13);
            this.modeTimeMinLabel.TabIndex = 9;
            this.modeTimeMinLabel.Text = "0:00";
            // 
            // modeTimeTrackBar
            // 
            this.modeTimeTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modeTimeTrackBar.LargeChange = 60;
            this.modeTimeTrackBar.Location = new System.Drawing.Point(8, 110);
            this.modeTimeTrackBar.Margin = new System.Windows.Forms.Padding(2);
            this.modeTimeTrackBar.Maximum = 1439;
            this.modeTimeTrackBar.Name = "modeTimeTrackBar";
            this.modeTimeTrackBar.Size = new System.Drawing.Size(404, 45);
            this.modeTimeTrackBar.SmallChange = 5;
            this.modeTimeTrackBar.TabIndex = 3;
            this.modeTimeTrackBar.TickFrequency = 60;
            this.modeTimeTrackBar.Value = 720;
            this.modeTimeTrackBar.ValueChanged += new System.EventHandler(this.ModeTimeTrackBarChanged);
            // 
            // modeTimeRadio
            // 
            this.modeTimeRadio.AutoSize = true;
            this.modeTimeRadio.Location = new System.Drawing.Point(8, 90);
            this.modeTimeRadio.Margin = new System.Windows.Forms.Padding(2);
            this.modeTimeRadio.Name = "modeTimeRadio";
            this.modeTimeRadio.Size = new System.Drawing.Size(160, 17);
            this.modeTimeRadio.TabIndex = 2;
            this.modeTimeRadio.Text = "Test your daily configuration:";
            this.modeTimeRadio.UseVisualStyleBackColor = true;
            this.modeTimeRadio.CheckedChanged += new System.EventHandler(this.ModeTimeRadioCheckedChanged);
            // 
            // modeDirectMinLabel
            // 
            this.modeDirectMinLabel.AutoSize = true;
            this.modeDirectMinLabel.Location = new System.Drawing.Point(8, 72);
            this.modeDirectMinLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.modeDirectMinLabel.Name = "modeDirectMinLabel";
            this.modeDirectMinLabel.Size = new System.Drawing.Size(38, 13);
            this.modeDirectMinLabel.TabIndex = 4;
            this.modeDirectMinLabel.Text = "6500K";
            // 
            // modeDirectMaxLabel
            // 
            this.modeDirectMaxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modeDirectMaxLabel.AutoSize = true;
            this.modeDirectMaxLabel.Location = new System.Drawing.Point(368, 72);
            this.modeDirectMaxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.modeDirectMaxLabel.Name = "modeDirectMaxLabel";
            this.modeDirectMaxLabel.Size = new System.Drawing.Size(44, 13);
            this.modeDirectMaxLabel.TabIndex = 5;
            this.modeDirectMaxLabel.Text = "10000K";
            // 
            // modeDirectDefaultLabel
            // 
            this.modeDirectDefaultLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.modeDirectDefaultLabel.AutoSize = true;
            this.modeDirectDefaultLabel.Location = new System.Drawing.Point(190, 72);
            this.modeDirectDefaultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.modeDirectDefaultLabel.Name = "modeDirectDefaultLabel";
            this.modeDirectDefaultLabel.Size = new System.Drawing.Size(38, 13);
            this.modeDirectDefaultLabel.TabIndex = 3;
            this.modeDirectDefaultLabel.Text = "3000K";
            // 
            // modeDirectTrackBar
            // 
            this.modeDirectTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modeDirectTrackBar.LargeChange = 500;
            this.modeDirectTrackBar.Location = new System.Drawing.Point(8, 40);
            this.modeDirectTrackBar.Margin = new System.Windows.Forms.Padding(2);
            this.modeDirectTrackBar.Maximum = 10000;
            this.modeDirectTrackBar.Minimum = 3000;
            this.modeDirectTrackBar.Name = "modeDirectTrackBar";
            this.modeDirectTrackBar.Size = new System.Drawing.Size(404, 45);
            this.modeDirectTrackBar.SmallChange = 10;
            this.modeDirectTrackBar.TabIndex = 1;
            this.modeDirectTrackBar.TickFrequency = 500;
            this.modeDirectTrackBar.Value = 6500;
            this.modeDirectTrackBar.ValueChanged += new System.EventHandler(this.ModeDirectTrackBarValueChanged);
            // 
            // modeDirectRadio
            // 
            this.modeDirectRadio.AutoSize = true;
            this.modeDirectRadio.Location = new System.Drawing.Point(8, 24);
            this.modeDirectRadio.Margin = new System.Windows.Forms.Padding(2);
            this.modeDirectRadio.Name = "modeDirectRadio";
            this.modeDirectRadio.Size = new System.Drawing.Size(117, 17);
            this.modeDirectRadio.TabIndex = 0;
            this.modeDirectRadio.Text = "Test a temperature:";
            this.modeDirectRadio.UseVisualStyleBackColor = true;
            this.modeDirectRadio.CheckedChanged += new System.EventHandler(this.ModeDirectRadioCheckedChanged);
            // 
            // trayHelpLabel
            // 
            this.trayHelpLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trayHelpLabel.Location = new System.Drawing.Point(115, 152);
            this.trayHelpLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.trayHelpLabel.Name = "trayHelpLabel";
            this.trayHelpLabel.Size = new System.Drawing.Size(207, 19);
            this.trayHelpLabel.TabIndex = 5;
            this.trayHelpLabel.Text = "(start with option -m to minimize on start)";
            // 
            // pointsTextBox
            // 
            this.pointsTextBox.AcceptsReturn = true;
            this.pointsTextBox.AcceptsTab = true;
            this.pointsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pointsTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsTextBox.Location = new System.Drawing.Point(8, 42);
            this.pointsTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.pointsTextBox.Multiline = true;
            this.pointsTextBox.Name = "pointsTextBox";
            this.pointsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.pointsTextBox.Size = new System.Drawing.Size(200, 76);
            this.pointsTextBox.TabIndex = 0;
            this.pointsTextBox.TextChanged += new System.EventHandler(this.PointsTextBoxTextChanged);
            // 
            // updateTimer
            // 
            this.updateTimer.Interval = 60000;
            this.updateTimer.Tick += new System.EventHandler(this.UpdateTimerTick);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 388);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 8, 0);
            this.statusStrip.Size = new System.Drawing.Size(442, 22);
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
            this.contextMenuStripTray.Size = new System.Drawing.Size(140, 76);
            // 
            // toolStripMenuItemName
            // 
            this.toolStripMenuItemName.Enabled = false;
            this.toolStripMenuItemName.Name = "toolStripMenuItemName";
            this.toolStripMenuItemName.Size = new System.Drawing.Size(139, 22);
            this.toolStripMenuItemName.Text = "Menora v0.2";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(136, 6);
            // 
            // toolStripMenuItemConfig
            // 
            this.toolStripMenuItemConfig.Name = "toolStripMenuItemConfig";
            this.toolStripMenuItemConfig.Size = new System.Drawing.Size(139, 22);
            this.toolStripMenuItemConfig.Text = "Settings...";
            this.toolStripMenuItemConfig.Click += new System.EventHandler(this.ToolStripMenuItemConfigClick);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(139, 22);
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
            // configGroupBox
            // 
            this.configGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.configGroupBox.Controls.Add(this.trayCheckBox);
            this.configGroupBox.Controls.Add(this.trayLabel);
            this.configGroupBox.Controls.Add(this.intervalUnitLabel);
            this.configGroupBox.Controls.Add(this.intervalNumericUpDown);
            this.configGroupBox.Controls.Add(this.trayHelpLabel);
            this.configGroupBox.Controls.Add(this.intervalLabel);
            this.configGroupBox.Controls.Add(this.rulesTextBox);
            this.configGroupBox.Controls.Add(this.rulesLabel);
            this.configGroupBox.Controls.Add(this.pointsLabel);
            this.configGroupBox.Controls.Add(this.rulesButton);
            this.configGroupBox.Controls.Add(this.pointsTextBox);
            this.configGroupBox.Location = new System.Drawing.Point(11, 202);
            this.configGroupBox.Name = "configGroupBox";
            this.configGroupBox.Size = new System.Drawing.Size(420, 176);
            this.configGroupBox.TabIndex = 1;
            this.configGroupBox.TabStop = false;
            this.configGroupBox.Text = "Configuration editor";
            // 
            // trayCheckBox
            // 
            this.trayCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trayCheckBox.Location = new System.Drawing.Point(99, 147);
            this.trayCheckBox.Name = "trayCheckBox";
            this.trayCheckBox.Size = new System.Drawing.Size(22, 24);
            this.trayCheckBox.TabIndex = 4;
            this.trayCheckBox.UseVisualStyleBackColor = true;
            // 
            // trayLabel
            // 
            this.trayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trayLabel.Location = new System.Drawing.Point(8, 152);
            this.trayLabel.Name = "trayLabel";
            this.trayLabel.Size = new System.Drawing.Size(96, 23);
            this.trayLabel.TabIndex = 13;
            this.trayLabel.Text = "Minimize to tray:";
            // 
            // intervalUnitLabel
            // 
            this.intervalUnitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.intervalUnitLabel.Location = new System.Drawing.Point(153, 128);
            this.intervalUnitLabel.Name = "intervalUnitLabel";
            this.intervalUnitLabel.Size = new System.Drawing.Size(50, 23);
            this.intervalUnitLabel.TabIndex = 12;
            this.intervalUnitLabel.Text = "seconds";
            // 
            // intervalNumericUpDown
            // 
            this.intervalNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.intervalNumericUpDown.Location = new System.Drawing.Point(99, 126);
            this.intervalNumericUpDown.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.intervalNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.intervalNumericUpDown.Name = "intervalNumericUpDown";
            this.intervalNumericUpDown.Size = new System.Drawing.Size(48, 20);
            this.intervalNumericUpDown.TabIndex = 3;
            this.intervalNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.intervalNumericUpDown.ValueChanged += new System.EventHandler(this.IntervalNumericUpDownValueChanged);
            // 
            // intervalLabel
            // 
            this.intervalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.intervalLabel.Location = new System.Drawing.Point(8, 128);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(96, 23);
            this.intervalLabel.TabIndex = 10;
            this.intervalLabel.Text = "Update interval:";
            // 
            // rulesTextBox
            // 
            this.rulesTextBox.AcceptsReturn = true;
            this.rulesTextBox.AcceptsTab = true;
            this.rulesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rulesTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rulesTextBox.Location = new System.Drawing.Point(212, 42);
            this.rulesTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.rulesTextBox.Multiline = true;
            this.rulesTextBox.Name = "rulesTextBox";
            this.rulesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.rulesTextBox.Size = new System.Drawing.Size(200, 76);
            this.rulesTextBox.TabIndex = 1;
            this.rulesTextBox.TextChanged += new System.EventHandler(this.RulesTextBoxTextChanged);
            // 
            // rulesLabel
            // 
            this.rulesLabel.Location = new System.Drawing.Point(212, 24);
            this.rulesLabel.Name = "rulesLabel";
            this.rulesLabel.Size = new System.Drawing.Size(79, 23);
            this.rulesLabel.TabIndex = 8;
            this.rulesLabel.Text = "Behaviors:";
            // 
            // pointsLabel
            // 
            this.pointsLabel.Location = new System.Drawing.Point(8, 24);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(79, 13);
            this.pointsLabel.TabIndex = 7;
            this.pointsLabel.Text = "Temperatures:";
            // 
            // rulesButton
            // 
            this.rulesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rulesButton.Location = new System.Drawing.Point(380, 20);
            this.rulesButton.Name = "rulesButton";
            this.rulesButton.Size = new System.Drawing.Size(32, 21);
            this.rulesButton.TabIndex = 2;
            this.rulesButton.Text = "...";
            this.rulesButton.UseVisualStyleBackColor = true;
            this.rulesButton.Click += new System.EventHandler(this.RulesButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 410);
            this.Controls.Add(this.configGroupBox);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.modeGroupBox);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menora";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormClosed);
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.Resize += new System.EventHandler(this.MainFormResize);
            this.modeGroupBox.ResumeLayout(false);
            this.modeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modeTimeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeDirectTrackBar)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.contextMenuStripTray.ResumeLayout(false);
            this.configGroupBox.ResumeLayout(false);
            this.configGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar modeDirectTrackBar;
        private System.Windows.Forms.RadioButton modeDirectRadio;
        private System.Windows.Forms.RadioButton modeConfigRadio;
        private System.Windows.Forms.TrackBar modeTimeTrackBar;
        private System.Windows.Forms.RadioButton modeTimeRadio;
        private System.Windows.Forms.TextBox pointsTextBox;
        private System.Windows.Forms.Label modeTimeValue;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTray;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemConfig;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.GroupBox modeGroupBox;
        private System.Windows.Forms.Label trayHelpLabel;
        private System.Windows.Forms.Label modeTimeDefaultLabel;
        private System.Windows.Forms.Label modeTimeMaxLabel;
        private System.Windows.Forms.Label modeTimeMinLabel;
        private System.Windows.Forms.Label modeDirectMinLabel;
        private System.Windows.Forms.Label modeDirectMaxLabel;
        private System.Windows.Forms.Label modeDirectDefaultLabel;
        private System.Windows.Forms.GroupBox configGroupBox;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Label modeDirectValue;
        private System.Windows.Forms.Label modeTimeTemperature;
        private System.Windows.Forms.Button rulesButton;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.TextBox rulesTextBox;
        private System.Windows.Forms.Label rulesLabel;
        private System.Windows.Forms.Label intervalUnitLabel;
        private System.Windows.Forms.NumericUpDown intervalNumericUpDown;
        private System.Windows.Forms.Label intervalLabel;
        private System.Windows.Forms.CheckBox trayCheckBox;
        private System.Windows.Forms.Label trayLabel;
        private System.Windows.Forms.Label modeConfigValue;


    }
}

