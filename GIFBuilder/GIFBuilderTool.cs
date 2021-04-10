using OpenRuCapture.Libs;

namespace GIFBuilder
{
    class GIFBuilderTool : ITool
    {
        public void Execute(params object[] args)
        {
            GIFBuilderUI gifBuilderUI = new GIFBuilderUI();
            gifBuilderUI.ShowDialog();
        }

        public string Name
        {
            get { return "Создание GIF"; }
        }

        public string Description
        {
            get { return "Помогает создавать файлы GIF из изображений"; }
        }

        public string MenuCaption
        {
            get { return "Создание GIF"; }
        }

        public bool IsVisible
        {
            get { return true; }
        }
    }
}
