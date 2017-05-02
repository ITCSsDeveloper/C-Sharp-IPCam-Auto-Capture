using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;
using System.IO;

namespace IpCam
{
    public partial class Form1 : Form
    {
        FilterInfoCollection videoDevices;
        VideoCaptureDevice videoSource;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            { combo_time.Items.Add(i); }

            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo device in videoDevices)
            {
                combo_cam.Items.Add(device.Name);
            }

            videoSource = new VideoCaptureDevice();
            combo_cam.SelectedIndex = 0;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                try
                {
                    string cameraName = textCamName.Text;
                    Directory.CreateDirectory(@"D:\" + cameraName);
                }
                catch (Exception ex)
                { }

                int t = int.Parse(combo_time.Text);
                timer1.Interval = (t * 1000);
                timer1.Start();
            }
            else
            {
                timer1.Stop();
                timer2.Stop();
            }
        }

        void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
                Thread.Sleep(100);
                pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (videoSource.IsRunning)
            {
                videoSource.Stop();
                pictureBox1.Image = null;
                pictureBox1.Invalidate();
            }
            else
            {
                videoSource = new VideoCaptureDevice(videoDevices[combo_cam.SelectedIndex].MonikerString);
                videoSource.NewFrame += videoSource_NewFrame;
                videoSource.Start();
                text_status.Text = "Connected Cam";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (videoSource.IsRunning)
            {
                timer1.Stop();
                videoSource.Stop();
                pictureBox1.Image = null;
                pictureBox1.Invalidate();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          //  this.Invoke((MethodInvoker)delegate() { richTextBox1.AppendText("time1 work \n"); });
            Thread TT = new Thread(capture);
            TT.Start();
        }

        Int64 k = 1;

        Int64 QualitySave = 60;
        Int64 QualityPreview = 35;

        private void capture()
        {
            try
            {
                if (pictureBox1.Image != null)
                {
                    string parth_save = textParthSave.Text + "\\" + k + ".bmp";
                    string parth_preview = textParthPreview.Text;

                    QualitySave = Int64.Parse(textQualitySave.Text);
                    QualityPreview = Int64.Parse(textQualityPreview.Text);

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
                        textBox1.Text = "" + k;
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
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }


        DateTime now = DateTime.Now;
        bool flag = true;

        private void timer2_Tick(object sender, EventArgs e)
        {
            now = DateTime.Now;
            if (flag == false) {
                return;
            }

            if (now.Hour.ToString() == textBackup_h.Text && now.Minute.ToString() == textBackup_m.Text)
            {
                Thread TT = new Thread(move_img);
                TT.Start();
            }
        }



        private void move_img()
        {
          //  this.Invoke((MethodInvoker)delegate() { richTextBox1.AppendText("move_img work \n"); });
            flag = false; // กัน timer2 เข้ามาทำ ขณะที่ทำงานอยู่
           

            string cameraName = textCamName.Text;

            try
            {
                string folder_name1 = now.Day.ToString() + "-" + now.Month.ToString() + "-" + now.Year.ToString() + "_" + cameraName;

                this.Invoke((MethodInvoker)delegate() { richTextBox1.AppendText("Start BackUP! " + now.ToString() + "\n"); });

                Directory.Move(@"D:\" + cameraName, @"D:\" + folder_name1);
                this.Invoke((MethodInvoker)delegate() { richTextBox1.AppendText(folder_name1 + " Coppy! \n"); });

                Directory.CreateDirectory(@"D:\" + cameraName);
                this.Invoke((MethodInvoker)delegate() { richTextBox1.AppendText(cameraName + " create! \n"); });

                this.Invoke((MethodInvoker)delegate() { richTextBox1.AppendText("Finished BackUP! " + now.ToString() + "\n"); });

            }
            catch (IOException ex)
            {  }
        
            k = 1;
           
            this.Invoke((MethodInvoker)delegate() { richTextBox1.ScrollToCaret(); });


            Thread.Sleep(1000 * 65);
            flag = true;
        }
    }
}