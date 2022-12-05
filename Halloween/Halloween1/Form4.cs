using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Halloween1
{
    public partial class Form4 : Form
    {
        
        int score4;
        public Form4(int scoer)
        {
            score4 = scoer;
            score4= scoer;
            InitializeComponent();
        }

        
         

        private void Form4_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(1440, 1024);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            System.Drawing.Image img = System.Drawing.Image.FromFile(@"C:\Users\pkpk1\Desktop\CSS\Halloween1\images/Result page.png");
            //Bitmap b = new Bitmap(img);
            this.BackgroundImage = img;

            label1.Location = new Point(780,630);
            label1.Text = score4.ToString();

            button1.Location = new Point(1280, 700);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            
            form1.Show();
        }
    }
}
