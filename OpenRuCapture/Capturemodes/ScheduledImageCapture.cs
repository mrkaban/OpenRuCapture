namespace OpenRuCapture.Capturemodes
{
    using System;
    using System.Drawing;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;
    

    
    public class ScheduledImageCapture : ICaptureMode
    {
        private string _folder;
        private object _owner;

        public string Name
        {
            get { return "ScheduledImageCapture"; }
        }

        public string Text
        {
            get { return "Запланированное"; }
        }

        //public Image Icon
        //{
        //    get { return Properties.Resources.timer; }
        //}

        public string Description
        {
            get { return "Помогает захватить экран после запланированного времени."; }
        }

        public Keys ShortcutKey
        {
            get { return Keys.Control & Keys.F11; }
        }

        public void Initialize(params object[] arguments)
        {
            _folder = arguments[0].ToString();
            _owner = arguments[1];
        }

        public string Execute()
        {
            using (frmScheduled frmScheduled = new frmScheduled())
            {
                frmSettings settings = _owner as frmSettings;
                if (frmScheduled.ShowDialog() == DialogResult.OK)
                {
                    settings.StartScheduledCapture(frmScheduled.CaptureMode, frmScheduled.Parameters);
                }
            }
            return string.Empty;
        }

        public bool IsEnabled
        {
            get { return true; }
        }

        public bool IsFinished
        {
            get { return false; }
        }
    }
}
