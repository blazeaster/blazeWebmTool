using System.IO;

namespace blazeWebmTool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loadSource = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.renderBtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.outputPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sourceLbl = new System.Windows.Forms.Label();
            this.qualityBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.resolution = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.startTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.endTime = new System.Windows.Forms.TextBox();
            this.audioCheck = new System.Windows.Forms.CheckBox();
            this.rendWhole = new System.Windows.Forms.CheckBox();
            this.vlcControl1 = new Vlc.DotNet.Forms.VlcControl();
            this.mediaTrack = new System.Windows.Forms.TrackBar();
            this.timeLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.startMark = new System.Windows.Forms.Button();
            this.endMark = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qualityBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // loadSource
            // 
            this.loadSource.Location = new System.Drawing.Point(12, 12);
            this.loadSource.Name = "loadSource";
            this.loadSource.Size = new System.Drawing.Size(183, 52);
            this.loadSource.TabIndex = 0;
            this.loadSource.Text = "Load Source Video";
            this.loadSource.UseVisualStyleBackColor = true;
            this.loadSource.Click += new System.EventHandler(this.loadSource_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // renderBtn
            // 
            this.renderBtn.Location = new System.Drawing.Point(570, 432);
            this.renderBtn.Name = "renderBtn";
            this.renderBtn.Size = new System.Drawing.Size(183, 52);
            this.renderBtn.TabIndex = 1;
            this.renderBtn.Text = "Render";
            this.renderBtn.UseVisualStyleBackColor = true;
            this.renderBtn.Click += new System.EventHandler(this.renderBtn_Click);
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(140, 455);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(369, 23);
            this.outputBox.TabIndex = 2;
            // 
            // outputPath
            // 
            this.outputPath.Location = new System.Drawing.Point(12, 447);
            this.outputPath.Name = "outputPath";
            this.outputPath.Size = new System.Drawing.Size(122, 37);
            this.outputPath.TabIndex = 3;
            this.outputPath.Text = "Output Path";
            this.outputPath.UseVisualStyleBackColor = true;
            this.outputPath.Click += new System.EventHandler(this.outputPath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Video will be rendered on your desktop by default";
            // 
            // sourceLbl
            // 
            this.sourceLbl.AutoSize = true;
            this.sourceLbl.Location = new System.Drawing.Point(12, 67);
            this.sourceLbl.Name = "sourceLbl";
            this.sourceLbl.Size = new System.Drawing.Size(22, 15);
            this.sourceLbl.TabIndex = 5;
            this.sourceLbl.Text = "---";
            // 
            // qualityBar
            // 
            this.qualityBar.Location = new System.Drawing.Point(99, 396);
            this.qualityBar.Maximum = 63;
            this.qualityBar.Minimum = 4;
            this.qualityBar.Name = "qualityBar";
            this.qualityBar.Size = new System.Drawing.Size(124, 45);
            this.qualityBar.TabIndex = 6;
            this.qualityBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.qualityBar.Value = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quality:";
            // 
            // resolution
            // 
            this.resolution.Location = new System.Drawing.Point(99, 311);
            this.resolution.Name = "resolution";
            this.resolution.Size = new System.Drawing.Size(145, 23);
            this.resolution.TabIndex = 8;
            this.resolution.Text = "640";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Resolution";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Start position:";
            // 
            // startTime
            // 
            this.startTime.Location = new System.Drawing.Point(99, 253);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(145, 23);
            this.startTime.TabIndex = 10;
            this.startTime.Text = "00:00:00.000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "End position:";
            // 
            // endTime
            // 
            this.endTime.Location = new System.Drawing.Point(99, 282);
            this.endTime.Name = "endTime";
            this.endTime.Size = new System.Drawing.Size(145, 23);
            this.endTime.TabIndex = 12;
            this.endTime.Text = "00:00:00.000";
            // 
            // audioCheck
            // 
            this.audioCheck.AutoSize = true;
            this.audioCheck.Location = new System.Drawing.Point(13, 356);
            this.audioCheck.Name = "audioCheck";
            this.audioCheck.Size = new System.Drawing.Size(98, 19);
            this.audioCheck.TabIndex = 14;
            this.audioCheck.Text = "Include audio";
            this.audioCheck.UseVisualStyleBackColor = true;
            this.audioCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // rendWhole
            // 
            this.rendWhole.AutoSize = true;
            this.rendWhole.Location = new System.Drawing.Point(125, 356);
            this.rendWhole.Name = "rendWhole";
            this.rendWhole.Size = new System.Drawing.Size(119, 19);
            this.rendWhole.TabIndex = 15;
            this.rendWhole.Text = "Encode whole vid";
            this.rendWhole.UseVisualStyleBackColor = true;
            // 
            // vlcControl1
            // 
            this.vlcControl1.BackColor = System.Drawing.Color.Black;
            this.vlcControl1.Location = new System.Drawing.Point(263, 15);
            this.vlcControl1.Name = "vlcControl1";
            this.vlcControl1.Size = new System.Drawing.Size(489, 290);
            this.vlcControl1.Spu = -1;
            this.vlcControl1.TabIndex = 16;
            this.vlcControl1.Text = "vlcControl1";
            this.vlcControl1.VlcMediaplayerOptions = null;
            // 
            // mediaTrack
            // 
            this.mediaTrack.AutoSize = false;
            this.mediaTrack.LargeChange = 1;
            this.mediaTrack.Location = new System.Drawing.Point(263, 311);
            this.mediaTrack.Maximum = 100;
            this.mediaTrack.Name = "mediaTrack";
            this.mediaTrack.Size = new System.Drawing.Size(489, 45);
            this.mediaTrack.TabIndex = 17;
            this.mediaTrack.TickStyle = System.Windows.Forms.TickStyle.None;
            this.mediaTrack.Scroll += new System.EventHandler(this.mediaTrack_Scroll);
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Location = new System.Drawing.Point(720, 341);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(32, 15);
            this.timeLbl.TabIndex = 18;
            this.timeLbl.Text = "--/--";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 39);
            this.button1.TabIndex = 19;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pauseBtn
            // 
            this.pauseBtn.Location = new System.Drawing.Point(329, 345);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(60, 39);
            this.pauseBtn.TabIndex = 20;
            this.pauseBtn.Text = "Pause";
            this.pauseBtn.UseVisualStyleBackColor = true;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // startMark
            // 
            this.startMark.Location = new System.Drawing.Point(405, 345);
            this.startMark.Name = "startMark";
            this.startMark.Size = new System.Drawing.Size(60, 39);
            this.startMark.TabIndex = 21;
            this.startMark.Text = "Start  time";
            this.startMark.UseVisualStyleBackColor = true;
            this.startMark.Click += new System.EventHandler(this.startMark_Click);
            // 
            // endMark
            // 
            this.endMark.Location = new System.Drawing.Point(471, 345);
            this.endMark.Name = "endMark";
            this.endMark.Size = new System.Drawing.Size(60, 39);
            this.endMark.TabIndex = 22;
            this.endMark.Text = "End time";
            this.endMark.UseVisualStyleBackColor = true;
            this.endMark.Click += new System.EventHandler(this.endMark_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 496);
            this.Controls.Add(this.endMark);
            this.Controls.Add(this.startMark);
            this.Controls.Add(this.pauseBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.timeLbl);
            this.Controls.Add(this.mediaTrack);
            this.Controls.Add(this.vlcControl1);
            this.Controls.Add(this.rendWhole);
            this.Controls.Add(this.audioCheck);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.endTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resolution);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.qualityBar);
            this.Controls.Add(this.sourceLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputPath);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.renderBtn);
            this.Controls.Add(this.loadSource);
            this.Name = "Form1";
            this.Text = "Include audio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qualityBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadSource;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button renderBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Button outputPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sourceLbl;
        private System.Windows.Forms.TrackBar qualityBar;
        private System.Windows.Forms.Label label2;
        //private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox startTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox endTime;
        private System.Windows.Forms.CheckBox audioCheck;
        private System.Windows.Forms.TextBox resolution;
        private System.Windows.Forms.CheckBox rendWhole;
        public Vlc.DotNet.Forms.VlcControl vlcControl1;
        private System.Windows.Forms.TrackBar mediaTrack;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.Button startMark;
        private System.Windows.Forms.Button endMark;
    }
}

