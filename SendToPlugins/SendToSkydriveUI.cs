using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace SendToPlugins
{
    public partial class SendToSkydriveUI : Form
    {
        private string _fileName;

        public SendToSkydriveUI()
        {
            InitializeComponent();
        }

        public SendToSkydriveUI(string fileName)
            : this()
        {
            _fileName = fileName;
        }

        private string ParseAndGetValue(string jsonText, string field)
        {
            var data = jsonText.Replace("\r\n", "").Replace("{", "").Replace("}", "").Replace("\"", "").Split(new[] { field }, StringSplitOptions.RemoveEmptyEntries);
            return data[1].Trim();
        }

        private void cmdSignIn_Click(object sender, EventArgs e)
        {
            SkydriveAuth skyDriveAuth = new SkydriveAuth();
            if (skyDriveAuth.ShowDialog() == DialogResult.OK)
            {
                string authCode = skyDriveAuth.AuthCode;
                string url = string.Format(@"https://apis.live.net/v5.0/me/skydrive/files/{0}?access_token={1}", Path.GetFileName(_fileName), authCode);
                using (var client = new WebClient())
                {
                    client.UploadProgressChanged += ClientUploadProgressChanged;
                    client.UploadDataCompleted += ClientUploadDataCompleted;
                    client.UploadDataAsync(new Uri(url), "PUT", ImageToByteArray(_fileName));
                }
            }
        }

        private void ClientUploadDataCompleted(object sender, UploadDataCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                throw new Exception("Не удалось загрузить в skydrive", e.Error);
            }

            var jsonText = ASCIIEncoding.ASCII.GetString(e.Result);
            string url = ParseAndGetValue(jsonText, "источник:");
            MessageBox.Show("Файл загружен в Skydrive", "Отправить в Sky drive", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        void ClientUploadProgressChanged(object sender, UploadProgressChangedEventArgs e)
        {
            if (uploadProgress.InvokeRequired)
            {
                uploadProgress.Invoke((MethodInvoker)delegate
                {
                    uploadProgress.Maximum = (int)e.TotalBytesToSend;
                    uploadProgress.Value = (int)e.BytesSent;
                });
            }
            else
            {
                uploadProgress.Maximum = (int)e.TotalBytesToSend;
                uploadProgress.Value = (int)e.BytesSent;
            }
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
    }
}
