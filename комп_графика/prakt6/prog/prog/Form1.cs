using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.OpenGl;
using Tao.FreeGlut;
using Tao.Platform.Windows;

namespace prog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            canvas.InitializeContexts();
            Gl.glViewport(0, 0, canvas.Width, canvas.Height);
            Gl.glClearColor(1f, 1f, 1f, 1);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Gl.glFrustum(-1f, 1f, -1f, 1f, 3f, 10f);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            Gl.glTranslatef(0f, 0f, -8.0f);
            Gl.glRotatef(30, 1, 0, 0);
        }
        float[,] figure =
{
            {0.43f, 1.2f, 0},
            {-0.03f, 1.2f, 0},
            {0.2f, 1.2f, 0.6f},

            {0.645f, 0.6f, 0},
            {-0.045f, 0.6f, 0},
            { 0.3f, 0.6f, 0.9f}
        };

        float xAngle = 0, yAngle = 0, zAngle = 0;

        private void stripToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DrawFigure();
        }

        private void canvas_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Q)
            {
                xAngle += 5;
                DrawFigure();
            }
            if (e.KeyCode == Keys.A)
            {
                xAngle -= 5;
                DrawFigure();
            }
            if (e.KeyCode == Keys.W)
            {
                yAngle += 5;
                DrawFigure();
            }
            if (e.KeyCode == Keys.S)
            {
                yAngle -= 5;
                DrawFigure();
            }
            if (e.KeyCode == Keys.E)
            {
                zAngle += 5;
                DrawFigure();
            }
            if (e.KeyCode == Keys.D)
            {
                zAngle -= 5;
                DrawFigure();
            }
            if(e.KeyCode == Keys.R)
            {
                timer2.Enabled = !timer2.Enabled;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            xAngle = (xAngle + 5) % 360;
            yAngle = (xAngle + 5) % 360;
            DrawFigure();
        }

        private void polygonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        public void DrawFigure()
        {
            Gl.glClearColor(1f, 1f, 1f, 1);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glClear(Gl.GL_DEPTH_BUFFER_BIT);

            Gl.glPushMatrix();

            Gl.glRotatef(xAngle, 1, 0, 0);
            Gl.glRotatef(yAngle, 0, 1, 0);
            Gl.glRotatef(zAngle, 0, 0, 1);

            //крышка
            Gl.glColor3f(0.6f, 1, 0);
            Gl.glBegin(Gl.GL_TRIANGLES);
                for (int i = 0; i < 3; i++)
                {
                    Gl.glVertex3f(figure[i, 0], figure[i, 1], figure[i, 2]);
                }
            Gl.glEnd();

            //дно
            Gl.glColor3f(0.6f, 0, 0.6f);
            Gl.glBegin(Gl.GL_TRIANGLES);
                for (int i = 3; i < 6; i++)
                {
                    Gl.glVertex3f(figure[i, 0], figure[i, 1], figure[i, 2]);
                }
            Gl.glEnd();

            //бока
            Gl.glColor3f(1, 0.5f, 1);
            Gl.glBegin(Gl.GL_QUAD_STRIP);
                for (int i = 0; i < 3; i++)
                {
                    Gl.glVertex3f(figure[i, 0], figure[i, 1], figure[i, 2]);
                    Gl.glVertex3f(figure[i+3, 0], figure[i+3, 1], figure[i+3, 2]);

                }
                Gl.glVertex3f(figure[0, 0], figure[0, 1], figure[0, 2]);
                Gl.glVertex3f(figure[3, 0], figure[3, 1], figure[3, 2]);
            Gl.glEnd();

            Gl.glPopMatrix();

            canvas.Invalidate();
        }
    }
}
