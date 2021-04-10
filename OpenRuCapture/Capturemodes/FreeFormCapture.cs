namespace OpenRuCapture.Capturemodes
{
    using System.Windows.Forms;

    public class FreeFormCapture : ICaptureMode
    {
        private string _folder;

        public string Name
        {
            get { return "FreeFormCapture"; }
        }

        public string Text
        {
            get { return "СвободнаяФорма"; }
        }

        //public Image Icon
        //{
        //    get { return Properties.Resources.freeform; }
        //}

        public string Description
        {
            get { return "Помогает захватывать любую фигуру, нарисованную с помощью мыши. Нажмите ESC для отмены."; }
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
            using (frmOverlay frmOverlay = new frmOverlay(fileName, Common.CaptureModes.FreeForm))
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
