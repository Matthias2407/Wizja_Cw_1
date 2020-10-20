using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.Structure;

namespace Wizja_Cw_1
{
    public partial class CW1 : Form
    {

        Image<Bgr, byte> obraz_PB1, obraz_PB2, wykres_PB1, wykres_PB2;

        VideoCapture kamera;

        public CW1()
        {
            InitializeComponent();
            obraz_PB1 = new Image<Bgr, byte>(pictureBox1.Size);
            obraz_PB2 = new Image<Bgr, byte>(pictureBox2.Size);
            wykres_PB1 = new Image<Bgr, byte>(graphBox1.Size);
            wykres_PB2 = new Image<Bgr, byte>(graphBox2.Size);

            kamera = new VideoCapture();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = e as MouseEventArgs;

            textBox_X.Text = me.X.ToString();
            textBox_Y.Text = me.Y.ToString();

            byte[,,] dane;
            dane = obraz_PB1.Data;

            textBox_R.Text = dane[me.Y, me.X, 2].ToString();
            textBox_G.Text = dane[me.Y, me.X, 1].ToString();
            textBox_B.Text = dane[me.Y, me.X, 0].ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = e as MouseEventArgs;

            textBox_X.Text = me.X.ToString();
            textBox_Y.Text = me.Y.ToString();

            byte[,,] dane;
            dane = obraz_PB2.Data;

            textBox_R.Text = dane[me.Y, me.X, 2].ToString();
            textBox_G.Text = dane[me.Y, me.X, 1].ToString();
            textBox_B.Text = dane[me.Y, me.X, 0].ToString();

        }

        private void graphBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_Camera1_Click(object sender, EventArgs e)
        {
            Mat temp = kamera.QueryFrame();
            CvInvoke.Resize(temp, temp, pictureBox1.Size);
            obraz_PB1 = temp.ToImage<Bgr, byte>();
            pictureBox1.Image = obraz_PB1.Bitmap;
        }

        private void button_Clear1_Click(object sender, EventArgs e)
        {
            obraz_PB1.SetZero();
            pictureBox1.Image = obraz_PB1.Bitmap;
        }

        private void button_Clear2_Click(object sender, EventArgs e)
        {
            obraz_PB2.SetZero();
            pictureBox2.Image = obraz_PB2.Bitmap; 
        }

        private void button_Graphic2_Click(object sender, EventArgs e)
        {
            CvInvoke.Circle(obraz_PB2, new Point(pictureBox2.Size.Width / 2, pictureBox2.Size.Height / 2), 30, new MCvScalar(255, 0, 255), 5);
            CvInvoke.Rectangle(obraz_PB2, new Rectangle(0, 0, 50, 50), new MCvScalar(255, 0, 255), 5);
            pictureBox2.Image = obraz_PB2.Bitmap;
        }

        private void button_fromFile2_Click(object sender, EventArgs e)
        {
            Mat temp = new Mat();
            temp = CvInvoke.Imread(@"C:\Users\Oskar\Desktop\kwatki.jpg");
            CvInvoke.Resize(temp, temp, pictureBox2.Size);
            obraz_PB2 = temp.ToImage<Bgr, byte>();
            pictureBox2.Image = obraz_PB2.Bitmap;
        }

        private void button_Camera2_Click(object sender, EventArgs e)
        {
            Mat temp = kamera.QueryFrame();
            CvInvoke.Resize(temp, temp, pictureBox1.Size);
            obraz_PB2 = temp.ToImage<Bgr, byte>();
            pictureBox2.Image = obraz_PB2.Bitmap;
        }

        private void button_pic1to2_Click(object sender, EventArgs e)
        {
            obraz_PB2.SetZero();
            CopyImage(obraz_PB1.Data, obraz_PB2.Data, obraz_PB2.Size);
            pictureBox2.Image = obraz_PB2.Bitmap;
        }

        private void graphBox2_Click(object sender, EventArgs e)
        {

        }

