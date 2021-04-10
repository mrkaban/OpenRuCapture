using System;
using System.Collections.Generic;
using System.Text;

namespace OpenRuCapture.Libs
{
    public interface ITool
    {
        void Execute(params object[] args);
        string Name { get; }
        string Description { get; }
        string MenuCaption { get; }
        bool IsVisible { get; }
    }
}
