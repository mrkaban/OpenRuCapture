namespace OpenRuCapture
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;
    using OpenRuCapture.Libs;

    public class KeyboardMapper
    {
        private static Dictionary<int, string> _keys = new Dictionary<int, string>();

        [Category("Capture Modes"), Action("OpenRuCapture.Capturemodes.FullScreenCapture")]
        [Description("Комбинация клавиш для полноэкранного захвата.")]
        public Keys FullScreen
        {
            get;
            set;
        }

        [Category("Capture Modes"), Action("OpenRuCapture.Capturemodes.FreeFormCapture")]
        [Description("Комбинация клавиш для захвата свободной формы.")]
        public Keys FreeForm
        {
            get;
            set;
        }

        [Category("Capture Modes"), Action("OpenRuCapture.Capturemodes.RectangleCapture")]
        [Description("Комбинация клавиш для захвата прямоугольного угла.")]
        public Keys Rectangle
        {
            get;
            set;
        }

        [Category("Capture Modes"), Action("OpenRuCapture.Capturemodes.CircleCapture")]
        [Description("Комбинация клавиш для захвата круга.")]
        public Keys Circle
        {
            get;
            set;
        }

        [Category("Capture Modes"), Action("OpenRuCapture.Capturemodes.FixedRegionCapture")]
        [Description("Комбинация клавиш для захвата фиксированного региона.")]
        public Keys FixedRegion
        {
            get;
            set;
        }

        [Category("Capture Modes"), Action("OpenRuCapture.Capturemodes.WindowCapture")]
        [Description("Комбинация клавиш для окна снимков.")]
        public Keys WindowCapture
        {
            get;
            set;
        }

        [Category("Capture Modes"), Action("OpenRuCapture.Capturemodes.ActiveWindowCapture")]
        [Description("Комбинация клавиш для захвата активного окна.")]
        public Keys ActiveWindow
        {
            get;
            set;
        }

        [Category("Send To"), Action("OpenRuCapture.Plugins.SendToClipboard", typeof(ISendTo))]
        [Description("Комбинация клавиш для отправки в буфер обмена.")]
        public Keys SendToClipboard
        {
            get;
            set;
        }

        [Category("Send To"), Action("OpenRuCapture.Plugins.SendToPrinter", typeof(ISendTo))]
        [Description("Комбинация клавиш для отправки на принтер.")]
        public Keys SendToPrinter
        {
            get;
            set;
        }

        [Category("Send To"), Action("OpenRuCapture.Plugins.SendToMailRecipient", typeof(ISendTo))]
        [Description("Комбинация клавиш для отправки почтовому клиенту.")]
        public Keys SendToMailRecipient
        {
            get;
            set;
        }

        public void Save()
        {
            Properties.Settings.Default.Shortcuts = Utilities.Serialize<KeyboardMapper>(this);
            Properties.Settings.Default.Save();
        }

        public static KeyboardMapper Load()
        {
            KeyboardMapper keyboardMapper = new KeyboardMapper();
            if (!string.IsNullOrEmpty(Properties.Settings.Default.Shortcuts))
            {
                keyboardMapper = Utilities.Deserialize<KeyboardMapper>(Properties.Settings.Default.Shortcuts);
            }
            return keyboardMapper;
        }

        #region fields

        public const int MOD_ALT = 0x1;
        public const int MOD_CONTROL = 0x2;
        public const int MOD_SHIFT = 0x4;
        public const int MOD_WIN = 0x8;
        public const int WM_HOTKEY = 0x312;

        #endregion

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vlc);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        public static void RegisterHotKeys(Form form, Keys key, int keyId, string property)
        {
            int modifiers = 0;

            if ((key & Keys.Alt) == Keys.Alt)
                modifiers = modifiers | MOD_ALT;

            if ((key & Keys.Control) == Keys.Control)
                modifiers = modifiers | MOD_CONTROL;

            if ((key & Keys.Shift) == Keys.Shift)
                modifiers = modifiers | MOD_SHIFT;

            Keys k = key & ~Keys.Control & ~Keys.Shift & ~Keys.Alt;
            //keyId = form.GetHashCode(); // this should be a key unique ID, modify this if you want more than one hotkey
            _keys.Add(keyId, property);
            RegisterHotKey((IntPtr)form.Handle, keyId, (uint)modifiers, (uint)k);
        }

        private delegate void Func();

        public static void UnregisterHotKeys(Form form)
        {
            try
            {
                foreach (var key in _keys)
                {
                    UnregisterHotKey(form.Handle, key.Key);                     // modify this if you want more than one hotkey
                }
                _keys.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static string GetProperty(int keyId)
        {
            return _keys[keyId];
        }
    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class ActionAttribute : Attribute
    {
        public string ActionMethod
        {
            private set;
            get;
        }

        public Type PluginType
        {
            private set;
            get;
        }

        public ActionAttribute(string actionMethod)
        {
            ActionMethod = actionMethod;
        }

        public ActionAttribute(string actionMethod, Type pluginType)
        {
            ActionMethod = actionMethod;
            PluginType = pluginType;
        }
    }
}

