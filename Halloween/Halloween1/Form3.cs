using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Halloween1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        // 1000 325
        // 40 325

        

        private void Form3_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(1440, 1024);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            Imgload();

            pictureBox11.Location = new Point(1200,100);
            pictureBox11.BackColor = Color.Black;
            pictureBox12.Location = new Point(50, 100);
            pictureBox12.BackColor = Color.Black;

            pictureBox13.BackColor=Color.Transparent;
            pictureBox14.BackColor = Color.Transparent;
            pictureBox15.BackColor = Color.Transparent;
            pictureBox16.BackColor = Color.Transparent;
            pictureBox17.BackColor = Color.Transparent;

        }


        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
        
        public void Imgload() 
        {
            Image img1 = Image.FromFile(@"C:\Users\pkpk1\Desktop\CSS\Halloween1\images\bread.png");

            Bitmap bmp1 = ResizeImage(img1, 90, 90);

            pictureBox1.Image = bmp1;

            Image img2 = Image.FromFile(@"C:\Users\pkpk1\Desktop\CSS\Halloween1\images\Cactus.png");

            Bitmap bmp2 = ResizeImage(img2, 90, 90);

            pictureBox2.Image = bmp2;

            Image img3 = Image.FromFile(@"C:\Users\pkpk1\Desktop\CSS\Halloween1\images\cat.png");

            Bitmap bmp3 = ResizeImage(img3, 90, 90);

            pictureBox3.Image = bmp3;

            Image img4 = Image.FromFile(@"C:\Users\pkpk1\Desktop\CSS\Halloween1\images\durian.png");

            Bitmap bmp4 = ResizeImage(img4, 90, 90);

            pictureBox4.Image = bmp4;

            Image img5 = Image.FromFile(@"C:\Users\pkpk1\Desktop\CSS\Halloween1\images\elephant.png");

            Bitmap bmp5 = ResizeImage(img5, 90, 90);

            pictureBox5.Image = bmp5;

            Image img6 = Image.FromFile(@"C:\Users\pkpk1\Desktop\CSS\Halloween1\images\Picachu.png");

            Bitmap bmp6 = ResizeImage(img6, 90, 90);

            pictureBox6.Image = bmp6;

            Image img7 = Image.FromFile(@"C:\Users\pkpk1\Desktop\CSS\Halloween1\images\Pumpkin head.png");

            Bitmap bmp7 = ResizeImage(img7, 90, 90);

            pictureBox7.Image = bmp7;

            Image img8 = Image.FromFile(@"C:\Users\pkpk1\Desktop\CSS\Halloween1\images\skunk.png");

            Bitmap bmp8 = ResizeImage(img8, 90, 90);

            pictureBox8.Image = bmp8;

            Image img9 = Image.FromFile(@"C:\Users\pkpk1\Desktop\CSS\Halloween1\images\sugar cane.png");

            Bitmap bmp9 = ResizeImage(img9, 90, 90);

            pictureBox9.Image = bmp9;

            Image img10 = Image.FromFile(@"C:\Users\pkpk1\Desktop\CSS\Halloween1\images\watermelon.png");

            Bitmap bmp10 = ResizeImage(img10, 90, 90);

            pictureBox10.Image = bmp10;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Image img1 = Image.FromFile(@"C:\Users\pkpk1\Desktop\CSS\Halloween1\images\bread.png");
            Bitmap bmp1 = ResizeImage(img1, 90, 90);

            if (pictureBox13.Image == null) 
            {
                pictureBox13.Image = bmp1;

            }else if(pictureBox14.Image == null) 
            {
                pictureBox14.Image = bmp1;
            }
            else if (pictureBox15.Image == null) 
            {
                pictureBox15.Image = bmp1;
            }
            else if (pictureBox16.Image == null) 
            {
                pictureBox16.Image = bmp1;
            }
            else if (pictureBox17.Image == null) 
            {
                pictureBox17.Image = bmp1;
            }
            else 
            {
                
            }
        }

        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Image img2 = Image.FromFile(@"C:\Users\pkpk1\Desktop\CSS\Halloween1\images\Cactus.png");

            Bitmap bmp2 = ResizeImage(img2, 90, 90);

            if (pictureBox13.Image == null)
            {
                pictureBox13.Image = bmp2;
            }
            else if (pictureBox14.Image == null)
            {
                pictureBox14.Image = bmp2;
            }
            else if (pictureBox15.Image == null)
            {
                pictureBox15.Image = bmp2;
            }
            else if (pictureBox16.Image == null)
            {
                pictureBox16.Image = bmp2;
            }
            else if (pictureBox17.Image == null)
            {
                pictureBox17.Image = bmp2;
            }
            else
            {

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox13.Image == null)
            {
                pictureBox13.Image = pictureBox3.Image;
            }
            else if (pictureBox14.Image == null)
            {
                pictureBox14.Image = pictureBox3.Image;
            }
            else if (pictureBox15.Image == null)
            {
                pictureBox15.Image = pictureBox3.Image;
            }
            else if (pictureBox16.Image == null)
            {
                pictureBox16.Image = pictureBox3.Image;
            }
            else if (pictureBox17.Image == null)
            {
                pictureBox17.Image = pictureBox3.Image;
            }
            else
            {

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox13.Image == null)
            {
                pictureBox13.Image = pictureBox4.Image;
                pictureBox13.Location = new Point(70, 325);
            }
            else if (pictureBox14.Image == null)
            {
                pictureBox14.Image = pictureBox4.Image;
                pictureBox14.Location = new Point(70, 325);
            }
            else if (pictureBox15.Image == null)
            {
                pictureBox15.Image = pictureBox4.Image;
                pictureBox15.Location = new Point(70, 325);
            }
            else if (pictureBox16.Image == null)
            {
                pictureBox16.Image = pictureBox4.Image;
                pictureBox16.Location = new Point(70, 325);
            }
            else if (pictureBox17.Image == null)
            {
                pictureBox17.Image = pictureBox4.Image;
                pictureBox17.Location = new Point(70, 325);
            }
            else
            {

            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox13.Image == null)
            {
                pictureBox13.Image = pictureBox5.Image;
                pictureBox13.Location = new Point(70, 325);
            }
            else if (pictureBox14.Image == null)
            {
                pictureBox14.Image = pictureBox5.Image;
                pictureBox14.Location = new Point(70, 325);
            }
            else if (pictureBox15.Image == null)
            {
                pictureBox15.Image = pictureBox5.Image;
                pictureBox15.Location = new Point(70, 325);
            }
            else if (pictureBox16.Image == null)
            {
                pictureBox16.Image = pictureBox5.Image;
                pictureBox16.Location = new Point(70, 325);
            }
            else if (pictureBox17.Image == null)
            {
                pictureBox17.Image = pictureBox5.Image;
                pictureBox17.Location = new Point(70, 325);
            }
            else
            {

            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (pictureBox13.Image == null)
            {
                pictureBox13.Image = pictureBox6.Image;
                pictureBox13.Location = new Point(70, 325);
            }
            else if (pictureBox14.Image == null)
            {
                pictureBox14.Image = pictureBox6.Image;
                pictureBox14.Location = new Point(70, 325);
            }
            else if (pictureBox15.Image == null)
            {
                pictureBox15.Image = pictureBox6.Image;
                pictureBox15.Location = new Point(70, 325);
            }
            else if (pictureBox16.Image == null)
            {
                pictureBox16.Image = pictureBox6.Image;
                pictureBox16.Location = new Point(70, 325);
            }
            else if (pictureBox17.Image == null)
            {
                pictureBox17.Image = pictureBox6.Image;
                pictureBox17.Location = new Point(70, 325);
            }
            else
            {

            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (pictureBox13.Image == null)
            {
                pictureBox13.Image = pictureBox7.Image;
                pictureBox13.Location = new Point(70, 325);
            }
            else if (pictureBox14.Image == null)
            {
                pictureBox14.Image = pictureBox7.Image;
                pictureBox14.Location = new Point(70, 325);
            }
            else if (pictureBox15.Image == null)
            {
                pictureBox15.Image = pictureBox7.Image;
                pictureBox15.Location = new Point(70, 325);
            }
            else if (pictureBox16.Image == null)
            {
                pictureBox16.Image = pictureBox7.Image;
                pictureBox16.Location = new Point(70, 325);
            }
            else if (pictureBox17.Image == null)
            {
                pictureBox17.Image = pictureBox7.Image;
                pictureBox17.Location = new Point(70, 325);
            }
            else
            {

            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (pictureBox13.Image == null)
            {
                pictureBox13.Image = pictureBox8.Image;
                pictureBox13.Location = new Point(70, 325);
            }
            else if (pictureBox14.Image == null)
            {
                pictureBox14.Image = pictureBox8.Image;
                pictureBox14.Location = new Point(70, 325);
            }
            else if (pictureBox15.Image == null)
            {
                pictureBox15.Image = pictureBox8.Image;
                pictureBox15.Location = new Point(70, 325);
            }
            else if (pictureBox16.Image == null)
            {
                pictureBox16.Image = pictureBox8.Image;
                pictureBox16.Location = new Point(70, 325);
            }
            else if (pictureBox17.Image == null)
            {
                pictureBox17.Image = pictureBox8.Image;
                pictureBox17.Location = new Point(70, 325);
            }
            else
            {

            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (pictureBox13.Image == null)
            {
                pictureBox13.Image = pictureBox9.Image;
                pictureBox13.Location = new Point(70, 325);
            }
            else if (pictureBox14.Image == null)
            {
                pictureBox14.Image = pictureBox9.Image;
                pictureBox14.Location = new Point(70, 325);
            }
            else if (pictureBox15.Image == null)
            {
                pictureBox15.Image = pictureBox9.Image;
                pictureBox15.Location = new Point(70, 325);
            }
            else if (pictureBox16.Image == null)
            {
                pictureBox16.Image = pictureBox9.Image;
                pictureBox16.Location = new Point(70, 325);
            }
            else if (pictureBox17.Image == null)
            {
                pictureBox17.Image = pictureBox9.Image;
                pictureBox17.Location = new Point(70, 325);
            }
            else
            {

            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (pictureBox13.Image == null)
            {
                pictureBox13.Image = pictureBox10.Image;
                pictureBox13.Location = new Point(70, 325);
            }
            else if (pictureBox14.Image == null)
            {
                pictureBox14.Image = pictureBox10.Image;
                pictureBox14.Location = new Point(70, 325);
            }
            else if (pictureBox15.Image == null)
            {
                pictureBox15.Image = pictureBox10.Image;
                pictureBox15.Location = new Point(70, 325);
            }
            else if (pictureBox16.Image == null)
            {
                pictureBox16.Image = pictureBox10.Image;
                pictureBox16.Location = new Point(70, 325);
            }
            else if (pictureBox17.Image == null)
            {
                pictureBox17.Image = pictureBox10.Image;
                pictureBox17.Location = new Point(70, 325);
            }
            else
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;

            //pictureBox13 = new PictureBox();
            //pictureBox14 = new PictureBox();
            //pictureBox15 = new PictureBox();
            //pictureBox16 = new PictureBox();
            //pictureBox17 = new PictureBox();

            pictureBox13.Show();
            pictureBox14.Show();
            pictureBox15.Show();
            pictureBox16.Show();
            pictureBox17.Show();

            pictureBox13.Image = null;
            pictureBox14.Image = null;
            pictureBox15.Image = null;
            pictureBox16.Image = null;
            pictureBox17.Image = null;

            button1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rd = new Random();

            if (pictureBox13.Image != null)
            {
                int ex_x=pictureBox17.Location.X;
                int x = pictureBox13.Location.X;
                
                    int xp = rd.Next(1, 6);
                    pictureBox13.Location = new Point(x + xp, 300);
                
            }

            if (pictureBox14.Image != null)
            {
                int ex_x = pictureBox13.Location.X;
                int x = pictureBox14.Location.X;
                if ((ex_x - x) > 100)
                {
                    int xp = rd.Next(1, 6);
                    pictureBox14.Location = new Point(x + xp, 300);
                }
            }

            if (pictureBox15.Image != null)
            {
                int ex_x = pictureBox14.Location.X;
                int x = pictureBox15.Location.X;
                if ((ex_x - x) > 100)
                {
                    int xp = rd.Next(1, 6);
                    pictureBox15.Location = new Point(x + xp, 300);
                }
            }

            if (pictureBox16.Image != null)
            {
                int ex_x = pictureBox15.Location.X;
                int x = pictureBox16.Location.X;
                if ((ex_x - x) > 100)
                {
                    int xp = rd.Next(1, 6);
                    pictureBox16.Location = new Point(x + xp, 300);
                }
            }

            if (pictureBox17.Image != null)
            {
                int ex_x = pictureBox16.Location.X;
                int x = pictureBox17.Location.X;
                if ((ex_x - x) > 100)
                {
                    int xp = rd.Next(1, 6);
                    pictureBox17.Location = new Point(x + xp, 300);
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random rd = new Random();

            int x1 = pictureBox14.Location.X;

            if (pictureBox14.Image == null) 
            {
                string path =enemy();
                pictureBox14.Image = Image.FromFile(path);
            }
            else 
            {
                int xp = rd.Next(1, 6);
                pictureBox14.Location = new Point(x1 + xp, 300);

            }


            int x2 = pictureBox19.Location.X;

            if (pictureBox19.Image == null && (x2-x1)>150)
            {
                string path = enemy();
                pictureBox19.Image = Image.FromFile(path);
            }
            else
            {
                int xp = rd.Next(1, 6);
                pictureBox19.Location = new Point(x2 - xp, 300);

            }
        }

        public string enemy() 
        {
            string enemy;
            List<string> pool = new List<string>();
            pool.Add(@"C:\Users\pkpk1\Desktop\CSS\Halloween1\images\enemy\zombie.jpg");
            pool.Add(@"C:\Users\pkpk1\Desktop\CSS\Halloween1\images\enemy\witch.jpg");
            pool.Add(@"C:\Users\pkpk1\Desktop\CSS\Halloween1\images\enemy\Vimpire.png");
            pool.Add(@"C:\Users\pkpk1\Desktop\CSS\Halloween1\images\enemy\monster.jpg");
            pool.Add(@"C:\Users\pkpk1\Desktop\CSS\Halloween1\images\enemy\mammy.jpg");
            pool.Add(@"C:\Users\pkpk1\Desktop\CSS\Halloween1\images\enemy\ghost.jpg");
            pool.Add(@"C:\Users\pkpk1\Desktop\CSS\Halloween1\images\enemy\chzam.png");

            Random rd = new Random();
            int num = rd.Next(0, 6);
            enemy = pool[num];
            return enemy;
        }

    }
}   
