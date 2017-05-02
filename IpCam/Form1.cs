using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Diagnostics.Eventing.Reader;
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
        private int QualitySave { get; set; }
        private int QualityPreview { get; set; }

        private FilterInfoCollection VideoDevices { get; set; }
        private VideoCaptureDevice VideoSource { get; set; }

        public Form1()
        {
            InitializeComponent();

            FrameNumber = 1;
            QualitySave = 60;
            QualityPreview = 35;

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

                txtStatus.Text = @"Disconnect Camera";
                EnableUI(false);
            }
            else
            {
                VideoSource = new VideoCaptureDevice(VideoDevices[cbbCamName.SelectedIndex].MonikerString);
                VideoSource.NewFrame += videoSource_NewFrame;
                VideoSource.Start();

                txtStatus.Text = @"Connected Cam";
                EnableUI(true);
            }
        }


  
        private void btnRecord_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(@"D:\" + txtCamName.Text);

            timer.Interval = (int.Parse(cbbTimeInterval.Text) * 1000);
            timer.Start();
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
            try
            {
                if (pictureBox1.Image != null)
                {
                    var parthSave = txtParthSave.Text + "\\" + FrameNumber + ".bmp";
                    var parthPreview = txtParthPreview.Text;

                    QualitySave = int.Parse(textQualitySave.Text);
                    QualityPreview = int.Parse(txtQualityPreview.Text);

                    Bitmap bmp1 = new Bitmap(pictureBox1.Image);
                    ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);
                    System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;
                    EncoderParameters myEncoderParameters = new EncoderParameters(1);

                    EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, QualitySave);
                    myEncoderParameters.Param[0] = myEncoderParameter;
                    bmp1.Save(parthSave, jpgEncoder, myEncoderParameters);

                    EncoderParameter myEncoderParameter2 = new EncoderParameter(myEncoder, QualityPreview);
                    myEncoderParameters.Param[0] = myEncoderParameter2;
                    bmp1.Save(parthPreview, jpgEncoder, myEncoderParameters);

                    this.Invoke((MethodInvoker)delegate()
                    {
                        txtFrame.Text = FrameNumber.ToString();
                    });

                    FrameNumber++;
                }
            }
            catch
            {
                // ignored
            }
        }


        private void EnableUI(bool enable)
        {
            cbbTimeInterval.Enabled = enable;
            btnRecord.Enabled = enable;
            btnStop.Enabled = enable;
            txtFrame.Enabled = enable;
            txtStatus.Enabled = enable;
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