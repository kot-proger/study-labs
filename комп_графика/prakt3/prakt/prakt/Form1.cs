using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prakt
{
    public partial class Form1 : Form
    {
        Pen pen = new Pen(Color.Black, 1);
        float step_x, step_y;
        double[,] figure = {
                { -1, 1, 1 },
                { 3, 3, 1 },
                { -3, 3, 1 },
                { -3, -4, 1 }
            };
        public Form1()
        {
            InitializeComponent();
            canvas.Paint += PictureBox_Paint;
        }
        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            Refresh();
            float Ox = canvas.Width / 2, Oy = canvas.Height / 2;
            step_x = Ox / 15;
            step_y = Oy / 15;


            //рисуем оси;
            e.Graphics.TranslateTransform(Ox, Oy);
            DrawAxises(e.Graphics, Ox, Oy);

            //рисуем фигуру
            DrawFigure(e.Graphics);

        }


        public void DrawAxises(Graphics e, float ox, float oy)
        {
            pen = new Pen(Color.Black, 1);
            e.DrawLine(pen, 0, -oy, 0, oy);
            e.DrawLine(pen, -ox, 0, ox, 0);

            for (float x = 0; x < ox; x +=step_x) 
            {
                e.DrawLine(pen, x, 10, x, -10);
                e.DrawLine(pen, -x, 10, -x, -10);
            }

            for (float y = 0; y < oy; y += step_y)
            {
                e.DrawLine(pen, -10, y, 10, y);
                e.DrawLine(pen, -10, -y, 10, -y);
            }

            e.DrawLine(pen, 0, -oy, 15, -oy + step_y);
            e.DrawLine(pen, -15, -oy + step_y, 0, -oy);

            e.DrawLine(pen, ox, 0, ox - step_x, 15);
            e.DrawLine(pen, ox, 0, ox - step_x, -15);
        }

        private void Move_Click(object sender, EventArgs e)
        {
            double[,] move = { 
                { 1, 0, 0 }, 
                { 0, 1, 0 }, 
                { int.Parse(x_move.Text)* step_x, int.Parse(y_move.Text)* step_y, 1 } 
            };
            figure = Multiply(figure, move);
        }

        private void reset_Click(object sender, EventArgs e)
        {
            figure = new double[,] { 
                { -1 * step_x, 1 * step_y, 1 }, 
                { 3 * step_x, 3 * step_y, 1 }, 
                { -3 * step_x, 3 * step_y, 1 }, 
                { -3 * step_x, -4 * step_y, 1 } 
            };
        }

        public void DrawFigure(Graphics e)
        {
            pen = new Pen(Color.Red, 3);
            e.DrawLine(pen, Convert.ToInt32(figure[0,0]) , Convert.ToInt32(-figure[0,1]) , Convert.ToInt32(figure[1,0]) , Convert.ToInt32(-figure[1,1]) );
            e.DrawLine(pen, Convert.ToInt32(figure[1,0]) , Convert.ToInt32(-figure[1,1]) , Convert.ToInt32(figure[2,0]) , Convert.ToInt32(-figure[2,1]) );
            e.DrawLine(pen, Convert.ToInt32(figure[2,0]) , Convert.ToInt32(-figure[2,1]) , Convert.ToInt32(figure[3,0]) , Convert.ToInt32(-figure[3,1]) );
            e.DrawLine(pen, Convert.ToInt32(figure[3,0]) , Convert.ToInt32(-figure[3,1]) , Convert.ToInt32(figure[0,0]) , Convert.ToInt32(-figure[0,1]) );
        }

        private void Rotate_Click(object sender, EventArgs e)
        {
            double angle = double.Parse(rotate_angle.Text);
            double[,] rotate = {
                {Math.Cos(d: Math.PI / 180 * -angle), Math.Sin(Math.PI / 180 * -angle), 0},
                {-Math.Sin(Math.PI / 180 * -angle), Math.Cos(Math.PI / 180 * -angle), 0},
                { 0, 0, 1}
            };

            figure = Multiply(figure, rotate);
        }

        private void Mirror_X_Click(object sender, EventArgs e)
        {
            double[,] mirror = {
                {-1, 0, 0 },
                {0, 1, 1 },
                {0, 0, 1 }
            };
            figure = Multiply(figure, mirror);
        }

        private void Mirror_Y_Click(object sender, EventArgs e)
        {
            double[,] mirror = {
                {1, 0, 0 },
                {0, -1, 1 },
                {0, 0, 1 }
            };
            figure = Multiply(figure, mirror);
        }

        private void Scale_Click(object sender, EventArgs e)
        {
            double[,] scale = { 
                {double.Parse(scale_x_box.Text), 0, 0 },
                {0, double.Parse(scale_y_box.Text), 0 },
                {0, 0, 1 }
            };
            figure = Multiply(figure, scale);
        }

        public double[,] Multiply(double[,] A, double[,] B)
        {
            double[,] C = new double[A.GetLength(0), B.GetLength(1)];
            for (int i = 0; i < C.GetLength(0); i++)
            {
                int z = 0;
                for (int k = 0; k < C.GetLength(1); k++)
                {
                    double sum = 0;
                    for (int j = 0; j < C.GetLength(1); j++)
                    {
                        sum += A[i, j] * B[j, k];
                    }
                    C[i, z] = sum;
                    z++;
                }

            }
            return C;
        }
    }    
}
