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
        float[,] cube =
{
            {1f, 1.7f, 1f},
            {-1f, 1.7f, 1f},
            {-1f, 1.7f, -1f},
            {1f, 1.7f, -1f},

            {1f, -0.5f, 1f},
            {-1f, -0.5f, 1f},
            {-1f, -0.5f, -1f},
            {1f, -0.5f, -1f}
        };

        float[,] pyramid =
        {
            {0, -0.3f, -1f},
            {1f, -0.3f, -0.3f},
            {1f, -0.3f, 0.3f},
            {0, -0.3f, 1f},
            {-1f, -0.3f, 0.3f},
            {-1f, -0.3f, -0.3f},

            {0, 1.5f, 0}
        };

        float yAngle = 0;

        private void stripToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DrawFigure();
        }

        private void canvas_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.R)
            {
                timer2.Enabled = !timer2.Enabled;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            yAngle = (yAngle + 5) % 360;
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

            Gl.glRotatef(yAngle, 0, 1, 0);

            //крышка куба
            Gl.glColor3f(0.6f, 1, 0);
            Gl.glBegin(Gl.GL_LINE_LOOP);
                for (int i = 0; i < 4; i++)
                {
                    Gl.glVertex3f(cube[i, 0], cube[i, 1], cube[i, 2]);
                }
            Gl.glEnd();
            
            // дно куба
            Gl.glBegin(Gl.GL_LINE_LOOP);
                for (int i = 4; i < 8; i++)
                {
                    Gl.glVertex3f(cube[i, 0], cube[i, 1], cube[i, 2]);
                }
            Gl.glEnd();

            // боковые рёбра куба
            for (int i = 0; i < 4; i++)
            {
                Gl.glBegin(Gl.GL_LINE_STRIP);
                    Gl.glVertex3f(cube[i, 0], cube[i, 1], cube[i, 2]);
                    Gl.glVertex3f(cube[i+4, 0], cube[i+4, 1], cube[i+4, 2]);
                Gl.glEnd();
            }

            //дно пирамиды
            Gl.glColor3f(0.6f, 0.1f, 0.5f);
            Gl.glBegin(Gl.GL_POLYGON);
                for (int i = 0; i < 6; i++)
                {
                    Gl.glVertex3f(pyramid[i, 0], pyramid[i, 1], pyramid[i, 2]);
                }
            Gl.glEnd();


            //бока пирамиды
            double r = 0.6, g = 0.1, b = 0.5; 

            Gl.glBegin(Gl.GL_TRIANGLES);
                Gl.glColor3d(r, g, b);
                Gl.glVertex3f(pyramid[0, 0], pyramid[0, 1], pyramid[0, 2]);
                Gl.glVertex3f(pyramid[1, 0], pyramid[1, 1], pyramid[1, 2]);
                Gl.glVertex3f(pyramid[6, 0], pyramid[6, 1], pyramid[6, 2]);
            Gl.glEnd();

            r = 0.3;
            g = 0.6; 
            b = 0;
            Gl.glBegin(Gl.GL_TRIANGLES);
                Gl.glColor3d(r, g, b);
                Gl.glVertex3f(pyramid[2, 0], pyramid[2, 1], pyramid[2, 2]);
                Gl.glVertex3f(pyramid[1, 0], pyramid[1, 1], pyramid[1, 2]);
                Gl.glVertex3f(pyramid[6, 0], pyramid[6, 1], pyramid[6, 2]);
            Gl.glEnd();

            r = 0.8;
            g = 0.1;
            b = 0.5;
            Gl.glBegin(Gl.GL_TRIANGLES);
                Gl.glColor3d(r, g, b);
                Gl.glVertex3f(pyramid[2, 0], pyramid[2, 1], pyramid[2, 2]);
                Gl.glVertex3f(pyramid[3, 0], pyramid[3, 1], pyramid[3, 2]);
                Gl.glVertex3f(pyramid[6, 0], pyramid[6, 1], pyramid[6, 2]);
            Gl.glEnd();


            r = 0.2;
            g = 0.7;
            b = 0.9;
            Gl.glBegin(Gl.GL_TRIANGLES);
                Gl.glColor3d(r, g, b);
                Gl.glVertex3f(pyramid[3, 0], pyramid[3, 1], pyramid[3, 2]);
                Gl.glVertex3f(pyramid[4, 0], pyramid[4, 1], pyramid[4, 2]);
                Gl.glVertex3f(pyramid[6, 0], pyramid[6, 1], pyramid[6, 2]);
            Gl.glEnd();

            r = 0.4;
            g = 0.5;
            b = 0.6;
            Gl.glBegin(Gl.GL_TRIANGLES);
                Gl.glColor3d(r, g, b);
                Gl.glVertex3f(pyramid[4, 0], pyramid[4, 1], pyramid[4, 2]);
                Gl.glVertex3f(pyramid[5, 0], pyramid[5, 1], pyramid[5, 2]);
                Gl.glVertex3f(pyramid[6, 0], pyramid[6, 1], pyramid[6, 2]);
            Gl.glEnd();

            r = 0.5;
            g = 0.3;
            b = 0.2;
            Gl.glBegin(Gl.GL_TRIANGLES);
                Gl.glColor3d(r, g, b);
                Gl.glVertex3f(pyramid[0, 0], pyramid[0, 1], pyramid[0, 2]);
                Gl.glVertex3f(pyramid[5, 0], pyramid[5, 1], pyramid[5, 2]);
                Gl.glVertex3f(pyramid[6, 0], pyramid[6, 1], pyramid[6, 2]);
            Gl.glEnd();


            Gl.glPopMatrix();

            canvas.Invalidate();
        }
    }
}
