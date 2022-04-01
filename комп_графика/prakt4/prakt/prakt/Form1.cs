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
        float step_x, step_y, step_z;
        double[,] figure = {
                { -1, 1, 2, 1 },
                { 3, 3, 2, 1 },
                { -3, 3, 2, 1 },
                { -3, -4, 2, 1 },
                { -1, 1, -2, 1 },
                { 3, 3, -2, 1 },
                { -3, 3, -2, 1 },
                { -3, -4, -2, 1 }
            };
        public Form1()
        {
            InitializeComponent();
            canvas.Paint += PictureBox_Paint;
        }
        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            //Refresh();
            float Ox = canvas.Width / 2, Oy = canvas.Height / 2;
            step_x = Ox / 15;
            step_y = Oy / 15;
            step_z = Convert.ToSingle(Math.Sqrt(step_x * step_x + step_y * step_y));


            //рисуем оси;
            e.Graphics.TranslateTransform(Ox, Oy);
            DrawAxises(e.Graphics, Ox, Oy);

            //рисуем фигуру
            DrawFigure(e.Graphics);

        }


        public void DrawAxises(Graphics e, float ox, float oy)
        {
            pen = new Pen(Color.Black, 1);
            e.DrawLine(pen, 0, -oy, 0, 0);
            e.DrawLine(pen, 0, 0, ox, 0);
            e.DrawLine(pen, 0, 0, -ox, oy);

            for (float x = 0; x < ox; x +=step_x) 
            {
                e.DrawLine(pen, x, 10, x, -10);
            }

            for (float y = 0; y < oy; y += step_y)
            {
                e.DrawLine(pen, -10, -y, 10, -y);
            }

            e.DrawLine(pen, 0, -oy, 15, -oy + step_y);
            e.DrawLine(pen, -15, -oy + step_y, 0, -oy);

            e.DrawLine(pen, ox, 0, ox - step_x, 15);
            e.DrawLine(pen, ox, 0, ox - step_x, -15);
        }

        private void reset_Click(object sender, EventArgs e)
        {
            canvas.Refresh();
            figure = new double [,]{
                { -1, 1, 2, 1 },
                { 3, 3, 2, 1 },
                { -3, 3, 2, 1 },
                { -3, -4, 2, 1 },
                { -1, 1, -2, 1 },
                { 3, 3, -2, 1 },
                { -3, 3, -2, 1 },
                { -3, -4, -2, 1 }
            };

            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0) figure[i, j] *= step_x;
                    if (j == 1) figure[i, j] *= step_y;
                    if (j == 2) figure[i, j] *= step_z;
                }
        }

        public void DrawFigure(Graphics e)
        {
            pen = new Pen(Color.Red, 3);
            //передняя стенка
            for(int i = 0; i< 3; i++)
                e.DrawLine(pen, Convert.ToInt32(figure[i,0]) , Convert.ToInt32(-figure[i,1]) , Convert.ToInt32(figure[i+1,0]) , Convert.ToInt32(-figure[i+1,1]) );
            e.DrawLine(pen, Convert.ToInt32(figure[0, 0]), Convert.ToInt32(-figure[0, 1]), Convert.ToInt32(figure[3, 0]), Convert.ToInt32(-figure[3, 1]));
            //задняя стенка 
            for (int i = 4; i < 7; i++)
                e.DrawLine(pen, Convert.ToInt32(figure[i, 0]), Convert.ToInt32(-figure[i, 1]), Convert.ToInt32(figure[i + 1, 0]), Convert.ToInt32(-figure[i + 1, 1]));
            e.DrawLine(pen, Convert.ToInt32(figure[4, 0]), Convert.ToInt32(-figure[4, 1]), Convert.ToInt32(figure[7, 0]), Convert.ToInt32(-figure[7, 1]));
            //соединение стенок
            for (int i = 0; i < 4; i++)
                e.DrawLine(pen, Convert.ToInt32(figure[i, 0]), Convert.ToInt32(-figure[i, 1]), Convert.ToInt32(figure[i + 4, 0]), Convert.ToInt32(-figure[i + 4, 1]));
        }

        private void Rotate_Click(object sender, EventArgs e)
        {
            canvas.Refresh();
            double angle = double.Parse(rotate_angle.Text);
            double[,] rotate = new double[4, 4];
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    if (i == j) rotate[i, j] = 1;
                    else rotate[i, j] = 0;

            rotate[1, 1] = Math.Cos(Math.PI / 180 * -angle);
            rotate[2, 2] = rotate[1, 1];
            rotate[1, 2] = Math.Sin(Math.PI / 180 * -angle);
            rotate[2, 1] = -rotate[1, 2];

            figure = Multiply(figure, rotate);
        }

        private void Mirror_X_Click(object sender, EventArgs e)
        {
            canvas.Refresh();
            double[,] mirror = new double[4, 4];
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    if (i == j) mirror[i, j] = 1;
                    else mirror[i, j] = 0;
            mirror[2, 2] = -1;
            figure = Multiply(figure, mirror);
        }

        private void Mirror_Y_Click(object sender, EventArgs e)
        {
            canvas.Refresh();
            double[,] mirror = new double[4, 4];
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    if (i == j) mirror[i, j] = 1;
                    else mirror[i, j] = 0;
            mirror[0, 0] = -1;
            figure = Multiply(figure, mirror);
        }

        private void Rotate_Y_Click(object sender, EventArgs e)
        {
            canvas.Refresh();
            double angle = double.Parse(rotate_angle.Text);
            double[,] rotate = new double[4, 4];
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    if (i == j) rotate[i, j] = 1;
                    else rotate[i, j] = 0;

            rotate[0, 0] = Math.Cos(Math.PI / 180 * -angle);
            rotate[2, 2] = rotate[0, 0];
            rotate[0, 2] = -Math.Sin(Math.PI / 180 * -angle);
            rotate[2, 0] = -rotate[0, 2];

            figure = Multiply(figure, rotate);
        }

        private void Rotate_Z_Click(object sender, EventArgs e)
        {
            canvas.Refresh();
            double angle = double.Parse(rotate_angle.Text);
            double[,] rotate = new double[4, 4];
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    if (i == j) rotate[i, j] = 1;
                    else rotate[i, j] = 0;

            rotate[0, 0] = Math.Cos(Math.PI / 180 * -angle);
            rotate[1, 1] = rotate[0, 0];
            rotate[0, 1] = Math.Sin(Math.PI / 180 * -angle);
            rotate[1, 0] = -rotate[0, 1];

            figure = Multiply(figure, rotate);
        }

        private void Mirror_Z_Click(object sender, EventArgs e)
        {
            canvas.Refresh();
            double[,] mirror = new double[4, 4];
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    if (i == j) mirror[i, j] = 1;
                    else mirror[i, j] = 0;
            mirror[2, 2] = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            canvas.Refresh();
            double[,] mirror = new double[4, 4];
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    if (i == j) mirror[i, j] = 1;
                    else mirror[i, j] = 0;
            mirror[0, 0] = -1;

            double[,] proect = new double[4, 4];
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    if (i == j) mirror[i, j] = 1;
                    else mirror[i, j] = 0;
            proect[0, 3] = 10 * step_x;

            double[,] transform = Multiply(mirror, proect);
            figure = Multiply(figure, transform);

            //figure = Multiply(figure, mirror);
            //figure = Multiply(figure, proect);

            for (int i = 0; i < 8; i++)
            {
                figure[i, 1] /= 10 * step_x * figure[i, 0] + step_y;
                figure[i, 2] /= 10 * step_x * figure[i, 0] + step_z;
            }
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
