namespace OpenRuCapture
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Reflection;
    using System.Windows.Forms;
    using OpenRuCapture.Libs;

    public partial class frmSettings : Form, ISendToHost
    {
        #region Private variables

        private string _fileName;
        private string _captureMode;
        private object _windowHandle;
        private IEnumerable<ISendTo> _sendToPlugins;
        private KeyboardMapper _keyboardMapper;
        private bool _isShortcutsEnabled;

        #endregion

        public frmSettings()
        {
            InitializeComponent();
        }

        private void RegisterHotKeys(KeyboardMapper keyboardMapper)
        {
            var properties = keyboardMapper.GetType().GetProperties();
            int i = 100;
            foreach (var property in properties)
            {
                if (property.CanRead)
                {
                    var shortcut = (Keys)property.GetValue(keyboardMapper, null);
                    if (shortcut != Keys.None)
                    {
                        KeyboardMapper.RegisterHotKeys(this, shortcut, i++, property.Name);
                    }
                }
            }
        }

        private string Foldername
        {
            get
            {
                return Common.GetFoldername();
            }
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            Common.LoadImageFormats(ddlImageFormats);
            if (Properties.Settings.Default.ShowInfoOnStartup)
            {
                captureItSysTrayIcon.BalloonTipTitle = Constants.APP_TITLE;
                captureItSysTrayIcon.BalloonTipText = string.Format(Constants.APPINFOMESG, Constants.APP_TITLE);
                captureItSysTrayIcon.ShowBalloonTip(1);
            }

            txtFolder.Text = Foldername;
            txtSound.Text = Properties.Settings.Default.SoundFile;
            chkSoundNotification.Checked = Properties.Settings.Default.EnableSound;
            _isShortcutsEnabled = chkShortcutsEnabled.Checked = Properties.Settings.Default.EnableShortcuts;
            chkShowInfoAtStartup.Checked = Properties.Settings.Default.ShowInfoOnStartup;
            chkPromptToSave.Checked = Properties.Settings.Default.PromptToSave;
            chkExecuteAfterCapture.Checked = Properties.Settings.Default.ExecuteAfterCapture;
            chkIncludeCursor.Checked = Properties.Settings.Default.IncludeCursor;
            chkStartsWithWindows.Checked = Properties.Settings.Default.StartWithWindows;
            txtFileNameTemplate.Text = Properties.Settings.Default.FilenameTemplate;
            tbjpgQuality.Value = Properties.Settings.Default.JpegQuality;

            Common.LoadPlugins(captureToolStripMenuItem, Execute);
            Common.LoadGenericPlugins<ITool>(toolStripTools, ExecuteTools);
            _sendToPlugins = Common.LoadPlugins(ddlPlugins, toolStripSendTo, sendToMenuItem_Click);
            _keyboardMapper = KeyboardMapper.Load();
            if (null != _keyboardMapper)
            {
                RegisterHotKeys(_keyboardMapper);
            }
            else
            {
                _keyboardMapper = new KeyboardMapper();
            }
            keyboardProperties.SelectedObject = _keyboardMapper;
            string year = DateTime.Now.Year > 2017 ? DateTime.Now.Year.ToString() : "2017";
            lblYearInfo.Text = string.Format("Copyright © 2017 - {0} КонтинентСвободы.рф", year);
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            lblVersion.Text = string.Format("Версия:{0}", version);
            Visible = false;
        }

        private void LoadSettingsFromIniFile()
        {

        }

        private void ExecuteTools(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            ITool captureMode = menuItem.Tag as ITool;
            captureMode.Execute();
        }

        private void Execute(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;
            try
            {
                menuItem.Owner.Hide();
            }
            catch
            {
                //Ignore all the exceptions.
            }
            var captureMode = menuItem.Tag as ICaptureMode;
            captureMode.Initialize(new object[] { Foldername, this, Handle });
            _fileName = captureMode.Execute();
            Properties.Settings.Default.LastCaptureMode = captureMode.GetType().FullName;
            Properties.Settings.Default.Save();
            ExecuteAfterCapture();
        }

        private void sendToMenuItem_Click(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;
            var sendTo = menuItem.Tag as ISendTo;
            sendTo.Host = this;
            if (string.IsNullOrEmpty(_fileName) || !File.Exists(_fileName))
            {
                if (MessageBox.Show(Constants.IMAGE_SELECT_CONFIRM, Constants.APP_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    _fileName = Common.ShowOpenDialog(Constants.IMAGEFILTER, Constants.IMAGESELECTDLGTITLE);
                }
                else
                {
                    return; //No File selected or Found.
                }
            }
            sendTo.Execute(_fileName);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Properties.Settings.Default.ScheduledCapture)
                {
                    if (MessageBox.Show(string.Format(Constants.EXIT_CONFIRM, Environment.NewLine),
                        Constants.APP_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                }
                Properties.Settings.Default.ScheduledCapture = false;
                Properties.Settings.Default.Save();

                //Dispose all Plugins.

                foreach (var sendToPlugin in _sendToPlugins)
                {
                    sendToPlugin.Dispose();
                }

                Application.Exit();
            }
            catch { }
        }

        private void optionsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowUI();
            tcSettings.SelectedIndex = 0;
        }

        private void ShowUI()
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void frmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                WindowState = FormWindowState.Minimized;
                e.Cancel = true;
            }
            else
            {
                KeyboardMapper.UnregisterHotKeys(this);
                e.Cancel = false;
                captureItSysTrayIcon.Dispose();
            }
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.OutputFolder = string.IsNullOrEmpty(txtFolder.Text) ? Common.DefaultPath : txtFolder.Text;
            Properties.Settings.Default.ShowInfoOnStartup = chkShowInfoAtStartup.Checked;
            Properties.Settings.Default.EnableSound = chkSoundNotification.Checked;
            Properties.Settings.Default.SoundFile = txtSound.Text;
            Properties.Settings.Default.EnableShortcuts = chkShortcutsEnabled.Checked;
            Properties.Settings.Default.ImageFormat = Common.GetCurrentFormat(ddlImageFormats);
            Properties.Settings.Default.ExecuteAfterCapture = chkExecuteAfterCapture.Checked;
            Properties.Settings.Default.ExecuteAfterCapturePlugin = ddlPlugins.Items[ddlPlugins.SelectedIndex].ToString();
            Properties.Settings.Default.PromptToSave = chkPromptToSave.Checked;
            var keyboardMapper = keyboardProperties.SelectedObject as KeyboardMapper;
            Properties.Settings.Default.Shortcuts = Utilities.Serialize<KeyboardMapper>(keyboardMapper);
            Properties.Settings.Default.IncludeCursor = chkIncludeCursor.Checked;
            Properties.Settings.Default.StartWithWindows = chkStartsWithWindows.Checked;
            Properties.Settings.Default.FilenameTemplate = string.IsNullOrEmpty(txtFileNameTemplate.Text) ? Constants.DEFAULT_TEMPLATE : txtFileNameTemplate.Text;
            Properties.Settings.Default.JpegQuality = tbjpgQuality.Value;
            Properties.Settings.Default.Save();

            KeyboardMapper.UnregisterHotKeys(this);
            RegisterHotKeys(keyboardMapper);

            Close();
        }

        public void StartScheduledCapture(string captureMode, params object[] parameters)
        {
            _captureMode = captureMode;
            if (parameters != null)
            {
                _windowHandle = parameters[0];
            }
            scheduleTimer.Interval = Convert.ToInt32(Properties.Settings.Default.DefaultInterval) * 1000;
            scheduleTimer.Enabled = true;
            scheduleTimer.Start();
        }

        private void scheduleTimer_Tick(object sender, EventArgs e)
        {
            Properties.Settings.Default.ScheduledCapture = false;
            Properties.Settings.Default.Save();
            scheduleTimer.Stop();
            scheduleTimer.Enabled = false;
            _fileName = Common.ExecuteCaptureMode(_captureMode, new object[] { new object[] { Foldername, this, _windowHandle } }).ToString();
            //Scheduled capture doesn't support Repeat capture.
            Properties.Settings.Default.LastCaptureMode = null;
            Properties.Settings.Default.Save();
            ExecuteAfterCapture();
        }

        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowsingDialog = new FolderBrowserDialog())
            {
                folderBrowsingDialog.ShowNewFolderButton = true;
                folderBrowsingDialog.Description = Constants.SELECTFOLDER;
                if (folderBrowsingDialog.ShowDialog(this) == DialogResult.OK)
                {
                    txtFolder.Text = folderBrowsingDialog.SelectedPath;
                }
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case KeyboardMapper.WM_HOTKEY:
                    InvokeShortcut(m.WParam.ToInt32());
                    break;
            }
            base.WndProc(ref m);
        }

        private void InvokeShortcut(int keyId)
        {
            if (Program.IsCaptureIsActive)
            {
                return;
            }
            var property = _keyboardMapper.GetType().GetProperty(KeyboardMapper.GetProperty(keyId));

            var attribute = property.GetCustomAttributes(typeof(ActionAttribute), false)[0] as ActionAttribute;
            if (attribute.PluginType != default(Type) && attribute.PluginType == typeof(ISendTo))
            {
                if (string.IsNullOrEmpty(_fileName) || !File.Exists(_fileName))
                {
                    if (MessageBox.Show(Constants.IMAGE_SELECT_CONFIRM, Constants.APP_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        _fileName = Common.ShowOpenDialog(Constants.IMAGEFILTER, Constants.IMAGESELECTDLGTITLE);
                    }
                    else
                    {
                        return; //No File selected or Found.
                    }
                }
                Common.ExecutePlugin(_sendToPlugins, attribute.ActionMethod, _fileName, this);
            }
            else
            {
                _fileName = Common.ExecuteCaptureMode(attribute.ActionMethod, new object[] { new object[] { Foldername, this, Handle } }).ToString();
            }
            ExecuteAfterCapture();
        }

        private void frmSettings_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
        }

        private void frmSettings_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ShowHelp();
            e.Cancel = true;
        }

        private void ShowHelp()
        {
            //string appHelpFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), Constants.HELPFILE);
            //if (File.Exists(appHelpFile))
            //{
            //    Help.ShowHelp(this, appHelpFile);
            //}
            //else
            //{
            //    Process.Start(Constants.APP_URL);
            //}
            Process.Start(Constants.APP_URL);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(string.Format(Constants.ABOUT_MESSAGE, Environment.NewLine), Constants.APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowUI();
            tcSettings.SelectedIndex = 3;
        }

        private void toolStripExplore_Click(object sender, EventArgs e)
        {
            Explore();
        }

        private void Explore()
        {
            Process.Start(Foldername);
        }

        private void chkSoundNotification_CheckedChanged(object sender, EventArgs e)
        {
            cmdSelectSound.Enabled = txtSound.Enabled = chkSoundNotification.Checked;
        }

        private void cmdSelectSound_Click(object sender, EventArgs e)
        {
            txtSound.Text = Common.ShowOpenDialog(Constants.SOUNDFILTER, Constants.SELECTSOUND);
        }

        private void captureItSysTrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Explore();
        }

        private void toolStripHelpContents_Click(object sender, EventArgs e)
        {
            ShowHelp();
        }

        private void chkShortcutsEnabled_CheckedChanged(object sender, EventArgs e)
        {
            keyboardProperties.Enabled = chkShortcutsEnabled.Checked;
        }

        private void chkExecuteAfterCapture_CheckedChanged(object sender, EventArgs e)
        {
            ddlPlugins.Enabled = chkExecuteAfterCapture.Checked;
        }

        private void ExecuteAfterCapture()
        {
            if (!string.IsNullOrEmpty(_fileName))
            {
                if (Properties.Settings.Default.PromptToSave)
                {
                    _fileName = Common.ShowSaveDialog(ddlImageFormats, _fileName);
                }

                Common.PlaySound();

                if (Properties.Settings.Default.ExecuteAfterCapture)
                {
                    Common.ExecutePlugin(_sendToPlugins, Properties.Settings.Default.ExecuteAfterCapturePlugin, _fileName, this);
                }
            }
        }

        private void chkStartsWithWindows_CheckedChanged(object sender, EventArgs e)
        {
            Common.ToggleStartupRegistration(chkStartsWithWindows.Checked);
        }

        private void frmSettings_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            ShowHelp();
            hlpevent.Handled = true;
        }

        private void cmdInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format(Constants.TEMPLATE_HELP, Environment.NewLine), Constants.APP_TITLE);
        }

        private void ddlImageFormats_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbjpgQuality.Enabled = Common.GetCurrentFormat(ddlImageFormats).Equals("jpeg", StringComparison.CurrentCultureIgnoreCase);
        }

        private void llDownload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowHelp();
        }

        public void SaveConfiguration<T>(string pluginName, T configuration)
        {
            Utilities.WriteToConfigFile<T>(configuration, pluginName);
        }

        public T LoadConfiguration<T>(string pluginName)
        {
            return Utilities.ReadFromConfigFile<T>(pluginName);
        }

        private void ddlPlugins_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void keyboardProperties_Click(object sender, EventArgs e)
        {

        }
    }
}
