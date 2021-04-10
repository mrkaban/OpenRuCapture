namespace OpenRuCapture
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.IO;
    using System.Media;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;
    using System.Xml.Serialization;
    using OpenRuCapture.Capturemodes;
    using OpenRuCapture.Libs;
    using dotnetthoughts.OpenRuCapture;
    using Microsoft.Win32;
    using System.Xml;

    public static class Common
    {
        public enum CaptureModes
        {
            Rectangle, FreeForm, Circle, FixedRectangle, Polygon
        }

        public static string DefaultPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "OpenRuCapture");

        public static string GetFoldername()
        {
            string outputPath = string.IsNullOrEmpty(Properties.Settings.Default.OutputFolder) ? DefaultPath : Properties.Settings.Default.OutputFolder;
            if (!Directory.Exists(outputPath))
            {
                Directory.CreateDirectory(outputPath);
            }
            return outputPath;
        }
        public static string SaveImage(Bitmap bitmap)
        {
            return SaveImage(bitmap, string.Empty);
        }

        public static string SaveImage(Bitmap bitmap, string fileNameWithPath)
        {
            ImageFormat imageFormat = GetImageFormat(Properties.Settings.Default.ImageFormat);
            string fullPath = string.Empty;
            if (!string.IsNullOrEmpty(fileNameWithPath))
            {
                string fname = string.Concat(Path.GetFileNameWithoutExtension(fileNameWithPath), "_copy");
                fullPath = Path.Combine(Path.GetDirectoryName(fileNameWithPath), Path.ChangeExtension(fname, Path.GetExtension(fileNameWithPath)));
            }
            else
            {
                string newFileName = Path.ChangeExtension(GetFileName(), Common.CreatImageExtention(imageFormat));
                fullPath = Path.Combine(GetFoldername(), newFileName);
            }

            if (imageFormat == ImageFormat.Jpeg)
            {
                SaveJPGWithCompressionSetting(bitmap, fullPath, Properties.Settings.Default.JpegQuality);
            }
            else
            {
                bitmap.Save(fullPath, imageFormat);
            }
            return fullPath;
        }

        public static ImageFormat GetImageFormat(string fileType)
        {
            ImageFormat imageFormat = ImageFormat.Png;
            switch (fileType.ToLower())
            {
                case "bmp":
                    imageFormat = ImageFormat.Bmp;
                    break;
                case "jpg":
                case "jpeg":
                    imageFormat = ImageFormat.Jpeg;
                    break;
                case "png":
                    imageFormat = ImageFormat.Png;
                    break;
                case "gif":
                    imageFormat = ImageFormat.Gif;
                    break;
                case "tiff":
                    imageFormat = ImageFormat.Tiff;
                    break;
                case "wmf":
                    imageFormat = ImageFormat.Wmf;
                    break;
            }
            return imageFormat;
        }

        public static string CreatImageExtention(ImageFormat format)
        {
            string imageFormat = "png";
            if (format == ImageFormat.Bmp)
            {
                imageFormat = "bmp";
            }
            else if (format == ImageFormat.Jpeg)
            {
                imageFormat = "jpeg";
            }
            else if (format == ImageFormat.Png)
            {
                imageFormat = "png";
            }
            else if (format == ImageFormat.Tiff)
            {
                imageFormat = "tiff";
            }
            else if (format == ImageFormat.Wmf)
            {
                imageFormat = "wmf";
            }
            else if (format == ImageFormat.Gif)
            {
                imageFormat = "gif";
            }
            return imageFormat;
        }

        public static void RestoreIfMinimized(IntPtr handle)
        {
            if (NativeMethods.IsIconic(handle))
            {
                NativeMethods.ShowWindow(handle, NativeMethods.iRestore);
            }
            NativeMethods.SetForegroundWindow(handle);
        }

        public static void LoadImageFormats(ComboBox ddlImageFormats)
        {
            var imageFormats = new List<KeyValuePair<string, ImageFormat>>()
            {
                new KeyValuePair<string, ImageFormat>("PNG File",ImageFormat.Png),
                new KeyValuePair<string, ImageFormat>( "JPEG File",ImageFormat.Jpeg),
                new KeyValuePair<string, ImageFormat>( "BMP File",ImageFormat.Bmp ),
                new KeyValuePair<string, ImageFormat>( "TIFF File",ImageFormat.Tiff ),
                new KeyValuePair<string, ImageFormat>( "GIF File",ImageFormat.Gif ),
                new KeyValuePair<string, ImageFormat>( "WMF File",ImageFormat.Wmf )
            };
            ddlImageFormats.DisplayMember = "Key";
            ddlImageFormats.ValueMember = "Value";
            ddlImageFormats.DataSource = imageFormats;

            var imageformat = GetImageFormat(Properties.Settings.Default.ImageFormat);
            foreach (var item in ddlImageFormats.Items)
            {
                if (((KeyValuePair<string, ImageFormat>)item).Value == imageformat)
                {
                    ddlImageFormats.SelectedItem = item;
                    break;
                }
            }
        }

        public static IEnumerable<ISendTo> LoadPlugins(ComboBox ddlPlugins, ToolStripMenuItem toolStripSendTo, EventHandler sendToMenuItem_Click)
        {
            var bootStrapper = new GenericBootStrapper<ISendTo>();
            bootStrapper.Compose(Application.StartupPath);
            if (null != bootStrapper.Items)
            {
                ddlPlugins.Items.Clear();
                ddlPlugins.DisplayMember = "Name";
                ddlPlugins.ValueMember = "Name";
                ddlPlugins.DataSource = bootStrapper.Items;

                toolStripSendTo.DropDownItems.Clear();
                foreach (var menuItem in bootStrapper.Items)
                {
                    var sendToMenuItem = new ToolStripMenuItem(menuItem.Text);
                    sendToMenuItem.Click += sendToMenuItem_Click;
                    sendToMenuItem.Tag = menuItem;
                    toolStripSendTo.DropDownItems.Add(sendToMenuItem);
                }

                string pluginName = Properties.Settings.Default.ExecuteAfterCapturePlugin;
                for (int i = 0; i < ddlPlugins.Items.Count; i++)
                {
                    if ((ddlPlugins.Items[i] as ISendTo).GetType().FullName.Equals(pluginName, StringComparison.CurrentCultureIgnoreCase))
                    {
                        ddlPlugins.SelectedIndex = i;
                        break;
                    }
                }
            }
            return bootStrapper.Items;
        }

        public static string ShowOpenDialog(string filters, string title)
        {
            string result = null;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = filters;
                openFileDialog.CheckFileExists = true;
                openFileDialog.Multiselect = false;
                openFileDialog.ReadOnlyChecked = false;
                openFileDialog.Title = title;
                openFileDialog.ShowReadOnly = false;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    result = openFileDialog.FileName;
                }
            }
            return result;
        }

        public static void LoadWindows(ComboBox ddlWindows)
        {
            ddlWindows.Items.Clear();
            Process[] processes = Process.GetProcesses();
            ddlWindows.DisplayMember = "MainWindowTitle";
            ddlWindows.ValueMember = "MainWindowHandle";
            foreach (Process process in processes)
            {
                if (process.MainWindowTitle.Length >= 1)
                {
                    ddlWindows.Items.Add(process);
                    ddlWindows.SelectedIndex = 0;
                }
            }
        }

        public static void PlaySound()
        {
            if (!Properties.Settings.Default.EnableSound)
            {
                return;
            }

            string fileName = Properties.Settings.Default.SoundFile;
            if (!string.IsNullOrEmpty(fileName) && File.Exists(fileName))
            {
                SoundPlayer soundPlayer = new SoundPlayer(fileName);
                soundPlayer.Play();
            }
            else
            {
                SystemSounds.Beep.Play();
            }
        }

        public static string ShowSaveDialog(ComboBox ddlImageFormats, string fileName)
        {
            string tempFilename = string.Empty;
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.CustomPlaces.Add(Properties.Settings.Default.OutputFolder);
                saveFileDialog.FileName = Path.GetFileNameWithoutExtension(fileName);
                saveFileDialog.Filter = "PNG File|*.png|JPEG File|*.jpeg|BMP File|*.bmp|TIFF File|*.tiff|GIF File|*.gif|WMF File|*.wmf";
                saveFileDialog.OverwritePrompt = true;
                saveFileDialog.ShowHelp = false;
                saveFileDialog.FilterIndex = ddlImageFormats.SelectedIndex + 1;
                saveFileDialog.CheckPathExists = true;
                saveFileDialog.AddExtension = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tempFilename = saveFileDialog.FileName;
                    ImageFormat imageFormat = ImageFormat.Png;
                    switch (Path.GetExtension(tempFilename))
                    {
                        case ".bmp":
                            imageFormat = ImageFormat.Bmp;
                            break;
                        case ".jpg":
                            imageFormat = ImageFormat.Jpeg;
                            break;
                        case ".png":
                            imageFormat = ImageFormat.Png;
                            break;
                        case ".gif":
                            imageFormat = ImageFormat.Gif;
                            break;
                        case ".tiff":
                            imageFormat = ImageFormat.Tiff;
                            break;
                        case ".wmf":
                            imageFormat = ImageFormat.Wmf;
                            break;
                    }

                    if (fileName.Equals(tempFilename, StringComparison.CurrentCultureIgnoreCase))
                    {
                        Directory.SetCurrentDirectory(Path.GetDirectoryName(fileName));
                        string renamedFile = string.Format("~{0}", Path.GetFileName(fileName));
                        File.Move(Path.GetFileName(fileName), renamedFile);
                        fileName = renamedFile;
                    }

                    using (var bitmap = Image.FromFile(fileName))
                    {
                        bitmap.Save(tempFilename, imageFormat);
                    }
                }

                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                return tempFilename;
            }
        }

        public static IEnumerable<T> LoadGenericPlugins<T>(ToolStripMenuItem toolCaptures, EventHandler executeHandler)
        {
            toolCaptures.DropDownItems.Clear();
            var bootStrapper = new GenericBootStrapper<T>();
            bootStrapper.Compose(Application.StartupPath);

            if (null != bootStrapper.Items)
            {
                List<T> captureModes = new List<T>(bootStrapper.Items);
                foreach (var menuItem in captureModes)
                {
                    var capturemode = new ToolStripMenuItem(GetValue(menuItem, "MenuCaption").ToString());
                    capturemode.Visible = (bool)GetValue(menuItem, "IsVisible");
                    capturemode.Click += executeHandler;
                    capturemode.ToolTipText = GetValue(menuItem, "Description").ToString();
                    capturemode.Tag = menuItem;
                    toolCaptures.DropDownItems.Add(capturemode);
                }
            }
            return bootStrapper.Items;
        }

        public static object GetValue(object o, string property)
        {
            return o.GetType().GetProperty(property).GetValue(o, null);
        }

        public static IEnumerable<ICaptureMode> LoadPlugins(ToolStripMenuItem toolCaptures, EventHandler executeHandler)
        {
            toolCaptures.DropDownItems.Clear();
            var bootStrapper = new GenericBootStrapper<ICaptureMode>();
            bootStrapper.Compose();

            if (null != bootStrapper.Items)
            {
                List<ICaptureMode> captureModes = new List<ICaptureMode>(bootStrapper.Items);
                captureModes.Sort(delegate(ICaptureMode capturemode1, ICaptureMode capturemode2)
                {
                    return capturemode1.Name.CompareTo(capturemode2.Name);
                });

                foreach (var menuItem in captureModes)
                {
                    if (menuItem.IsEnabled)
                    {
                        var capturemode = new ToolStripMenuItem(menuItem.Text);
                        capturemode.Click += executeHandler;
                        capturemode.ToolTipText = menuItem.Description;
                        capturemode.Tag = menuItem;
                        toolCaptures.DropDownItems.Add(capturemode);
                    }
                }
            }
            return bootStrapper.Items;
        }

        public static string GetCurrentFormat(ComboBox ddlImageFormats)
        {
            var format = (KeyValuePair<string, ImageFormat>)ddlImageFormats.Items[ddlImageFormats.SelectedIndex];
            return format.Value.ToString();
        }

        public static object ExecuteCaptureMode(string captureMode, params object[] parameters)
        {
            object result = null;
            var pluginManager = new PluginManager<ICaptureMode>();
            pluginManager.ExecutePlugin(captureMode, Constants.INITMETHOD, parameters);
            result = pluginManager.ExecutePlugin(captureMode, Constants.EXECUTEMETHOD, null);
            pluginManager = null;
            return result;
        }

        public static void ExecutePlugin(IEnumerable<ISendTo> sendTos, string pluginName, string fileName, ISendToHost host)
        {
            ISendTo selectedSendTo = null;
            foreach (var sendTo in sendTos)
            {
                if (sendTo.GetType().FullName.Equals(pluginName, StringComparison.CurrentCultureIgnoreCase))
                {
                    selectedSendTo = sendTo;
                    selectedSendTo.Host = host;
                    break;
                }
            }
            if (selectedSendTo != null)
            {
                selectedSendTo.Execute(fileName);
            }
            //var currentSendTo = Activator.CreateInstance(Type.GetType(pluginName)) as ISendTo;
            //sendTo.Execute(fileName);
        }

        public static void ToggleStartupRegistration(bool register)
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Constants.REGISTRY_LOC, true);
            if (register)
            {
                registryKey.SetValue(Constants.APP_NAME, Application.ExecutablePath);
            }
            else
            {
                registryKey.DeleteValue(Constants.APP_NAME);
            }
        }

        public static string GetFileName()
        {
            string template = Properties.Settings.Default.FilenameTemplate;
            template = Regex.Replace(template, "%TICKS%", DateTime.Now.Ticks.ToString(), RegexOptions.IgnoreCase);
            template = Regex.Replace(template, "%DATE%", DateTime.Now.ToShortDateString(), RegexOptions.IgnoreCase);
            template = Regex.Replace(template, "%TIME%", DateTime.Now.ToShortTimeString(), RegexOptions.IgnoreCase);
            template = Regex.Replace(template, "%USER%", Environment.UserName, RegexOptions.IgnoreCase);
            template = Regex.Replace(template, "%SYSTEM%", Environment.MachineName, RegexOptions.IgnoreCase);
            template = Regex.Replace(template, "%AUTO%", GetCount(), RegexOptions.IgnoreCase);

            return FixFilename(template);
        }

        private static string FixFilename(string filename)
        {
            string invalidFileName = filename;
            string invalid = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            foreach (char c in invalid)
            {
                invalidFileName = invalidFileName.Replace(c.ToString(), "");
            }

            return invalidFileName;
        }

        public static string GetCount()
        {
            return (Directory.GetFiles(GetFoldername()).Length + 1).ToString();
        }

        private static ImageCodecInfo GetEncoderInfo(String mimeType)
        {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            }
            return null;
        }

        private static void SaveJPGWithCompressionSetting(Image image, string szFileName, long lCompression)
        {
            EncoderParameters eps = new EncoderParameters(1);
            eps.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, lCompression);
            ImageCodecInfo ici = GetEncoderInfo("image/jpeg");
            image.Save(szFileName, ici, eps);
        }
    }
}

