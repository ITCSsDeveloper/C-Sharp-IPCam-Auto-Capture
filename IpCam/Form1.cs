using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace IpCam
{
    public partial class Form1 : Form
    {
        private int FrameNumber { get; set; }

        private FilterInfoCollection VideoDevices { get; set; }
        private VideoCaptureDevice VideoSource { get; set; }

        public Form1()
        {
            InitializeComponent();

            VideoSource = new VideoCaptureDevice();
            VideoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo device in VideoDevices)
            {
                cbbCamName.Items.Add(device.Name);
            }

            cbbCamName.SelectedIndex = 0;
            cbbTimeInterval.SelectedIndex = 0;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            if (now.Hour == txtHours.Value && now.Minute == txtMinute.Value)
            {
                if (!bgMoveImage.IsBusy)
                {
                    bgMoveImage.RunWorkerAsync();
                }
            }
        }

        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            return ImageCodecInfo.GetImageDecoders().FirstOrDefault(codec => codec.FormatID == format.Guid);
        }

        private void btnConnectCam_Click(object sender, EventArgs e)
        {
            if (VideoSource.IsRunning)
            {
                VideoSource.Stop();
                pictureBox1.Image = null;
                pictureBox1.Invalidate();
                Console("Disconnect Camera.");
                EnableUI(false);
            }
            else
            {
                VideoSource = new VideoCaptureDevice(VideoDevices[cbbCamName.SelectedIndex].MonikerString);
                VideoSource.NewFrame += videoSource_NewFrame;
                VideoSource.Start();
                Console("Connected Camera.");
                EnableUI(true);
            }
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            // ถ้ายังไม่เชื่อมต่อ Camera ให้ บอกให้กลับไปต่อก่อน
            if (!VideoSource.IsRunning)
            {
                MessageBox.Show(@"Please Select Camera And Connect");
                return;
            }

            // ถ้ายังไม่มี Folder ให้ สร้างใหม่
            if (!Directory.Exists(txtParthSave.Text.Trim()))
            {
                Directory.CreateDirectory(txtParthSave.Text.Trim());
                Console("Create Save Directory " + txtParthSave.Text.Trim());
            }

            // ถ้ายังไม่มี Folder ให้ สร้างใหม่
            //if (!Directory.Exists(txtParthPreview.Text.Trim()))
            //{
            //    Directory.CreateDirectory(txtParthPreview.Text.Trim());
            //    Console("Create Preview Directory " + txtParthPreview.Text.Trim());
            //}

            bgSaveImage.RunWorkerAsync();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (VideoSource.IsRunning)
            {
                timer.Stop();
                VideoSource.Stop();
                pictureBox1.Image = null;
                pictureBox1.Invalidate();
            }
        }

        private void bgMoveImage_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            var cameraName = txtCamName.Text;

            try
            {
                string folderName1 = DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + "_" + cameraName;

                this.Invoke((MethodInvoker)delegate() { txtConsole.AppendText("Start BackUP! " + DateTime.Now + "\n"); });

                Directory.Move(@"D:\" + cameraName, @"D:\" + folderName1);
                this.Invoke((MethodInvoker)delegate() { txtConsole.AppendText(folderName1 + " Coppy! \n"); });

                Directory.CreateDirectory(@"D:\" + cameraName);
                this.Invoke((MethodInvoker)delegate()
                {
                    txtConsole.AppendText(cameraName + " create! \n");
                    txtConsole.AppendText("Finished BackUP! " + DateTime.Now + "\n");
                });
            }
            catch
            {
                // ignored
            }

            FrameNumber = 1;
            this.Invoke((MethodInvoker)delegate() { txtConsole.ScrollToCaret(); });

            Thread.Sleep(1000 * 65);
        }

        private void bgSaveImage_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Console("Start Record");

            while (true)
            {
                try
                {
                    var bmp1 = new Bitmap(pictureBox1.Image);

                    var parthSave = txtParthSave.Text + "\\" + FrameNumber + ".bmp";
                    var parthPreview = txtParthPreview.Text;

                    var qualitySave = int.Parse(textQualitySave.Text);
                    var qualityPreview = int.Parse(txtQualityPreview.Text);

                    var jpgEncoder = GetEncoder(ImageFormat.Jpeg);
                    var myEncoderParameters = new EncoderParameters(1);

                    myEncoderParameters.Param[0] = new EncoderParameter(Encoder.Quality, qualitySave);
                    bmp1.Save(parthSave, jpgEncoder, myEncoderParameters);

                    myEncoderParameters.Param[0] = new EncoderParameter(Encoder.Quality, qualityPreview);
                    bmp1.Save(parthPreview, jpgEncoder, myEncoderParameters);

                    this.Invoke((MethodInvoker)delegate() { txtFrame.Text = FrameNumber.ToString(); });
                    FrameNumber++;
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }

                Thread.Sleep(1000);
            }
        }

        private void Console(string str)
        {
            this.Invoke((MethodInvoker)delegate()
            {
                txtConsole.AppendText(str + Environment.NewLine);
            });
        }

        private void EnableUI(bool enable)
        {
            cbbTimeInterval.Enabled = enable;
            btnRecord.Enabled = enable;
            btnStop.Enabled = enable;
            txtFrame.Enabled = enable;
            txtParthSave.Enabled = enable;
            txtParthPreview.Enabled = enable;
            textQualitySave.Enabled = enable;
            txtQualityPreview.Enabled = enable;
            txtCamName.Enabled = enable;
            txtHours.Enabled = enable;
            txtMinute.Enabled = enable;
        }
    }
}