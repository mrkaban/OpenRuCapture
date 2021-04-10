using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace OpenRuCapture.Libs
{
    public static class Utilities
    {
        public static string Serialize<T>(T o)
        {
            StringBuilder stringBuilder = new StringBuilder();
            using (StringWriter stringWriter = new StringWriter(stringBuilder))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
                namespaces.Add(string.Empty, string.Empty);
                xmlSerializer.Serialize(stringWriter, o, namespaces);
                return stringBuilder.ToString();
            }
        }

        public static T Deserialize<T>(string s)
        {
            if (!string.IsNullOrEmpty(s))
            {
                using (StringReader stringWriter = new StringReader(s))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    return (T)xmlSerializer.Deserialize(stringWriter);
                }
            }
            else
            {
                return default(T);
            }
        }

        private static string GetPluginConfigurationPath(string fileName)
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "OpenRuCapture");
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            return Path.Combine(folderPath, fileName);
        }

        public static T ReadFromConfigFile<T>(string fileName)
        {
            using (StreamReader streamReader = new StreamReader(GetPluginConfigurationPath(Path.ChangeExtension(fileName,"cnf"))))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                return (T)xmlSerializer.Deserialize(streamReader);
            }
        }

        public static void WriteToConfigFile<T>(T o, string fileName)
        {
            using (StreamWriter streamWriter = new StreamWriter(GetPluginConfigurationPath(Path.ChangeExtension(fileName, "cnf"))))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                xmlSerializer.Serialize(streamWriter, o);
            }
        }
    }
}
