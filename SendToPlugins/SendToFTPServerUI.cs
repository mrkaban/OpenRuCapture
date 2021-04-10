using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace SendToPlugins
{
    public partial class SendToFTPServerUI : Form
    {
        public SendToFTPServerUI()
        {
            InitializeComponent();
        }

        private string _fileName;
        public SendToFTPServerUI(string fileName)
            : this()
        {
            _fileName = fileName;
        }

        private void cmdConnectAndUpload_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtServer.Text.StartsWith("ftp://"))
                {
                    txtServer.SelectionStart = 0;
                    txtServer.SelectionLength = 0;
                    txtServer.SelectedText = "ftp://";
                }

                string url = txtServer.Text + "/" + Path.GetFileName(_fileName);
                FtpWebRequest ftpWebRequest = WebRequest.Create(url) as FtpWebRequest;
                ftpWebRequest.Method = WebRequestMethods.Ftp.UploadFile;
                if (chkAnonymous.Checked)
                {
                    ftpWebRequest.Credentials = new NetworkCredential("anonymous", "anonymous");
                }
                else
                {
                    ftpWebRequest.Credentials = new NetworkCredential(txtUsername.Text, txtPassword.Text);
                }

                byte[] imageData = ImageToByteArray(_fileName);
                ftpWebRequest.ContentLength = imageData.Length;
                
                using (Stream requestStream = ftpWebRequest.GetRequestStream())
                {
                    requestStream.Write(imageData, 0, imageData.Length);
                }

                FtpWebResponse response = ftpWebRequest.GetResponse() as FtpWebResponse;
                if (response.StatusCode == FtpStatusCode.ClosingData)
                {
                    DialogResult = DialogResult.OK;
                }
            }
            catch
            {
                DialogResult = DialogResult.Cancel;
                throw;
            }
            Close();
        }

        public byte[] ImageToByteArray(string fileName)
        {
            byte[] imageData;
            using (FileStream fileStream = File.OpenRead(fileName))
            {
                imageData = new byte[fileStream.Length];
                fileStream.Read(imageData, 0, imageData.Length);
                fileStream.Close();
            }
            return imageData;
        }

        private void chkAnonymous_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.Enabled = txtUsername.Enabled = !chkAnonymous.Checked;
        }
    }
}
