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
        private int k = 1;
        private int QualitySave = 60;
        private int QualityPreview = 35;

        private DateTime now = DateTime.Now;
        private bool flag = true;

        private FilterInfoCollection VideoDevices { get; set; }
        private VideoCaptureDevice VideoSource { get; set; }

        public Form1()
        {
            InitializeComponent();

            VideoSource = new VideoCaptureDevice();
            VideoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            // Add Video Devices To Combo
            foreach (FilterInfo device in VideoDevices)
            {
                cbbCamName.Items.Add(device.Name);
            }

            cbbCamName.SelectedIndex = 0;
        }

        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Thread.Sleep(100);
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (VideoSource.IsRunning)
            {
                timer1.Stop();
                VideoSource.Stop();
                pictureBox1.Image = null;
                pictureBox1.Invalidate();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Thread TT = new Thread(Capture);
            TT.Start();
        }

        private void Capture()
        {
            try
            {
                if (pictureBox1.Image != null)
                {
                    string parth_save = txtParthSave.Text + "\\" + k + ".bmp";
                    string parth_preview = txtParthPreview.Text;

                    QualitySave = int.Parse(textQualitySave.Text);
                    QualityPreview = int.Parse(txtQualityPreview.Text);

                    Bitmap bmp1 = new Bitmap(pictureBox1.Image);
                    ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);
                    System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;
                    EncoderParameters myEncoderParameters = new EncoderParameters(1);

                    EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, QualitySave);
                    myEncoderParameters.Param[0] = myEncoderParameter;
                    bmp1.Save(parth_save, jpgEncoder, myEncoderParameters);

                    EncoderParameter myEncoderParameter2 = new EncoderParameter(myEncoder, QualityPreview);
                    myEncoderParameters.Param[0] = myEncoderParameter2;
                    bmp1.Save(parth_preview, jpgEncoder, myEncoderParameters);

                    this.Invoke((MethodInvoker)delegate()
                    {
                        txtFrame.Text = "" + k;
                    });

                    k++;
                }
            }
            catch (Exception e)
            {
            }
        }

        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            var codecs = ImageCodecInfo.GetImageDecoders();
            return codecs.FirstOrDefault(codec => codec.FormatID == format.Guid);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            now = DateTime.Now;
            if (flag == false)
            {
                return;
            }

            if (now.Hour.ToString() == txtHours.Text && now.Minute.ToString() == txtMinute.Text)
            {
                Thread TT = new Thread(MoveImage);
                TT.Start();
            }
        }

        private void MoveImage()
        {
            flag = false; // กัน timer2 เข้ามาทำ ขณะที่ทำงานอยู่

            string cameraName = txtCamName.Text;

            try
            {
                string folder_name1 = now.Day.ToString() + "-" + now.Month.ToString() + "-" + now.Year.ToString() + "_" + cameraName;

                this.Invoke((MethodInvoker)delegate() { txtConsole.AppendText("Start BackUP! " + now.ToString() + "\n"); });

                Directory.Move(@"D:\" + cameraName, @"D:\" + folder_name1);
                this.Invoke((MethodInvoker)delegate() { txtConsole.AppendText(folder_name1 + " Coppy! \n"); });

                Directory.CreateDirectory(@"D:\" + cameraName);
                this.Invoke((MethodInvoker)delegate() { txtConsole.AppendText(cameraName + " create! \n"); });

                this.Invoke((MethodInvoker)delegate() { txtConsole.AppendText("Finished BackUP! " + now.ToString() + "\n"); });
            }
            catch (IOException ex)
            { }

            k = 1;

            this.Invoke((MethodInvoker)delegate() { txtConsole.ScrollToCaret(); });

            Thread.Sleep(1000 * 65);
            flag = true;
        }

        private void btnConnectCam_Click(object sender, EventArgs e)
        {
            if (VideoSource.IsRunning)
            {
                VideoSource.Stop();
                pictureBox1.Image = null;
                pictureBox1.Invalidate();
            }
            else
            {
                VideoSource = new VideoCaptureDevice(VideoDevices[cbbCamName.SelectedIndex].MonikerString);
                VideoSource.NewFrame += videoSource_NewFrame;
                VideoSource.Start();
                txtStatus.Text = @"Connected Cam";
            }
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                try
                {
                    string cameraName = txtCamName.Text;
                    Directory.CreateDirectory(@"D:\" + cameraName);
                }
                catch (Exception ex)
                { }

                int t = int.Parse(cbbTimeInterval.Text);
                timer1.Interval = (t * 1000);
                timer1.Start();
            }
            else
            {
                timer1.Stop();
                timer2.Stop();
            }
        }
    }
}