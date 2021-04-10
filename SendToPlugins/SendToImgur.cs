using System;
using System.Windows.Forms;
using OpenRuCapture.Libs;

namespace OpenRuCapture.Plugins
{
    public class SendToImgur : ISendTo
    {
        private SendToImgurUI _sendToImgurUI;

        public string Name
        {
            get { return "ОтправитьНаImgur"; }
        }

        public string Text
        {
            get { return "Imgur.com"; }
        }

        public void Execute(string filename)
        {
            _sendToImgurUI = new SendToImgurUI(filename, "Отправить на Imagur.com");
            if (_sendToImgurUI.ShowDialog() == DialogResult.OK)
            {
                string uploadedImageUrl = _sendToImgurUI.OutputFile;
                var result = MessageBox.Show(string.Format("Изображение загружено успешно. Вот URL : {0} Вы хотите скопировать URL в буфер обмена?"
                    , uploadedImageUrl), "Отправить в Imgur", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    Clipboard.SetText(uploadedImageUrl);
                }
            }
        }

        private ISendToHost _host;
        public ISendToHost Host
        {
            get
            {
                return _host;
            }
            set
            {
                _host = value;
            }
        }

        public void Dispose()
        {
            if (null != _sendToImgurUI)
            {
                _sendToImgurUI.Dispose();
            }
        }
    }
}
