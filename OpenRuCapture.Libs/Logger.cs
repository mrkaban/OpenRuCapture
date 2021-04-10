using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OpenRuCapture.Libs
{
    public class Logger
    {
        private string _fileName;

        public Logger(string fileName)
        {
            _fileName = fileName;
        }

        public void WriteLog(Exception exception)
        {
            using (StreamWriter streamWriter = new StreamWriter(_fileName, true))
            {
                streamWriter.WriteLine();
                streamWriter.WriteLine("Data Time :{0}", DateTime.Now);
                streamWriter.WriteLine("OS :{0}", Environment.OSVersion);
                streamWriter.WriteLine(".Net Framework :{0}", Environment.Version);
                streamWriter.WriteLine("exception :{0}{1}", Environment.NewLine, exception);
                streamWriter.WriteLine();
            }
        }
    }
}
