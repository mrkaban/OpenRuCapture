using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace OpenRuCapture.Plugins
{
    public partial class SendToImgurUI : Form
    {
        private string _fileName;
        private BackgroundWorker _backgroundWorker;

        private const string APIKEY = "f076e01c7f4a35d3f8d4d5d6d2daa04d";
        private string _outputFilename;
        public SendToImgurUI()
        {
            InitializeComponent();
        }

        public SendToImgurUI(string fileName, string title)
            : this()
        {
            _fileName = fileName;
            _backgroundWorker = new BackgroundWorker();
            _backgroundWorker.WorkerReportsProgress = true;
            _backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorkerRunWorkerCompleted);
            _backgroundWorker.ProgressChanged += new ProgressChangedEventHandler(backgroundWorkerProgressChanged);
            _backgroundWorker.DoWork += new DoWorkEventHandler(backgroundWorkerDoWork);
            Text = title;
        }

        private void backgroundWorkerDoWork(object sender, DoWorkEventArgs e)
        {
            byte[] imageData;

            using (FileStream fileStream = File.OpenRead(_fileName))
            {
                imageData = new byte[fileStream.Length];
                fileStream.Read(imageData, 0, imageData.Length);
                fileStream.Close();
            }

            ReportProgress(10);
            const int MAX_URI_LENGTH = 32766;
            string base64img = System.Convert.ToBase64String(imageData);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < base64img.Length; i += MAX_URI_LENGTH)
            {
                sb.Append(Uri.EscapeDataString(base64img.Substring(i, Math.Min(MAX_URI_LENGTH, base64img.Length - i))));
            }
            ReportProgress(20);
            string uploadRequestString = "image=" + sb.ToString() + "&key=" + APIKEY;

            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create("http://api.imgur.com/2/upload");
            webRequest.Method = "POST";
            webRequest.ContentType = "application/x-www-form-urlencoded";
            webRequest.ServicePoint.Expect100Continue = false;
            ReportProgress(40);
            StreamWriter streamWriter = new StreamWriter(webRequest.GetRequestStream());
            streamWriter.Write(uploadRequestString);
            streamWriter.Close();
            ReportProgress(50);
            WebResponse response = webRequest.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader responseReader = new StreamReader(responseStream);
            ReportProgress(80);
            string responseString = responseReader.ReadToEnd();
            e.Result = responseString;
            ReportProgress(100);
        }

        private void backgroundWorkerProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            uploadProgress.Value = e.ProgressPercentage;
        }

        private void backgroundWorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                ParseAndDisplayResponse(e.Result.ToString());
            }
            else
            {
                throw new ApplicationException(e.Error.Message);
            }
            Close();
        }

        private void ParseAndDisplayResponse(string response)
        {
            var xml = new XmlDocument();
            xml.LoadXml(response);
            var url = xml.SelectSingleNode("/upload/links/original").InnerText;
            _outputFilename = url;

            xml = null;
            DialogResult = DialogResult.OK;
        }

        private void ReportProgress(int progress)
        {
            _backgroundWorker.ReportProgress(progress);
        }

        public string OutputFile
        {
            get
            {
                return _outputFilename;
            }
        }

        private void SendToImgurUI_Load(object sender, EventArgs e)
        {
            _backgroundWorker.RunWorkerAsync();
        }
    }
}
