using System;
using System.Collections.Generic;
using System.Text;
using OpenRuCapture.Libs;

namespace ImageEditor
{
    public class ImageEditorTool : ITool
    {
        public void Execute(params object[] args)
        {
            var frmMainUi = new FrmMainUI();
            frmMainUi.Show();
        }

        public string Name
        {
            get { return "Редактор скриншотов"; }
        }

        public string Description
        {
            get { return "Редактор скриншотов"; }
        }

        public string MenuCaption
        {
            get { return "Редактор скриншотов"; }
        }

        public bool IsVisible
        {
            get { return true; }
        }
    }
}
