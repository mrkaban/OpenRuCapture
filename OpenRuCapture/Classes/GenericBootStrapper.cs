using System;

namespace OpenRuCapture
{
    using System.Collections.Generic;
    using System.IO;
    using System.Reflection;
    using dotnetthoughts.OpenRuCapture;

    public class GenericBootStrapper<T>
    {
        public IEnumerable<T> Items
        {
            get;
            set;
        }

        public void Compose()
        {
            Compose(null);
        }

        public void Compose(string pluginDirectory)
        {
            try
            {
                List<T> plugins = new List<T>();
                PluginManager<T> pluginManager = new PluginManager<T>();
                plugins.AddRange(pluginManager.LoadFromAssembly(Assembly.GetExecutingAssembly()));
                if (pluginDirectory != null)
                {
                    string pluginPath = pluginDirectory;
                    if (Directory.Exists(pluginPath))
                    {
                        plugins.AddRange(pluginManager.LoadFromDirectory(pluginPath));
                    }
                }
                Items = plugins;
            }
            catch
            {

            }
        }
    }
}
