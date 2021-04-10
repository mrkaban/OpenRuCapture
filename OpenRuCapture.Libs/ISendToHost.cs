using System;
using System.Collections.Generic;
using System.Text;

namespace OpenRuCapture.Libs
{
    public interface ISendToHost
    {
        void SaveConfiguration<T>(string pluginName, T configuration);
        T LoadConfiguration<T>(string pluginName);
    }
}
