namespace OpenRuCapture.Capturemodes
{
    using System.Drawing;
    using System.Windows.Forms;
    

    
    public class FixedRegionCapture : ICaptureMode
    {
        private string _folder;
        #region ICaptureMode Members

        public string Name
        {
            get { return "FixedRegionCapture"; }
        }

        public string Text
        {
            get { return "Фиксированная область"; }
        }

        //public Image Icon
        //{
        //    get { return Properties.Resources.fixedselection; }
        //}

        public string Description
        {
            get { return "Помогает захватить фиксированную область экрана. Дважды щелкните по области для сохранения. И ESC для отмены."; }
        }

        public Keys ShortcutKey
        {
            get { return Keys.Control & Keys.F; }
        }

        public bool IsEnabled
        {
            get { return true; }
        }

        public void Initialize(params object[] arguments)
        {
            _folder = arguments[0].ToString();
        }

        public string Execute()
        {
            string fileName = string.Empty;
            using (frmOverlay frmOverlay = new frmOverlay(fileName, Common.CaptureModes.FixedRectangle))
            {
                if (frmOverlay.ShowDialog() == DialogResult.OK)
                {
                    fileName = frmOverlay.FileName;
                }
            }
            return fileName;
        }

        public bool IsFinished
        {
            get { return false; }
        }

        #endregion
    }
}
