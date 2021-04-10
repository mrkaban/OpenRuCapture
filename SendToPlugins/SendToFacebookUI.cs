using OpenRuCapture.Libs;
using System;
using System.Drawing;
using System.Net;
using System.Web;
using System.Windows.Forms;

namespace SendToPlugins
{
    public partial class SendToFacebookUI : Form, ISendTo
    {
        private ISendToHost _sendToHost;
        private const string AppId = "642406625770868";
        private const string AuthUrl = "https://graph.facebook.com/oauth/authorize?client_id={0}&redirect_uri={1}&display=popup&scope=publish_stream&response_type=code%20token";
        public const string AppCallbackUrl = "https://www.facebook.com/connect/login_success.html";
        private string _fileName;

        public SendToFacebookUI()
        {
            InitializeComponent();
        }

        string ISendTo.Name
        {
            get { return "SendToFacebook"; }
        }

        string ISendTo.Text
        {
            get { return "Facebook"; }
        }

        void ISendTo.Execute(string filename)
        {
            _fileName = filename;
            picPreview.Image = Image.FromFile(_fileName);
            Show();
        }

        ISendToHost ISendTo.Host
        {
            get
            {
                return _sendToHost;
            }
            set
            {
                _sendToHost = value;
            }
        }

        void IDisposable.Dispose()
        {

        }

        private void cmdUpload_Click(object sender, EventArgs e)
        {
            using (var commonAuthDlg = new CommonAuthDialog(AuthUrl, AppCallbackUrl, AppId))
            {
                if (commonAuthDlg.ShowDialog() == DialogResult.OK)
                {
                    string uploadUrl = string.Format("https://graph.facebook.com/me/photos?message={0}&access_token={1}", HttpUtility.UrlEncode(txtComment.Text), commonAuthDlg.AuthCode);
                    progressUpload.Visible = true;
                    cmdClose.Enabled = false;
                    cmdUpload.Enabled = false;
                    var webClient = new WebClient();
                    webClient.UploadFileCompleted += (o, ev) =>
                    {
                        progressUpload.Visible = false;
                        cmdClose.Enabled = true;
                        cmdUpload.Enabled = true;
                        if (ev.Error == null)
                        {
                            MessageBox.Show("Изображение успешно загружено.", "Отправить в Facebook", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(string.Format("Не удалось загрузить изображение на facebook{0}Details : {1}", Environment.NewLine, ev.Error.Message),
                                "Отправить в Facebook", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    };

                    webClient.UploadProgressChanged += (o, ev) =>
                    {
                        progressUpload.Value = ev.ProgressPercentage;
                    };

                    webClient.UploadFileAsync(new Uri(uploadUrl), "POST", _fileName);
                }
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
