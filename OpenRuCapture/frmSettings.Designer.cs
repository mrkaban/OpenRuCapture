namespace OpenRuCapture
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.captureItSysTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctxMenuTrayIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.captureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSendTo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTools = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripExplore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.cmdBrowse = new System.Windows.Forms.Button();
            this.cmdOk = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.scheduleTimer = new System.Windows.Forms.Timer(this.components);
            this.ddlPlugins = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ddlImageFormats = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkExecuteAfterCapture = new System.Windows.Forms.CheckBox();
            this.chkPromptToSave = new System.Windows.Forms.CheckBox();
            this.keyboardProperties = new System.Windows.Forms.PropertyGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbjpgQuality = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdInfo = new System.Windows.Forms.Button();
            this.txtFileNameTemplate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkStartsWithWindows = new System.Windows.Forms.CheckBox();
            this.chkIncludeCursor = new System.Windows.Forms.CheckBox();
            this.tcSettings = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.tpMisc = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.chkShowInfoAtStartup = new System.Windows.Forms.CheckBox();
            this.cmdSelectSound = new System.Windows.Forms.Button();
            this.txtSound = new System.Windows.Forms.TextBox();
            this.chkSoundNotification = new System.Windows.Forms.CheckBox();
            this.chkShortcutsEnabled = new System.Windows.Forms.CheckBox();
            this.tpKeyboard = new System.Windows.Forms.TabPage();
            this.tpAbout = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.llDownload = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblYearInfo = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ctxMenuTrayIcon.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbjpgQuality)).BeginInit();
            this.tcSettings.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.tpMisc.SuspendLayout();
            this.tpKeyboard.SuspendLayout();
            this.tpAbout.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // captureItSysTrayIcon
            // 
            this.captureItSysTrayIcon.ContextMenuStrip = this.ctxMenuTrayIcon;
            this.captureItSysTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("captureItSysTrayIcon.Icon")));
            this.captureItSysTrayIcon.Text = "OpenRuCapture - Запущен";
            this.captureItSysTrayIcon.Visible = true;
            this.captureItSysTrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.captureItSysTrayIcon_MouseDoubleClick);
            // 
            // ctxMenuTrayIcon
            // 
            this.ctxMenuTrayIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.captureToolStripMenuItem,
            this.toolStripSeparator2,
            this.toolStripSendTo,
            this.toolStripSeparator1,
            this.toolStripTools,
            this.toolStripSeparator4,
            this.optionsToolStripMenuItem,
            this.toolStripSeparator3,
            this.toolStripExplore,
            this.toolStripMenuItem2,
            this.aboutToolStripMenuItem,
            this.toolStripMenuItem3,
            this.exitToolStripMenuItem});
            this.ctxMenuTrayIcon.Name = "ctxMenuTrayIcon";
            this.ctxMenuTrayIcon.Size = new System.Drawing.Size(239, 194);
            // 
            // captureToolStripMenuItem
            // 
            this.captureToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.captureToolStripMenuItem.Name = "captureToolStripMenuItem";
            this.captureToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.captureToolStripMenuItem.Text = "&Захват";
            this.captureToolStripMenuItem.ToolTipText = "Отображает различные параметры захвата";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(235, 6);
            // 
            // toolStripSendTo
            // 
            this.toolStripSendTo.Name = "toolStripSendTo";
            this.toolStripSendTo.Size = new System.Drawing.Size(238, 22);
            this.toolStripSendTo.Text = "&Отправить в";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(235, 6);
            // 
            // toolStripTools
            // 
            this.toolStripTools.Name = "toolStripTools";
            this.toolStripTools.Size = new System.Drawing.Size(238, 22);
            this.toolStripTools.Text = "&Инструменты";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(235, 6);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.optionsToolStripMenuItem.Text = "&Настройки";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(235, 6);
            // 
            // toolStripExplore
            // 
            this.toolStripExplore.Name = "toolStripExplore";
            this.toolStripExplore.Size = new System.Drawing.Size(238, 22);
            this.toolStripExplore.Text = "&Открыть каталог скриншотов";
            this.toolStripExplore.Click += new System.EventHandler(this.toolStripExplore_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(235, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.aboutToolStripMenuItem.Text = "&О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(235, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.exitToolStripMenuItem.Text = "&Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Папка для скриншотов:";
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(131, 17);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.ReadOnly = true;
            this.txtFolder.Size = new System.Drawing.Size(224, 20);
            this.txtFolder.TabIndex = 0;
            // 
            // cmdBrowse
            // 
            this.cmdBrowse.Location = new System.Drawing.Point(361, 15);
            this.cmdBrowse.Name = "cmdBrowse";
            this.cmdBrowse.Size = new System.Drawing.Size(24, 23);
            this.cmdBrowse.TabIndex = 1;
            this.cmdBrowse.Text = "...";
            this.cmdBrowse.UseVisualStyleBackColor = true;
            this.cmdBrowse.Click += new System.EventHandler(this.cmdBrowse_Click);
            // 
            // cmdOk
            // 
            this.cmdOk.Location = new System.Drawing.Point(257, 210);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(75, 23);
            this.cmdOk.TabIndex = 11;
            this.cmdOk.Text = "Ок";
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(338, 210);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 12;
            this.cmdCancel.Text = "&Отмена";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // scheduleTimer
            // 
            this.scheduleTimer.Interval = 1000;
            this.scheduleTimer.Tick += new System.EventHandler(this.scheduleTimer_Tick);
            // 
            // ddlPlugins
            // 
            this.ddlPlugins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlPlugins.Enabled = false;
            this.ddlPlugins.FormattingEnabled = true;
            this.ddlPlugins.Location = new System.Drawing.Point(131, 116);
            this.ddlPlugins.Name = "ddlPlugins";
            this.ddlPlugins.Size = new System.Drawing.Size(254, 21);
            this.ddlPlugins.TabIndex = 8;
            this.ddlPlugins.SelectedIndexChanged += new System.EventHandler(this.ddlPlugins_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Отправить в:";
            // 
            // ddlImageFormats
            // 
            this.ddlImageFormats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlImageFormats.FormattingEnabled = true;
            this.ddlImageFormats.Location = new System.Drawing.Point(131, 142);
            this.ddlImageFormats.Name = "ddlImageFormats";
            this.ddlImageFormats.Size = new System.Drawing.Size(254, 21);
            this.ddlImageFormats.TabIndex = 10;
            this.ddlImageFormats.SelectedIndexChanged += new System.EventHandler(this.ddlImageFormats_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Формат по умолчанию:";
            // 
            // chkExecuteAfterCapture
            // 
            this.chkExecuteAfterCapture.AutoSize = true;
            this.chkExecuteAfterCapture.Location = new System.Drawing.Point(131, 95);
            this.chkExecuteAfterCapture.Name = "chkExecuteAfterCapture";
            this.chkExecuteAfterCapture.Size = new System.Drawing.Size(206, 17);
            this.chkExecuteAfterCapture.TabIndex = 7;
            this.chkExecuteAfterCapture.Text = "Выполнение SendTo после захвата";
            this.chkExecuteAfterCapture.UseVisualStyleBackColor = true;
            this.chkExecuteAfterCapture.CheckedChanged += new System.EventHandler(this.chkExecuteAfterCapture_CheckedChanged);
            // 
            // chkPromptToSave
            // 
            this.chkPromptToSave.AutoSize = true;
            this.chkPromptToSave.Location = new System.Drawing.Point(131, 78);
            this.chkPromptToSave.Name = "chkPromptToSave";
            this.chkPromptToSave.Size = new System.Drawing.Size(140, 17);
            this.chkPromptToSave.TabIndex = 6;
            this.chkPromptToSave.Text = "Запрос на сохранение";
            this.chkPromptToSave.UseVisualStyleBackColor = true;
            // 
            // keyboardProperties
            // 
            this.keyboardProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keyboardProperties.HelpVisible = false;
            this.keyboardProperties.LineColor = System.Drawing.SystemColors.ControlDark;
            this.keyboardProperties.Location = new System.Drawing.Point(0, 0);
            this.keyboardProperties.Name = "keyboardProperties";
            this.keyboardProperties.Size = new System.Drawing.Size(389, 152);
            this.keyboardProperties.TabIndex = 0;
            this.keyboardProperties.Click += new System.EventHandler(this.keyboardProperties_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.keyboardProperties);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 152);
            this.panel1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Горячие клавиши:";
            // 
            // tbjpgQuality
            // 
            this.tbjpgQuality.LargeChange = 20;
            this.tbjpgQuality.Location = new System.Drawing.Point(117, 129);
            this.tbjpgQuality.Maximum = 100;
            this.tbjpgQuality.Minimum = 1;
            this.tbjpgQuality.Name = "tbjpgQuality";
            this.tbjpgQuality.Size = new System.Drawing.Size(254, 45);
            this.tbjpgQuality.SmallChange = 10;
            this.tbjpgQuality.TabIndex = 13;
            this.tbjpgQuality.TickFrequency = 10;
            this.tbjpgQuality.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tbjpgQuality.Value = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Шаблон имени файла :";
            // 
            // cmdInfo
            // 
            this.cmdInfo.Location = new System.Drawing.Point(361, 44);
            this.cmdInfo.Name = "cmdInfo";
            this.cmdInfo.Size = new System.Drawing.Size(24, 23);
            this.cmdInfo.TabIndex = 1;
            this.cmdInfo.Text = "?";
            this.cmdInfo.UseVisualStyleBackColor = true;
            this.cmdInfo.Click += new System.EventHandler(this.cmdInfo_Click);
            // 
            // txtFileNameTemplate
            // 
            this.txtFileNameTemplate.Location = new System.Drawing.Point(131, 46);
            this.txtFileNameTemplate.MaxLength = 125;
            this.txtFileNameTemplate.Name = "txtFileNameTemplate";
            this.txtFileNameTemplate.Size = new System.Drawing.Size(224, 20);
            this.txtFileNameTemplate.TabIndex = 0;
            this.txtFileNameTemplate.Text = "OpenRuCapture%TICKS%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Качество Jpeg:";
            // 
            // chkStartsWithWindows
            // 
            this.chkStartsWithWindows.AutoSize = true;
            this.chkStartsWithWindows.Location = new System.Drawing.Point(117, 107);
            this.chkStartsWithWindows.Name = "chkStartsWithWindows";
            this.chkStartsWithWindows.Size = new System.Drawing.Size(179, 17);
            this.chkStartsWithWindows.TabIndex = 9;
            this.chkStartsWithWindows.Text = "Запуск при загрузке Windows";
            this.chkStartsWithWindows.UseVisualStyleBackColor = true;
            this.chkStartsWithWindows.CheckedChanged += new System.EventHandler(this.chkStartsWithWindows_CheckedChanged);
            // 
            // chkIncludeCursor
            // 
            this.chkIncludeCursor.AutoSize = true;
            this.chkIncludeCursor.Location = new System.Drawing.Point(117, 90);
            this.chkIncludeCursor.Name = "chkIncludeCursor";
            this.chkIncludeCursor.Size = new System.Drawing.Size(202, 17);
            this.chkIncludeCursor.TabIndex = 9;
            this.chkIncludeCursor.Text = "&Включить курсор в снимок экрана";
            this.chkIncludeCursor.UseVisualStyleBackColor = true;
            this.chkIncludeCursor.CheckedChanged += new System.EventHandler(this.chkShortcutsEnabled_CheckedChanged);
            // 
            // tcSettings
            // 
            this.tcSettings.Controls.Add(this.tpGeneral);
            this.tcSettings.Controls.Add(this.tpMisc);
            this.tcSettings.Controls.Add(this.tpKeyboard);
            this.tcSettings.Controls.Add(this.tpAbout);
            this.tcSettings.Location = new System.Drawing.Point(4, 1);
            this.tcSettings.Name = "tcSettings";
            this.tcSettings.SelectedIndex = 0;
            this.tcSettings.Size = new System.Drawing.Size(409, 203);
            this.tcSettings.TabIndex = 14;
            // 
            // tpGeneral
            // 
            this.tpGeneral.BackColor = System.Drawing.Color.Transparent;
            this.tpGeneral.Controls.Add(this.label2);
            this.tpGeneral.Controls.Add(this.cmdInfo);
            this.tpGeneral.Controls.Add(this.txtFileNameTemplate);
            this.tpGeneral.Controls.Add(this.chkExecuteAfterCapture);
            this.tpGeneral.Controls.Add(this.txtFolder);
            this.tpGeneral.Controls.Add(this.label1);
            this.tpGeneral.Controls.Add(this.ddlPlugins);
            this.tpGeneral.Controls.Add(this.label6);
            this.tpGeneral.Controls.Add(this.label7);
            this.tpGeneral.Controls.Add(this.cmdBrowse);
            this.tpGeneral.Controls.Add(this.chkPromptToSave);
            this.tpGeneral.Controls.Add(this.ddlImageFormats);
            this.tpGeneral.Location = new System.Drawing.Point(4, 22);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(401, 177);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "Основное";
            // 
            // tpMisc
            // 
            this.tpMisc.BackColor = System.Drawing.Color.Transparent;
            this.tpMisc.Controls.Add(this.label5);
            this.tpMisc.Controls.Add(this.tbjpgQuality);
            this.tpMisc.Controls.Add(this.chkShowInfoAtStartup);
            this.tpMisc.Controls.Add(this.cmdSelectSound);
            this.tpMisc.Controls.Add(this.txtSound);
            this.tpMisc.Controls.Add(this.chkStartsWithWindows);
            this.tpMisc.Controls.Add(this.label4);
            this.tpMisc.Controls.Add(this.chkIncludeCursor);
            this.tpMisc.Controls.Add(this.chkSoundNotification);
            this.tpMisc.Controls.Add(this.chkShortcutsEnabled);
            this.tpMisc.Location = new System.Drawing.Point(4, 22);
            this.tpMisc.Name = "tpMisc";
            this.tpMisc.Padding = new System.Windows.Forms.Padding(3);
            this.tpMisc.Size = new System.Drawing.Size(401, 177);
            this.tpMisc.TabIndex = 1;
            this.tpMisc.Text = "Разное";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Звуковой файл:";
            // 
            // chkShowInfoAtStartup
            // 
            this.chkShowInfoAtStartup.AutoSize = true;
            this.chkShowInfoAtStartup.Location = new System.Drawing.Point(117, 11);
            this.chkShowInfoAtStartup.Name = "chkShowInfoAtStartup";
            this.chkShowInfoAtStartup.Size = new System.Drawing.Size(223, 17);
            this.chkShowInfoAtStartup.TabIndex = 8;
            this.chkShowInfoAtStartup.Text = "&Показывать информацию при запуске";
            this.chkShowInfoAtStartup.UseVisualStyleBackColor = true;
            // 
            // cmdSelectSound
            // 
            this.cmdSelectSound.Location = new System.Drawing.Point(347, 45);
            this.cmdSelectSound.Name = "cmdSelectSound";
            this.cmdSelectSound.Size = new System.Drawing.Size(24, 23);
            this.cmdSelectSound.TabIndex = 7;
            this.cmdSelectSound.Text = "...";
            this.cmdSelectSound.UseVisualStyleBackColor = true;
            this.cmdSelectSound.Click += new System.EventHandler(this.cmdSelectSound_Click);
            // 
            // txtSound
            // 
            this.txtSound.Location = new System.Drawing.Point(117, 46);
            this.txtSound.Name = "txtSound";
            this.txtSound.ReadOnly = true;
            this.txtSound.Size = new System.Drawing.Size(224, 20);
            this.txtSound.TabIndex = 6;
            // 
            // chkSoundNotification
            // 
            this.chkSoundNotification.AutoSize = true;
            this.chkSoundNotification.Location = new System.Drawing.Point(117, 28);
            this.chkSoundNotification.Name = "chkSoundNotification";
            this.chkSoundNotification.Size = new System.Drawing.Size(191, 17);
            this.chkSoundNotification.TabIndex = 9;
            this.chkSoundNotification.Text = "&Включить звуковое оповещение";
            this.chkSoundNotification.UseVisualStyleBackColor = true;
            this.chkSoundNotification.CheckedChanged += new System.EventHandler(this.chkSoundNotification_CheckedChanged);
            // 
            // chkShortcutsEnabled
            // 
            this.chkShortcutsEnabled.AutoSize = true;
            this.chkShortcutsEnabled.Location = new System.Drawing.Point(117, 73);
            this.chkShortcutsEnabled.Name = "chkShortcutsEnabled";
            this.chkShortcutsEnabled.Size = new System.Drawing.Size(171, 17);
            this.chkShortcutsEnabled.TabIndex = 9;
            this.chkShortcutsEnabled.Text = "&Включить сочетания клавиш";
            this.chkShortcutsEnabled.UseVisualStyleBackColor = true;
            this.chkShortcutsEnabled.CheckedChanged += new System.EventHandler(this.chkShortcutsEnabled_CheckedChanged);
            // 
            // tpKeyboard
            // 
            this.tpKeyboard.BackColor = System.Drawing.Color.Transparent;
            this.tpKeyboard.Controls.Add(this.panel1);
            this.tpKeyboard.Controls.Add(this.label3);
            this.tpKeyboard.Location = new System.Drawing.Point(4, 22);
            this.tpKeyboard.Name = "tpKeyboard";
            this.tpKeyboard.Padding = new System.Windows.Forms.Padding(3);
            this.tpKeyboard.Size = new System.Drawing.Size(401, 177);
            this.tpKeyboard.TabIndex = 2;
            this.tpKeyboard.Text = "Настройки клавиатуры";
            // 
            // tpAbout
            // 
            this.tpAbout.Controls.Add(this.panel2);
            this.tpAbout.Location = new System.Drawing.Point(4, 22);
            this.tpAbout.Name = "tpAbout";
            this.tpAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tpAbout.Size = new System.Drawing.Size(401, 177);
            this.tpAbout.TabIndex = 3;
            this.tpAbout.Text = "О программе";
            this.tpAbout.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.llDownload);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.lblYearInfo);
            this.panel2.Controls.Add(this.lblVersion);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 171);
            this.panel2.TabIndex = 4;
            // 
            // llDownload
            // 
            this.llDownload.AutoSize = true;
            this.llDownload.Location = new System.Drawing.Point(138, 136);
            this.llDownload.Name = "llDownload";
            this.llDownload.Size = new System.Drawing.Size(163, 13);
            this.llDownload.TabIndex = 4;
            this.llDownload.TabStop = true;
            this.llDownload.Text = "https://КонтинентСвободы.рф/";
            this.llDownload.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llDownload_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(138, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(232, 26);
            this.label11.TabIndex = 2;
            this.label11.Text = "Программа распространяется по лицензии \r\nGNU GPL v2";
            // 
            // lblYearInfo
            // 
            this.lblYearInfo.AutoSize = true;
            this.lblYearInfo.Location = new System.Drawing.Point(138, 74);
            this.lblYearInfo.Name = "lblYearInfo";
            this.lblYearInfo.Size = new System.Drawing.Size(208, 13);
            this.lblYearInfo.TabIndex = 2;
            this.lblYearInfo.Text = "Copyright © 2017 КонтинентСвободы.рф";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(138, 43);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(65, 13);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "Версия: 1.0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(138, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "OpenRuCapture";
            // 
            // frmSettings
            // 
            this.AcceptButton = this.cmdOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(420, 238);
            this.Controls.Add(this.tcSettings);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenRuCapture - Настройки";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.frmSettings_HelpButtonClicked);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSettings_FormClosing);
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.frmSettings_HelpRequested);
            this.Resize += new System.EventHandler(this.frmSettings_Resize);
            this.ctxMenuTrayIcon.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbjpgQuality)).EndInit();
            this.tcSettings.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.tpGeneral.PerformLayout();
            this.tpMisc.ResumeLayout(false);
            this.tpMisc.PerformLayout();
            this.tpKeyboard.ResumeLayout(false);
            this.tpKeyboard.PerformLayout();
            this.tpAbout.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon captureItSysTrayIcon;
        private System.Windows.Forms.ContextMenuStrip ctxMenuTrayIcon;
        private System.Windows.Forms.ToolStripMenuItem captureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button cmdBrowse;
        private System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripSendTo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStripExplore;
        private System.Windows.Forms.Timer scheduleTimer;
        private System.Windows.Forms.ComboBox ddlImageFormats;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PropertyGrid keyboardProperties;
        private System.Windows.Forms.ComboBox ddlPlugins;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkExecuteAfterCapture;
        private System.Windows.Forms.CheckBox chkPromptToSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkIncludeCursor;
        private System.Windows.Forms.CheckBox chkStartsWithWindows;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdInfo;
        private System.Windows.Forms.TextBox txtFileNameTemplate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar tbjpgQuality;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tcSettings;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.TabPage tpMisc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkShowInfoAtStartup;
        private System.Windows.Forms.Button cmdSelectSound;
        private System.Windows.Forms.TextBox txtSound;
        private System.Windows.Forms.CheckBox chkSoundNotification;
        private System.Windows.Forms.TabPage tpKeyboard;
        private System.Windows.Forms.CheckBox chkShortcutsEnabled;
        private System.Windows.Forms.TabPage tpAbout;
        private System.Windows.Forms.Label lblYearInfo;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel llDownload;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripMenuItem toolStripTools;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}

