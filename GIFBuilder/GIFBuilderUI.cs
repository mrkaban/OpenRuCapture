using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace GIFBuilder
{
    public partial class GIFBuilderUI : Form
    {
        private ImageList _imageList;
        private string[] _selectedImages;
        private BackgroundWorker _backgroundWorker;
        private BackgroundWorker _fileLoadingWorker;
        private delegate void InsertImageToListDelegate(string image);

        public GIFBuilderUI()
        {
            InitializeComponent();
            _imageList = new ImageList();
            _imageList.ImageSize = new Size(64, 64);
            listPreviewImages.LargeImageList = _imageList;
            _backgroundWorker = new BackgroundWorker();
            _backgroundWorker.WorkerReportsProgress = true;
            _backgroundWorker.DoWork += BackgroundWorker_DoWork;
            _backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
            _backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
            _fileLoadingWorker = new BackgroundWorker();
            _fileLoadingWorker.WorkerReportsProgress = true;
            _fileLoadingWorker.ProgressChanged += FileLoadingWorker_ProgressChanged;
            _fileLoadingWorker.RunWorkerCompleted += FileLoadingWorker_RunWorkerCompleted;
            _fileLoadingWorker.DoWork += FileLoadingWorker_DoWork;
        }

        private void FileLoadingWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            FillListView(e.Argument as string[]);
        }

        private void FileLoadingWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ToggleButtons(true);
            string firstImage = _selectedImages[0];
            Image image = Image.FromFile(firstImage);
            numTargetHeight.Value = image.Height;
            numTargetWidth.Value = image.Width;
        }

        private void FileLoadingWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            BuildProgress.Value = e.ProgressPercentage;
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Файл GIF успешно сгенерирован.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            ToggleButtons(true);
        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            BuildProgress.Value = e.ProgressPercentage;
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] parameters = e.Argument as string[];
            GenerateGIFImage(parameters[0], parameters[1], parameters[2]);
        }

        private void ToggleButtons(bool isEnabled)
        {
            cmdBrowse.Enabled = isEnabled;
            cmdBuild.Enabled = isEnabled;
            cmdCancel.Enabled = isEnabled;
        }

        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDlg = new OpenFileDialog())
            {
                openFileDlg.Filter = "Поддерживаемые изображения|*.jpg;*.png;*.jpeg;*.bmp";
                openFileDlg.ShowHelp = false;
                openFileDlg.ShowReadOnly = false;
                openFileDlg.CheckFileExists = true;
                openFileDlg.Multiselect = true;
                openFileDlg.SupportMultiDottedExtensions = true;
                if (openFileDlg.ShowDialog(this) == DialogResult.OK)
                {
                    _selectedImages = openFileDlg.FileNames;
                    ToggleButtons(false);
                    listPreviewImages.Items.Clear();
                    _imageList.Images.Clear();
                    _fileLoadingWorker.RunWorkerAsync(openFileDlg.FileNames);
                }
            }
        }

        private void InsertImage(string image)
        {
            string key = Path.GetFileNameWithoutExtension(image);
            _imageList.Images.Add(key, Image.FromFile(image));
            listPreviewImages.Items.Add(key, key, key);
        }

        private void FillListView(string[] images)
        {
            int progressPercentage = 100 / images.Length;
            int progress = 0;
            foreach (string image in images)
            {
                progress++;
                ReportLoadingProgress(progress * progressPercentage);
                if (listPreviewImages.InvokeRequired)
                {
                    InsertImageToListDelegate fillListViewDelegate = new InsertImageToListDelegate(InsertImage);
                    listPreviewImages.Invoke(fillListViewDelegate, image);
                }
                else
                {
                    string key = Path.GetFileNameWithoutExtension(image);
                    _imageList.Images.Add(key, Image.FromFile(image));
                    listPreviewImages.Items.Add(key, key, key);
                }
            }
            ReportLoadingProgress(100);
        }

        private void cmdBuild_Click(object sender, EventArgs e)
        {
            string fileName = string.Empty;
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "GIF Файлы|*.gif";
                saveDialog.CheckPathExists = true;
                saveDialog.OverwritePrompt = true;
                saveDialog.AddExtension = true;
                saveDialog.FileName = "generated.gif";
                saveDialog.Title = "Сохранить сгенерированный файл GIF - GIF Builder";
                saveDialog.DefaultExt = "GIF";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = saveDialog.FileName;
                    if (fileName.Length >= 1)
                    {
                        ToggleButtons(false);
                        _backgroundWorker.RunWorkerAsync(new[] { fileName, numTargetHeight.Value.ToString(), numTargetWidth.Value.ToString() });
                    }
                }
            }
        }

        private void ReportConvertProgress(int progress)
        {
            _backgroundWorker.ReportProgress(progress);
        }

        private void ReportLoadingProgress(int progress)
        {
            _fileLoadingWorker.ReportProgress(progress);
        }

        private void GenerateGIFImage(string fileName, string height, string width)
        {
            int delay = Convert.ToInt32(numSeconds.Value) * 100;

            Byte[] buf1;
            Byte[] buf2;
            Byte[] buf3;

            buf2 = new Byte[19];
            buf3 = new Byte[8];
            buf2[0] = 33;
            buf2[1] = 255;
            buf2[2] = 11;
            buf2[3] = 78;
            buf2[4] = 69;
            buf2[5] = 84;
            buf2[6] = 83;
            buf2[7] = 67;
            buf2[8] = 65;
            buf2[9] = 80;
            buf2[10] = 69;
            buf2[11] = 50;
            buf2[12] = 46;
            buf2[13] = 48;
            buf2[14] = 3;
            buf2[15] = 1;
            buf2[16] = 0;
            buf2[17] = 0;
            buf2[18] = 0;
            buf3[0] = 33;
            buf3[1] = 249;
            buf3[2] = 4;
            buf3[3] = 9;
            buf3[4] = Convert.ToByte((delay & 0x00FF) % 256);
            buf3[5] = Convert.ToByte((delay & 0xFF00) / 256);
            buf3[6] = 255;
            buf3[7] = 0;
            ReportConvertProgress(10);
            int progress = 90 / _selectedImages.Length;
            int imageProgess = 1;
            StreamWriter sw = new StreamWriter(fileName);
            using (BinaryWriter binaryWriter = new BinaryWriter(sw.BaseStream))
            {
                for (int picCount = 0; picCount < _selectedImages.Length; picCount++, imageProgess++)
                {
                    using (Image image = FixedSize(Bitmap.FromFile(_selectedImages[picCount]), int.Parse(width), int.Parse(height)))
                    {
                        using (MemoryStream memoryStream = new MemoryStream())
                        {
                            image.Save(memoryStream, ImageFormat.Gif);
                            buf1 = memoryStream.ToArray();
                            if (picCount == 0)
                            {
                                binaryWriter.Write(buf1, 0, 781);
                                binaryWriter.Write(buf2, 0, 19);
                            }

                            binaryWriter.Write(buf3, 0, 8);
                            binaryWriter.Write(buf1, 789, buf1.Length - 790);
                            if (picCount == _selectedImages.Length - 1)
                            {
                                binaryWriter.Write(";");
                            }

                            memoryStream.SetLength(0);
                            ReportConvertProgress((progress * imageProgess) + 10);
                        }
                    }
                }
            }
            ReportConvertProgress(100);
        }

        private Image FixedSize(Image imgPhoto, int Width, int Height)
        {
            int sourceWidth = imgPhoto.Width;
            int sourceHeight = imgPhoto.Height;
            int sourceX = 0;
            int sourceY = 0;
            int destX = 0;
            int destY = 0;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = ((float)Width / (float)sourceWidth);
            nPercentH = ((float)Height / (float)sourceHeight);
            if (nPercentH < nPercentW)
            {
                nPercent = nPercentH;
                destX = System.Convert.ToInt16((Width -
                              (sourceWidth * nPercent)) / 2);
            }
            else
            {
                nPercent = nPercentW;
                destY = System.Convert.ToInt16((Height -
                              (sourceHeight * nPercent)) / 2);
            }

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap bmPhoto = new Bitmap(Width, Height,
                              PixelFormat.Format24bppRgb);
            bmPhoto.SetResolution(imgPhoto.HorizontalResolution,
                             imgPhoto.VerticalResolution);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);
            grPhoto.Clear(Color.Red);
            grPhoto.InterpolationMode =
                    InterpolationMode.HighQualityBicubic;

            grPhoto.DrawImage(imgPhoto,
                new Rectangle(destX, destY, destWidth, destHeight),
                new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
                GraphicsUnit.Pixel);

            grPhoto.Dispose();
            return bmPhoto;
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
