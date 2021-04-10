using System;
using System.Windows.Forms;

namespace SendToPlugins
{
    public partial class CommonAuthDialog : Form
    {
        public CommonAuthDialog()
        {
            InitializeComponent();
        }

        public CommonAuthDialog(string authUrl, string callbackUrl, string appId)
            : this()
        {
            _authUrl = authUrl;
            _callbackUrl = callbackUrl;
            _appId = appId;
        }

        private string _authCode;
        private string _authUrl;
        private string _callbackUrl;
        private string _appId;

        public string AuthCode
        {
            get
            {
                return _authCode;
            }
        }

        private void webBrowserAuth_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.AbsoluteUri.Contains("&access_token="))
            {
                var x = e.Url.AbsoluteUri.Split(new[] { "&access_token=" }, StringSplitOptions.None);
                _authCode = x[1].Split(new[] { '&' })[0];
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void webBrowserAuth_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {

        }

        private void CommonAuthDialog_Load(object sender, EventArgs e)
        {
            webBrowserAuth.Navigate(string.Format(_authUrl, _appId, _callbackUrl));
        }
    }
}
