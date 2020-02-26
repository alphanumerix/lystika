using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace lystikaServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = n11url.Text;

            baslik.Text = n11Klon.klonBaslik(url);
            altBaslik.Text = n11Klon.klonAltBaslik(url);
           fiyat.Text = n11Klon.klonFiyat(url);
            richTextBox1.Text = (HttpUtility.HtmlEncode(n11Klon.klonAciklama(url)));

            string[] images = ("\"" + n11Klon.klonResim(url)).Split('\"');
int i = 0;
            foreach (var item in images)
            {
                i++;
                int kacresim = images.Length;

                if (kacresim<=0)
                {
                    pb0.ImageLocation = images[0];
                }

                if (kacresim <= 1)
                {
                    pb0.ImageLocation = images[0];
                    pb1.ImageLocation = images[1];
                }

                if (kacresim <= 2)
                {
                    pb0.ImageLocation = images[0];
                    pb1.ImageLocation = images[1];
                    pb2.ImageLocation = images[2];

                }

                if (kacresim <= 3)
                {
                    pb0.ImageLocation = images[0];
                    pb1.ImageLocation = images[1];
                    pb2.ImageLocation = images[2];
                    pb3.ImageLocation = images[3];


                }
               
                if (kacresim <= 4)
                {
                    pb0.ImageLocation = images[0];
                    pb1.ImageLocation = images[1];
                    pb2.ImageLocation = images[2];
                    pb3.ImageLocation = images[3];
                    pb4.ImageLocation = images[4];



                }
                if (kacresim <= 5)
                {
                    pb0.ImageLocation = images[0];
                    pb1.ImageLocation = images[1];
                    pb2.ImageLocation = images[2];
                    pb3.ImageLocation = images[3];
                    pb4.ImageLocation = images[4];
                    pb5.ImageLocation = images[5];




                }

            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
         
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
