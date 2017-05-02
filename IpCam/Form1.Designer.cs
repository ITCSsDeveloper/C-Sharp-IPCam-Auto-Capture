namespace IpCam
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConnectCam = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTimeInterval = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbCamName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFrame = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtParthSave = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtParthPreview = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtConsole = new System.Windows.Forms.RichTextBox();
            this.txtCamName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textQualitySave = new System.Windows.Forms.NumericUpDown();
            this.txtQualityPreview = new System.Windows.Forms.NumericUpDown();
            this.bgMoveImage = new System.ComponentModel.BackgroundWorker();
            this.bgSaveImage = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtHours = new System.Windows.Forms.NumericUpDown();
            this.txtMinute = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textQualitySave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQualityPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinute)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnConnectCam
            // 
            this.btnConnectCam.Location = new System.Drawing.Point(248, 51);
            this.btnConnectCam.Name = "btnConnectCam";
            this.btnConnectCam.Size = new System.Drawing.Size(176, 37);
            this.btnConnectCam.TabIndex = 1;
            this.btnConnectCam.Text = "Connect Cam";
            this.btnConnectCam.UseVisualStyleBackColor = true;
            this.btnConnectCam.Click += new System.EventHandler(this.btnConnectCam_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Enabled = false;
            this.btnRecord.Location = new System.Drawing.Point(248, 134);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(176, 37);
            this.btnRecord.TabIndex = 2;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(248, 177);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(176, 37);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "IPCam-Recorder:  1-3 ITCS\'s Developer";
            // 
            // cbbTimeInterval
            // 
            this.cbbTimeInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimeInterval.Enabled = false;
            this.cbbTimeInterval.FormattingEnabled = true;
            this.cbbTimeInterval.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbbTimeInterval.Location = new System.Drawing.Point(248, 107);
            this.cbbTimeInterval.Name = "cbbTimeInterval";
            this.cbbTimeInterval.Size = new System.Drawing.Size(176, 21);
            this.cbbTimeInterval.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "seconds";
            // 
            // cbbCamName
            // 
            this.cbbCamName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCamName.FormattingEnabled = true;
            this.cbbCamName.Location = new System.Drawing.Point(248, 24);
            this.cbbCamName.Name = "cbbCamName";
            this.cbbCamName.Size = new System.Drawing.Size(176, 21);
            this.cbbCamName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Camera List";
            // 
            // txtFrame
            // 
            this.txtFrame.Enabled = false;
            this.txtFrame.Location = new System.Drawing.Point(97, 228);
            this.txtFrame.Name = "txtFrame";
            this.txtFrame.Size = new System.Drawing.Size(71, 20);
            this.txtFrame.TabIndex = 9;
            this.txtFrame.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(236, 228);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(188, 20);
            this.txtStatus.TabIndex = 10;
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Frames@";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Status";
            // 
            // txtParthSave
            // 
            this.txtParthSave.Enabled = false;
            this.txtParthSave.Location = new System.Drawing.Point(97, 254);
            this.txtParthSave.Name = "txtParthSave";
            this.txtParthSave.Size = new System.Drawing.Size(327, 20);
            this.txtParthSave.TabIndex = 13;
            this.txtParthSave.Text = "D:\\cam";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Parth Save : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(441, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Quality to save";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(441, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Quality to preveiw";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Parth Preview : ";
            // 
            // txtParthPreview
            // 
            this.txtParthPreview.Enabled = false;
            this.txtParthPreview.Location = new System.Drawing.Point(97, 280);
            this.txtParthPreview.Name = "txtParthPreview";
            this.txtParthPreview.Size = new System.Drawing.Size(327, 20);
            this.txtParthPreview.TabIndex = 19;
            this.txtParthPreview.Text = "D:\\VM Share File\\ipcam\\cam.bmp";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(438, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Backup time";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(491, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "h";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(553, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "m";
            // 
            // txtConsole
            // 
            this.txtConsole.Location = new System.Drawing.Point(441, 177);
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.Size = new System.Drawing.Size(218, 153);
            this.txtConsole.TabIndex = 26;
            this.txtConsole.Text = "";
            // 
            // txtCamName
            // 
            this.txtCamName.Enabled = false;
            this.txtCamName.Location = new System.Drawing.Point(502, 106);
            this.txtCamName.Name = "txtCamName";
            this.txtCamName.Size = new System.Drawing.Size(74, 20);
            this.txtCamName.TabIndex = 27;
            this.txtCamName.Text = "cam";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(438, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Can Folder";
            // 
            // textQualitySave
            // 
            this.textQualitySave.Enabled = false;
            this.textQualitySave.Location = new System.Drawing.Point(441, 25);
            this.textQualitySave.Name = "textQualitySave";
            this.textQualitySave.Size = new System.Drawing.Size(135, 20);
            this.textQualitySave.TabIndex = 29;
            this.textQualitySave.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // txtQualityPreview
            // 
            this.txtQualityPreview.Enabled = false;
            this.txtQualityPreview.Location = new System.Drawing.Point(441, 79);
            this.txtQualityPreview.Name = "txtQualityPreview";
            this.txtQualityPreview.Size = new System.Drawing.Size(135, 20);
            this.txtQualityPreview.TabIndex = 30;
            this.txtQualityPreview.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // bgMoveImage
            // 
            this.bgMoveImage.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgMoveImage_DoWork);
            // 
            // bgSaveImage
            // 
            this.bgSaveImage.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgSaveImage_DoWork);
            // 
            // txtHours
            // 
            this.txtHours.Enabled = false;
            this.txtHours.Location = new System.Drawing.Point(445, 152);
            this.txtHours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(40, 20);
            this.txtHours.TabIndex = 31;
            this.txtHours.Value = new decimal(new int[] {
            23,
            0,
            0,
            0});
            // 
            // txtMinute
            // 
            this.txtMinute.Enabled = false;
            this.txtMinute.Location = new System.Drawing.Point(510, 151);
            this.txtMinute.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.Size = new System.Drawing.Size(40, 20);
            this.txtMinute.TabIndex = 32;
            this.txtMinute.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(669, 344);
            this.Controls.Add(this.txtMinute);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.txtQualityPreview);
            this.Controls.Add(this.textQualitySave);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtCamName);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtParthPreview);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtParthSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtFrame);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbCamName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbTimeInterval);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.btnConnectCam);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IPCam-Recorder";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textQualitySave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQualityPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConnectCam;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbTimeInterval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbCamName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFrame;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtParthSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtParthPreview;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox txtConsole;
        private System.Windows.Forms.TextBox txtCamName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown textQualitySave;
        private System.Windows.Forms.NumericUpDown txtQualityPreview;
        private System.ComponentModel.BackgroundWorker bgMoveImage;
        private System.ComponentModel.BackgroundWorker bgSaveImage;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NumericUpDown txtHours;
        private System.Windows.Forms.NumericUpDown txtMinute;
    }
}

