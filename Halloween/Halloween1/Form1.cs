using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Runtime.InteropServices;
using VideoPlayerController;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System.Drawing.Drawing2D;
using System.IO;
using System.Reflection;

namespace Halloween1
{
    public partial class Form1 : Form
    {

        public string projectPosition;

        public Form1()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1440, 1024);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            //string assemblyPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            //System.Drawing.Image img = System.Drawing.Image.FromFile(@"C:\Users\pkpk1\Desktop\CSS\Halloween1\images/main page 4.png");
            string workingDirectory = Environment.CurrentDirectory;
            // or: Directory.GetCurrentDirectory() gives the same result

            // This will get the current PROJECT bin directory (ie ../bin/)
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;

            // This will get the current PROJECT directory
            string targetDicextory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            projectPosition = targetDicextory;
            targetDicextory += @"//images//main page 4.png";

            //System.Drawing.Image img = System.Drawing.Image.FromFile(@"C:\Users\pkpk1\Desktop\CSS\Halloween1\images/main page 4.png");
            System.Drawing.Image img = System.Drawing.Image.FromFile(targetDicextory);
            //Bitmap b = new Bitmap(img);
            //System.Drawing.Image i = resizeImage(b, new Size(1440, 1024));

            //this.BackgroundImageLayout = ImageLayout.Center;
            this.BackgroundImage = img;

            //pictureBox1.Image = i;

        }

        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int record(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            record("open new Type waveaudio Alias recsound", "", 0, 0);
            record("record recsound", "", 0, 0);

            //float am = AudioManager.GetMasterVolume();
            //lbl01.Text = am.ToString();

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Enabled = false;
            record(@"save recsound C:\Users\pkpk1\Desktop\CSS\Halloween1\voice\accept.wav", "", 0, 0);
            record("close recsound", "", 0, 0);

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
                this.Hide();
                var form2 = new Form2();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            
        }

        private static System.Drawing.Image resizeImage(System.Drawing.Image imgToResize, Size size)
        {
            //Get the image current width  
            int sourceWidth = imgToResize.Width;
            //Get the image current height  
            int sourceHeight = imgToResize.Height;
            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;
            //Calulate  width with new desired size  
            nPercentW = ((float)size.Width / (float)sourceWidth);
            //Calculate height with new desired size  
            nPercentH = ((float)size.Height / (float)sourceHeight);
            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;
            //New Width  
            int destWidth = (int)(sourceWidth * nPercent);
            //New Height  
            int destHeight = (int)(sourceHeight * nPercent);
            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((System.Drawing.Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            // Draw image with new width and height  
            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();
            return (System.Drawing.Image)b;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            this.Hide();
            player.Stop();
            var form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"D:\C# demo\CSS\Halloween1\voice\trick or treat.wav");

        private void Form1_Load(object sender, EventArgs e)
        {
            player.Play();
        }
    }
}
