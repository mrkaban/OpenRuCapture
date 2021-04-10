namespace OpenRuCapture.Capturemodes
{
    using System.Drawing;
    using System.Windows.Forms;
    

    
    public class CircleCapture : ICaptureMode
    {
        private string _folder;

        public string Name
        {
            get { return "CircleCapture"; }
        }

        public string Text
        {
            get { return "Круг"; }
        }

        //public Image Icon
        //{
        //    get { return Properties.Resources.circle; }
        //}

        public string Description
        {
            get { return "Помогает захватить круговую форму экрана. Нажмите ESC для отмены."; }
        }

        public Keys ShortcutKey
        {
            get { return Keys.Control & Keys.F11; }
        }

        public void Initialize(params object[] arguments)
        {
            _folder = arguments[0].ToString();
        }

        public string Execute()
        {
            string fileName = string.Empty;
            using (frmOverlay frmOverlay = new frmOverlay(fileName, Common.CaptureModes.Circle))
            {
                if (frmOverlay.ShowDialog() == DialogResult.OK)
                {
                    fileName = frmOverlay.FileName;
                }
            }
            return fileName;
        }

        public bool IsEnabled
        {
            get { return true; }
        }

        public bool IsFinished
        {
            get { return true; }
        }
    }
}
