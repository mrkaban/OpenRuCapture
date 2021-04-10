namespace OpenRuCapture
{
    using OpenRuCapture.Libs;
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Windows.Forms;

    static class Program
    {
        private static bool _isCaptureIsActive;
        public static bool IsCaptureIsActive
        {
            get
            {
                return _isCaptureIsActive;
            }
            set
            {
                _isCaptureIsActive = value;
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += Application_ThreadException;
            Process currentProcess = Process.GetCurrentProcess();
            Process[] processItems = Process.GetProcessesByName(currentProcess.ProcessName);
            foreach (Process item in processItems)
            {
                if (item.Id != currentProcess.Id)
                {
                    MessageBox.Show(Constants.APP_ALREADY_RUNNING, Constants.APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            Application.Run(new frmSettings());
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            string logPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string file = Path.ChangeExtension("OpenRuCapture_log", ".txt");
            string logFile = Path.Combine(logPath, file);
            var logger = new Logger(logFile);
            logger.WriteLog(e.Exception);
            MessageBox.Show(string.Format(Constants.APP_EXCEPTION, Environment.NewLine), Constants.APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            Process.Start(logFile);
        }
    }
}
