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
            {0.7f, 0.7f, 0.3f},
            {-0.7f, 0.7f, 0.3f},
            {-0.7f, 0.7f, -0.3f},
            {0.7f, 0.7f, -0.3f},

            {0.7f, -0.1f, 0.3f},
            {-0.7f, -0.1f, 0.3f},
            {-0.7f, -0.1f, -0.3f},
            {0.7f, -0.1f, -0.3f}
        };


        float xAngle = 0, yAngle = 0, zAngle = 0;
        float[] light0_dif = { 0.7f, 0.2f, 0.2f };
        float[] light0_posX = { 1.0f, 0.0f, 0.0f, 0 };
        float[] light0_posY = { 0f, -1.0f, 0f, 0 };
        float[] light0_posZ = { 0.8f, 0.1f, 0.4f, 0 };
        float[] color_am = { 0.8f, 0.1f, 0.4f };

        private void stripToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawFigure();
        }

        private void canvas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
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
            if (e.KeyCode == Keys.R)
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
            Gl.glEnable(Gl.GL_LIGHTING);
            Gl.glEnable(Gl.GL_LIGHT0);
            Gl.glEnable(Gl.GL_NORMALIZE);
            Gl.glLightModelf(Gl.GL_LIGHT_MODEL_TWO_SIDE, Gl.GL_TRUE);
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_DIFFUSE, light0_dif);

            Gl.glPushMatrix();

            Gl.glRotatef(xAngle, 1, 0, 0);
            Gl.glRotatef(yAngle, 0, 1, 0);
            Gl.glRotatef(zAngle, 0, 0, 1);

            //крышка параллелограмма
            Gl.glColor3f(0, 1, 0);
            Gl.glBegin(Gl.GL_POLYGON);
                Gl.glNormal3f(0, 1f, 0);
                for (int i = 0; i < 4; i++)
                {
                    Gl.glVertex3f(cube[i, 0], cube[i, 1], cube[i, 2]);
                }
            Gl.glEnd();
            
            // дно параллелограмма
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glNormal3f(0, -1f, 0);
                for (int i = 4; i < 8; i++)
                {
                    Gl.glVertex3f(cube[i, 0], cube[i, 1], cube[i, 2]);
                }
            Gl.glEnd();

            // боковые рёбра параллелограмма

            Gl.glBegin(Gl.GL_POLYGON);
                Gl.glNormal3f(0, 0, 1f);
                Gl.glVertex3f(cube[0, 0], cube[0, 1], cube[0, 2]);
                Gl.glVertex3f(cube[1, 0], cube[1, 1], cube[1, 2]);
                Gl.glVertex3f(cube[5, 0], cube[5, 1], cube[5, 2]);
                Gl.glVertex3f(cube[4, 0], cube[4, 1], cube[4, 2]);
            Gl.glEnd();

            Gl.glBegin(Gl.GL_POLYGON);
                Gl.glNormal3f(-1f, 0, 0);
                Gl.glVertex3f(cube[1, 0], cube[1, 1], cube[1, 2]);
                Gl.glVertex3f(cube[2, 0], cube[2, 1], cube[2, 2]);
                Gl.glVertex3f(cube[6, 0], cube[6, 1], cube[6, 2]);
                Gl.glVertex3f(cube[5, 0], cube[5, 1], cube[5, 2]);
            Gl.glEnd();

            Gl.glBegin(Gl.GL_POLYGON);
                Gl.glNormal3f(0, 0, -1f);
                Gl.glVertex3f(cube[2, 0], cube[2, 1], cube[2, 2]);
                Gl.glVertex3f(cube[3, 0], cube[3, 1], cube[3, 2]);
                Gl.glVertex3f(cube[7, 0], cube[7, 1], cube[7, 2]);
                Gl.glVertex3f(cube[6, 0], cube[6, 1], cube[6, 2]);
            Gl.glEnd();

            Gl.glBegin(Gl.GL_POLYGON);
                Gl.glNormal3f(1f, 0, 0);
                Gl.glVertex3f(cube[3, 0], cube[3, 1], cube[3, 2]);
                Gl.glVertex3f(cube[0, 0], cube[0, 1], cube[0, 2]);
                Gl.glVertex3f(cube[4, 0], cube[4, 1], cube[4, 2]);
                Gl.glVertex3f(cube[7, 0], cube[7, 1], cube[7, 2]);
            Gl.glEnd();

            Gl.glPopMatrix();

            canvas.Invalidate();
        }

        private void ambientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gl.glMaterialfv(Gl.GL_FRONT_AND_BACK, Gl.GL_AMBIENT, color_am);
        }

        private void diffuseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gl.glMaterialfv(Gl.GL_FRONT_AND_BACK, Gl.GL_DIFFUSE, color_am);
        }

        private void specularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gl.glMaterialfv(Gl.GL_FRONT_AND_BACK, Gl.GL_SPECULAR, color_am);
        }

        private void emissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gl.glMaterialfv(Gl.GL_FRONT_AND_BACK, Gl.GL_EMISSION, color_am);
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_POSITION, light0_posX);
        }

        private void yToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_POSITION, light0_posY);
        }

        private void zToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_POSITION, light0_posZ);
        }
    }
}