        private void button_pic2to1_Click(object sender, EventArgs e)
        {
            obraz_PB1.SetZero();
            CopyImage(obraz_PB2.Data, obraz_PB1.Data, obraz_PB1.Size);
            pictureBox1.Image = obraz_PB1.Bitmap;
        }

        private void button_toMono_Click(object sender, EventArgs e)
        {
            obraz_PB2.SetZero();
            CopyToMono(obraz_PB1.Data, obraz_PB2.Data, obraz_PB2.Size);
            pictureBox2.Image = obraz_PB2.Bitmap;
        }

        private void button_Graphic1_Click(object sender, EventArgs e)
        {
            CvInvoke.Circle(obraz_PB1, new Point(pictureBox1.Size.Width/2, pictureBox1.Size.Height/2), 30, new MCvScalar(255, 0, 255), 5);
            CvInvoke.Rectangle(obraz_PB1, new Rectangle(0, 0, 50, 50), new MCvScalar(255, 0, 255), 5);
            pictureBox1.Image = obraz_PB1.Bitmap;
        }

        private void button_doGraph1_Click(object sender, EventArgs e)
        {
            wykres_PB1.SetZero();
            drawGraph(obraz_PB1.Data, wykres_PB1.Data, graphBox1.Size, Convert.ToInt32(textBox_Y.Text));

            graphBox1.Image = wykres_PB1.Bitmap;
        }

        private void button_doGraph2_Click(object sender, EventArgs e)
        {
            wykres_PB2.SetZero();
            drawGraph(obraz_PB2.Data, wykres_PB2.Data, graphBox2.Size, Convert.ToInt32(textBox_Y.Text));

            graphBox2.Image = wykres_PB2.Bitmap;
        }

        private void drawGraph(byte[,,] src, byte[,,] dst, Size size, int y)
        {
            for(int x = 0;x < size.Width; x++)
            {
                dst[wykresScale(src[y, x, 2], size), x, 2] = 255;
                dst[wykresScale(src[y, x, 1], size), x, 1] = 255;
                dst[wykresScale(src[y, x, 0], size), x, 0] = 255;
            }
        }

        private int wykresScale(byte val, Size s)
        {
            return (int)((s.Height-1)*(1-(val/255.0)));
        }



        private void button_fromFile1_Click(object sender, EventArgs e)
        {
            Mat temp = new Mat();
            temp = CvInvoke.Imread(@"C:\Users\Admin\Downloads\pobrane.jpg");
            CvInvoke.Resize(temp, temp, pictureBox1.Size);
            obraz_PB1 = temp.ToImage<Bgr, byte>();
            pictureBox1.Image = obraz_PB1.Bitmap;
        }

        private void CopyToMono(byte[,,] src, byte[,,] dst, Size size)
        {
            for (int x = 0; x < size.Width; x++)
            {
                for (int y = 0; y < size.Height; y++)
                {

                    byte avg = (byte)((src[y, x, 2] + src[y, x, 1] + src[y, x, 0])/ 3);
                    dst[y, x, 2] = avg;
                    dst[y, x, 1] = avg;
                    dst[y, x, 0] = avg;
                }
            }
        }

        private void CopyImage(byte[,,] src,byte[,,] dst, Size size)
        {
            byte[] filtr = new byte[3];

            filtr[2] = (byte)((checkBox_R.Checked) ? 0xff : 0x00);
            filtr[1] = (byte)((checkBox_G.Checked) ? 0xff : 0x00);
            filtr[0] = (byte)((checkBox_B.Checked) ? 0xff : 0x00);

            for (int x = 0;x<size.Width; x++)
            {
                for(int y = 0; y < size.Height; y++)
                {
                    dst[y, x, 2] = (byte)(src[y, x, 2] & filtr[2]);
                    dst[y, x, 1] = (byte)(src[y, x, 1] & filtr[1]);
                    dst[y, x, 0] = (byte)(src[y, x, 0] & filtr[0]);
                }
            }

        }

    }
}
