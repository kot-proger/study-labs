using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mandelbrot_fractal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            for (int x = 0; x < pictureBox1.Width; x++)
            {
                for (int y = 0; y < pictureBox1.Height; y++)
                {
                    double a = (double)(x - (pictureBox1.Width / 2)) / (double)(pictureBox1.Width / 4);
                    double b = (double)(y - (pictureBox1.Height / 2)) / (double)(pictureBox1.Height / 4);

                    Complex c = new Complex(a, b);
                    Complex z = new Complex(0, 0);

                    int iter = 0;
                    do
                    {
                        // проверка на вхождение в заданные границы
                        if (!(z.a >= -2.0 && z.a <= 0.8 && z.b >= -1.0 && z.b <= 1.0))
                        {
                            break;
                        }
                        iter++;
                        z.Sqr();
                        z.Add(c);

                        // проверка выхода заграницы круга
                        if (z.Magn() > 2.0)
                        {
                            break;
                        }
                    } while (iter < 100);


                    // прорисовка пикселя
                    bmp.SetPixel(x, y, iter < 100 ? Color.FromArgb(iter*2, iter, iter*2) : Color.FromArgb(255, 255, 255));

                }
            }
            pictureBox1.Image = bmp;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Draw();
        }
    }
}
