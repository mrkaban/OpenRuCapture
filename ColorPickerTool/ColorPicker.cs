using System;
using OpenRuCapture.Libs;

namespace ColorPickerTool
{
    public class ColorPicker : ITool
    {
        public void Execute(params object[] args)
        {
            ColorPickerUI colorPickerUI = new ColorPickerUI();
            colorPickerUI.ShowDialog();
        }

        public string Name
        {
            get { return "Выбор цвета"; }
        }

        public string Description
        {
            get { return "Выбор цвета"; }
        }

        public string MenuCaption
        {
            get { return "Выбор цвета"; }
        }

        public bool IsVisible
        {
            get { return true; }
        }
    }
}
