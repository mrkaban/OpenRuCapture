using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SendToPlugins
{
    public partial class SkydriveAuth : Form
    {
        private string _authCode;
        public SkydriveAuth()
        {
            InitializeComponent();
        }

        public string AuthCode
        {
            get
            {
                return _authCode;
            }
        }

        private static string scope = "wl.skydrive_update";
        private static string client_id = "000000004C0DF826";
        private static Uri signInUrl = new Uri(String.Format(@"https://login.live.com/oauth20_authorize.srf?client_id={0}&redirect_uri=https://login.live.com/oauth20_desktop.srf&response_type=token&scope={1}", client_id, scope));
        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.AbsoluteUri.Contains("#access_token="))
            {
                var x = e.Url.AbsoluteUri.Split(new[] { "#access_token" }, StringSplitOptions.RemoveEmptyEntries);
                _authCode = x[1].Split(new[] { '&' })[0];
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void SkydriveAuth_Load(object sender, EventArgs e)
        {
            webBrowser.Navigate(signInUrl);
        }
    }
}
