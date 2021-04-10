namespace OpenRuCapture.Capturemodes
{
    using System;
    using System.Windows.Forms;
    using System.Threading;
    using System.Diagnostics;

    public partial class frmScheduled : Form
    {
        public frmScheduled()
        {
            InitializeComponent();
        }

        private void rbWindow_CheckedChanged(object sender, EventArgs e)
        {
            ddlWindows.Enabled = rbWindow.Checked;
            Common.LoadWindows(ddlWindows);
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ScheduledCapture = true;
            Properties.Settings.Default.DefaultInterval = int.Parse(numScheduleTime.Value.ToString());
            Properties.Settings.Default.Save();
            if (rbActiveWindow.Checked)
            {
                CaptureMode = rbActiveWindow.Tag.ToString();
            }
            else if(rbFullScreen.Checked)
            {
                CaptureMode = rbFullScreen.Tag.ToString();
            }
            else
            {
                CaptureMode = rbWindow.Tag.ToString();
                var process = ddlWindows.Items[ddlWindows.SelectedIndex] as Process;
                var processHandle = process.MainWindowHandle;
                Common.RestoreIfMinimized(processHandle);
                Thread.Sleep(500);
                Parameters = new object[] { processHandle };
            }
            Close();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string CaptureMode
        {
            get;
            private set;
        }

        public object[] Parameters
        {
            get;
            private set;
        }

        private void frmScheduled_Load(object sender, EventArgs e)
        {
            numScheduleTime.Value = Properties.Settings.Default.DefaultInterval;
            cmdOk.Enabled = !Properties.Settings.Default.ScheduledCapture;
        }
    }
}
