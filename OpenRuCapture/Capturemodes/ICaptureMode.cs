namespace OpenRuCapture
{
    using System.Drawing;
    using System.Windows.Forms;

    public interface ICaptureMode
    {
        string Name { get; }
        string Text { get; }
        //Image Icon { get; }
        string Description { get; }
        Keys ShortcutKey { get; }
        bool IsEnabled { get; }
        void Initialize(params object[] arguments);
        string Execute();
        bool IsFinished { get; }
    }
}
