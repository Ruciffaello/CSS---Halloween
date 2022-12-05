using NAudio.CoreAudioApi;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Halloween1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        public int HP;
        public int score;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"D:\C# demo\CSS\Halloween1\voice\Podington Bear - Twombly.wav");


        private void Form2_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(1440, 1024);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            System.Drawing.Image img = System.Drawing.Image.FromFile(@"D:\C# demo\CSS\Halloween1\images/main page 5.png");
            Bitmap b = new Bitmap(img);
            this.BackgroundImage = img;


            MMDeviceEnumerator devEnum = new MMDeviceEnumerator();

            var device = devEnum.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active);
            comboBox1.Items.AddRange(device.ToArray());

            var waveIn = new WaveIn();
            waveIn.StartRecording();

            imageProduce();
            button1.Enabled = false;
            label1.Hide();

            button2.Location = new Point(1150,700);
            button3.Location = new Point(1280, 700);
            label2.Hide();
            label3.Hide();
            label4.Hide();

            player.Play();

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                var device = (MMDevice)comboBox1.SelectedItem;
                
                progressBar1.Value = (int)(Math.Round(device.AudioMeterInformation.MasterPeakValue * 100));

                if (timer3.Enabled==false )
                {
                    button1.Enabled = true;
                }
            }
        }

        public void imageProduce() 
        {
            Image img = Image.FromFile(@"D:\C# demo\CSS\Halloween1\images\image1.jpg");
            


        }


        public string wordProdcue() 
        {
            List<string> ls = new List<string>();
            ls.Add("I pay all the bills.Why can't you just do this for me ? ");
            ls.Add("You are too sensitive. ");
            ls.Add("If you really loved me, you’d do it ");
            ls.Add("If you can't stay with me tonight when I need you, maybe someone else will. ");
            ls.Add("If you don't let us live with you, we’ll be homeless. Think of your nephews! \n Who knows what will happen to them? Do you want to live with that? ");
            ls.Add("Can't you see how busy I am? Do you think I have time to hire an office manager? \n I expected better from you. ");
            ls.Add("If you don’t do what I want I will…leave you, tell your secrets, not love you… ");
            ls.Add("All I do is work for this family, the least you could do is… ");
            ls.Add("If you ever stop loving me I will kill myself ");
            ls.Add("I’m taking this vacation-with or without you. ");
            ls.Add("You've ruined my life and now you are trying to stop me \n from spending money to take care of myself ");
            ls.Add("It was your fault that I was late for work ");
            ls.Add("I would have gotten ahead in my career if you had done more at home ");
            ls.Add("If you don’t take care of me, I'll wind up in the hospital/on the street/unable to work ");
            ls.Add("I’ll make you suffer ");
            ls.Add("You’ll destroy this family ");
            ls.Add("You’re not my child anymore ");
            ls.Add("I’m cutting you out of my will ");
            ls.Add("You shall not pass ~!!!!!!!!!");

            Random rd = new Random();
            int num = rd.Next(0, 19);
            

            return ls[num];
        
        }

        
        //第一次初始化
        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;

            
            label1.Text = wordProdcue();
            label1.Show();
            int len = label1.Text.Length;
            HP = len * 100;
            score = 0;
            label1.Location = new Point(900,50);
            label1.BackColor = Color.FromArgb(206,80,232);
            label1.Font = new Font("Cambria", 12);
            button1.Enabled = false;

        }


        int timer2_count = 0;

        private void timer2_Tick(object sender, EventArgs e)
        {
            //更改label座標
            int x = label1.Location.X;
            int y = label1.Location.Y;
            label2.Text = x.ToString();
            label1.Location = new Point(x -10, y +5);
            float font_num = label1.Font.Size;

            timer2_count++;
            if (timer2_count % 2 == 0)
            {
                label1.Font = new Font("Cambria", font_num + 1);
            }

            if(font_num > 40) 
            {
                timer2.Enabled = false;
                timer3.Enabled = false;
                MessageBox.Show("Too Late");
            }


        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;

            MessageBox.Show("Well Done !!!");
            MessageBox.Show("Your score is "+score);
            //this.ParentForm.Refresh();
            button1.Enabled = true;
        }

        

        private void timer4_Tick(object sender, EventArgs e)
        {
            var device = (MMDevice)comboBox1.SelectedItem;

            int damage = (int)(Math.Round(device.AudioMeterInformation.MasterPeakValue * 100));

            label2.Text = damage.ToString();
            label3.Text = HP.ToString();
            label4.Text = score.ToString();
            if (HP > 0)
            {
                HP = HP - damage;
            }
            else 
            {
                //timer2.Enabled = false;
                //timer4.Enabled = false;
                //MessageBox.Show("Success");
                score += 30;
                initinalizeHP();
            }
        }


        private void initinalizeHP() 
        {
            //timer2.Enabled = true; //句子計時
            //timer4.Enabled = true; // 傷害計時

            label1.Text = wordProdcue();
            int len = label1.Text.Length;
            HP = len * 100;
            //x 範圍 200~900 y 範圍 30~70
            Random rx = new Random();
            int x = rx.Next(200,900);
            int y = rx.Next(30, 70);
            label1.Location = new Point(x, y);
            label1.BackColor = Color.FromArgb(206, 80, 232);
            label1.Font = new Font("Cambria", 12);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form4 = new Form4(score);
            //form4.score = score;
            form4.Closed += (s, args) => this.Close();
            player.Stop();
            form4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            player.Stop();
            form1.Show();
        }
    }
}
