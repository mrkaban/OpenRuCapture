using OpenRuCapture.Libs;

namespace ImageEditor
{
    class SendToScreenShotEditor : ISendTo
    {
        public string Name
        {
            get { return "Редактор скриншотов"; }
        }

        public string Text
        {
            get { return "Редактор скриншотов"; }
        }

        public void Execute(string filename)
        {
            using (FrmMainUI frmMainUI = new FrmMainUI(filename))
            {
                frmMainUI.ShowDialog();
            }
        }

        public ISendToHost Host
        {
            get;
            set;
        }

        public void Dispose()
        {
            //nothing
        }
    }
}
