namespace OpenRuCapture.Capturemodes
{
    using System.Drawing;
    using System.Windows.Forms;
    

    
    public class RectangleCapture : ICaptureMode
    {
        private string _folder;

        public string Name
        {
            get { return "RectangleCapture"; }
        }

        public string Text
        {
            get { return "Прямоугольник"; }
        }

        //public Image Icon
        //{
        //    get { return Properties.Resources.rectangle; }
        //}

        public string Description
        {
            get { return "Помогает захватить экран по форме прямоугольника. Нажмите ESC для отмены."; }
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
            using (frmOverlay frmOverlay = new frmOverlay(fileName, Common.CaptureModes.Rectangle))
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
