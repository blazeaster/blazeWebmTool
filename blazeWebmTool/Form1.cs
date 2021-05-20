using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Javi.FFmpeg;
using Vlc.DotNet.Forms;


namespace blazeWebmTool
{

    public partial class Form1 : Form
    {

        string defaulFFMPG = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\ffmpeg\\ffmpeg.exe";
        string ffmpegPath;
        string sourcePath;
        string destinationPath
        string includeAudio;
        string webmRes;
        string vidLength;

        public int a = 0;
        public int c = 0;
        public delegate void UpdateControlsDelegate(); //Execute when video loads

        private void currentTrackTime()
        {
            int b = (int)vlcControl1.VlcMediaPlayer.Time / 1000;
            mediaTrack.Value = b;
            int d = b / 60;
            b = b - d * 60;
            timeLbl.Text = d + ":" + b + "/" + c + ":" + a; //min : sec / 
            
        }

        public void SetStartTime()
        {
            int seconds = (int)vlcControl1.Time / 1000;
            int minutes = seconds / 60;
            seconds = seconds - minutes * 60;
            int minuteLen = minutes.ToString().Length;
            int secondLen = seconds.ToString().Length;

            Debug.WriteLine(minutes);

            if (minutes == 0)
            {
                //00:00:00.000
                if (secondLen == 1)
                {
                    startTime.Text = "00:00:0" + seconds + ".000";
                }
                else if (secondLen == 2)
                {
                    startTime.Text = "00:00:" + seconds + ".000";
                }
            }
            else if (minutes > 0)
            {
                if (minuteLen == 1 && secondLen == 1)
                {
                    startTime.Text = "00:0" + minutes + ":0" + seconds + ".000";
                }
                else if (minuteLen == 2 & secondLen == 2)
                {
                    startTime.Text = "00:" + minutes + ":" + seconds + ".000";

                }
                else if (minuteLen == 1 & secondLen == 2)
                {

                    startTime.Text = "00:0" + minutes + ":" + seconds + ".000";

                }
                else if (minuteLen == 2 & secondLen == 1)
                {
                    startTime.Text = "00:" + minutes + ":0" + seconds + ".000";
                }
            }
        }

        public void SetEndTime()
        {
            int seconds = (int)vlcControl1.Time / 1000;
            int minutes = seconds / 60;
            seconds = seconds - minutes * 60;
            int minuteLen = minutes.ToString().Length;
            int secondLen = seconds.ToString().Length;

            Debug.WriteLine(minutes);

            if (minutes == 0)
            {
                //00:00:00.000
                if (secondLen == 1)
                {
                    endTime.Text = "00:00:0" + seconds + ".000";
                }
                else if (secondLen == 2)
                {
                    endTime.Text = "00:00:" + seconds + ".000";
                }
            }
            else if (minutes > 0)
            {
                if (minuteLen == 1 && secondLen == 1)
                {
                    endTime.Text = "00:0" + minutes + ":0" + seconds + ".000";
                }
                else if (minuteLen == 2 & secondLen == 2)
                {
                    endTime.Text = "00:" + minutes + ":" + seconds + ".000";

                }
                else if (minuteLen == 1 & secondLen == 2)
                {

                    endTime.Text = "00:0" + minutes + ":" + seconds + ".000";

                }
                else if (minuteLen == 2 & secondLen == 1)
                {
                    endTime.Text = "00:" + minutes + ":0" + seconds + ".000";
                }
            }
        }

        public void InvokeUpdateControls()
        {
            if (this.InvokeRequired)


            {
                this.Invoke(new UpdateControlsDelegate(currentTrackTime));
            }
            else
            {
                currentTrackTime();
            }

        }

        private void SetProgresMax(object sender, Vlc.DotNet.Core.VlcMediaPlayerPlayingEventArgs e)
        {
            Invoke(new Action(() =>
            {
                mediaTrack.Value = mediaTrack.Minimum;
                var vlc = (VlcControl)sender;
                mediaTrack.Maximum = (int)vlc.Length / 1000;
                a = (int)vlc.Length / 1000; // Length (s)
                c = a / 60; // Length (m)
                a = a % 60; // Length (s)
                timeLbl.Text = 0 + "/" + c + ":" + a;

            }));
        }


        public Form1()
        {
            InitializeComponent();

            this.vlcControl1.PositionChanged += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerPositionChangedEventArgs>(this.vlcControl1_PositionChanged);
            //Event handler for setting trackBar1.Maximum on media load
            vlcControl1.Playing += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerPlayingEventArgs>(SetProgresMax);


        }

        private void loadSource_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            sourcePath = openFileDialog1.FileName.ToString();
            sourceLbl.Text = sourcePath;

        }

        private void renderBtn_Click(object sender, EventArgs e)
        {

            if (rendWhole.Checked)
            {
                vidLength = " ";
            }
            else if (rendWhole.Checked == false)
            {
                vidLength = " -ss " + startTime.Text + " -to " + endTime.Text;
            }

            try
            {
                int x;
                bool isNumeric = int.TryParse(resolution.Text, out x);
                if (isNumeric == true)
                {
                    webmRes = resolution.Text;
                }
                else
                {
                    MessageBox.Show("Resolution value is not numeric. Defaulting to 640.");
                    webmRes = "640";
                }
            }
            catch (Exception h)
            {
                webmRes = "640";
            }


            if (audioCheck.Checked)
            {
                includeAudio = "";
            }
            else
            {
                includeAudio = "-an ";
            }

            using (var ffmpeg = new FFmpeg(defaulFFMPG))
            {
                string inputFile = sourcePath;

                if(destinationPath == "")
                {
                    destinationPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop).ToString() + @"\" + openFileDialog1.SafeFileName;
                }
                string outputFile = destinationPath;
                string commandLine = "-i \"" + sourcePath + "\"" + vidLength +
                                     " -c:v libvpx -crf " + qualityBar.Value.ToString() + " -b:v 1500K -vf scale=" +
                                     webmRes + ":-1 " + includeAudio + "\"" + destinationPath + "\"";

                Debug.WriteLine(commandLine);


                ffmpeg.Run(inputFile, outputFile, commandLine);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            sourceLbl.Text = "";

            a = (int)vlcControl1.Length / 1000;
            mediaTrack.Maximum = a;
            c = a / 60;
            a = a - c * 60;
            timeLbl.Text = 0 + "/" + c + ":" + a;
        }

        private void outputPath_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "WebM Files | *.webm";
            saveFileDialog1.Title = "SNEEEEEEEEEEEEEED";
            //saveFileDialog1.DefaultExt = ".webm";
            saveFileDialog1.ShowDialog();
            destinationPath = saveFileDialog1.FileName;
            outputBox.Text = destinationPath;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            vlcControl1.Play(new Uri(sourcePath));


        }


        private void vlcControl1_PositionChanged(object sender, Vlc.DotNet.Core.VlcMediaPlayerPositionChangedEventArgs e)
        {


            InvokeUpdateControls();


        }

        private void mediaTrack_Scroll(object sender, EventArgs e)
        {
            vlcControl1.Time = mediaTrack.Value * 1000;
            int b = (int)vlcControl1.Time / 1000;
            int d = b / 60;
            b = b - d * 60;
            timeLbl.Text = d + ":" + b + "/" + c + ":" + a;
        }

        private void pauseBtn_Click(object sender, EventArgs e)
        {
            vlcControl1.Pause();
        }

        private void startMark_Click(object sender, EventArgs e)
        {
            SetStartTime();
        }

        private void endMark_Click(object sender, EventArgs e)
        {
            SetEndTime();
        }
    }

}

