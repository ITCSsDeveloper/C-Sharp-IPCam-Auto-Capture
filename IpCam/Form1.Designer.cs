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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_time = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_cam = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.text_status = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textParthSave = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textQualitySave = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textQualityPreview = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textParthPreview = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.textBackup_h = new System.Windows.Forms.TextBox();
            this.textBackup_m = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textCamName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Connect Cam";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(248, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Record";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(248, 177);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 37);
            this.button3.TabIndex = 3;
            this.button3.Text = "Stop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            // combo_time
            // 
            this.combo_time.FormattingEnabled = true;
            this.combo_time.Location = new System.Drawing.Point(248, 107);
            this.combo_time.Name = "combo_time";
            this.combo_time.Size = new System.Drawing.Size(176, 21);
            this.combo_time.TabIndex = 5;
            this.combo_time.Text = "1";
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
            // combo_cam
            // 
            this.combo_cam.FormattingEnabled = true;
            this.combo_cam.Location = new System.Drawing.Point(248, 24);
            this.combo_cam.Name = "combo_cam";
            this.combo_cam.Size = new System.Drawing.Size(176, 21);
            this.combo_cam.TabIndex = 7;
            this.combo_cam.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cam Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 228);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(71, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_status
            // 
            this.text_status.Location = new System.Drawing.Point(236, 228);
            this.text_status.Name = "text_status";
            this.text_status.Size = new System.Drawing.Size(188, 20);
            this.text_status.TabIndex = 10;
            this.text_status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textParthSave
            // 
            this.textParthSave.Location = new System.Drawing.Point(97, 254);
            this.textParthSave.Name = "textParthSave";
            this.textParthSave.Size = new System.Drawing.Size(327, 20);
            this.textParthSave.TabIndex = 13;
            this.textParthSave.Text = "D:\\cam";
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
            // textQualitySave
            // 
            this.textQualitySave.Location = new System.Drawing.Point(441, 25);
            this.textQualitySave.Name = "textQualitySave";
            this.textQualitySave.Size = new System.Drawing.Size(127, 20);
            this.textQualitySave.TabIndex = 15;
            this.textQualitySave.Text = "60";
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
            // textQualityPreview
            // 
            this.textQualityPreview.Location = new System.Drawing.Point(441, 79);
            this.textQualityPreview.Name = "textQualityPreview";
            this.textQualityPreview.Size = new System.Drawing.Size(127, 20);
            this.textQualityPreview.TabIndex = 18;
            this.textQualityPreview.Text = "35";
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
            // textParthPreview
            // 
            this.textParthPreview.Location = new System.Drawing.Point(97, 280);
            this.textParthPreview.Name = "textParthPreview";
            this.textParthPreview.Size = new System.Drawing.Size(327, 20);
            this.textParthPreview.TabIndex = 19;
            this.textParthPreview.Text = "D:\\VM Share File\\ipcam\\cam.bmp";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // textBackup_h
            // 
            this.textBackup_h.Location = new System.Drawing.Point(441, 150);
            this.textBackup_h.Name = "textBackup_h";
            this.textBackup_h.Size = new System.Drawing.Size(47, 20);
            this.textBackup_h.TabIndex = 21;
            this.textBackup_h.Text = "23";
            // 
            // textBackup_m
            // 
            this.textBackup_m.Location = new System.Drawing.Point(505, 150);
            this.textBackup_m.Name = "textBackup_m";
            this.textBackup_m.Size = new System.Drawing.Size(47, 20);
            this.textBackup_m.TabIndex = 22;
            this.textBackup_m.Text = "55";
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
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(441, 177);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(218, 153);
            this.richTextBox1.TabIndex = 26;
            this.richTextBox1.Text = "";
            // 
            // textCamName
            // 
            this.textCamName.Location = new System.Drawing.Point(494, 106);
            this.textCamName.Name = "textCamName";
            this.textCamName.Size = new System.Drawing.Size(74, 20);
            this.textCamName.TabIndex = 27;
            this.textCamName.Text = "cam";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(438, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "CamName";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(669, 344);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textCamName);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBackup_m);
            this.Controls.Add(this.textBackup_h);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textParthPreview);
            this.Controls.Add(this.textQualityPreview);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textQualitySave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textParthSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_status);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combo_cam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combo_time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IPCam-Recorder";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_cam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox text_status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textParthSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textQualitySave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textQualityPreview;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textParthPreview;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox textBackup_h;
        private System.Windows.Forms.TextBox textBackup_m;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textCamName;
        private System.Windows.Forms.Label label13;
    }
}

