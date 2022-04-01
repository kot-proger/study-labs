using System;
using System.Windows.Forms;
using Tao.OpenGl;

namespace prog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            canvas.InitializeContexts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Gl.glViewport(0, 0, canvas.Width, canvas.Height);
            Gl.glClearColor(1f, 1f, 1f, 1);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);

            canvas.Invalidate();

        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {

        }

        public float[,] A = new float[8, 4]
        {
            {0f, 0.4f, 0, 1 },
            {-0.2f, 0.26f, 0, 1},
            {-0.3f, 0, 0, 1 },
            {-0.2f, -0.26f, 0, 1},
            {0f, -0.4f, 0, 1 },
            {0.2f, -0.26f, 0, 1},
            {0.3f, 0, 0, 1 },
            {0.2f, 0.26f, 0, 1},
        };

        public float[,] B = new float[9, 4]
        {
            {-0.1f, 0.25f, 0, 1},
            {-0.1f, 0.16f, 0, 1},
            {-0.1f, -0.16f, 0, 1},
            {-0.1f, -0.25f, 0, 1},

            {0.1f, -0.16f, 0, 1},
            {0.3f, -0.07f, 0, 1},
            {0.1f, 0f, 0, 1},
            {0.3f, 0.07f, 0, 1},
            {0.1f, 0.16f, 0, 1},
        };

        public float
            sA = 1,
            sB = 1,
            aA = 0,
            aB = 0,
            xA = 0,
            yA = 0,
            xB = 0,
            yB = 0,
            aaA = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void canvas_keydown(object sender, KeyEventArgs e)
        {
            
            if(set_fig.SelectedIndex == 0)
            {
                //Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                if (e.KeyCode == Keys.W)
                {
                    Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                    yA += 0.05f;
                    draw_figure();
                }
                if(e.KeyCode == Keys.A)
                {
                    Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                    xA -= 0.05f;
                    draw_figure();
                }
                if (e.KeyCode == Keys.S)
                {
                    Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                    yA -= 0.05f;
                    draw_figure();
                }
                if (e.KeyCode == Keys.D)
                {
                    Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                    xA += 0.05f;
                    draw_figure();
                }
                if (e.KeyCode == Keys.Q)
                {
                    Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                    sA += 0.1f;
                    draw_figure();
                }
                if (e.KeyCode == Keys.E)
                {
                    Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                    sA -= 0.1f;
                    draw_figure();
                }
                if (e.KeyCode == Keys.R)
                {
                    Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                    aA += 1;
                    draw_figure();
                }
                if (e.KeyCode == Keys.F)
                {
                    Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                    aA -= 1;
                    draw_figure();
                }
                if (e.KeyCode == Keys.Z)
                {
                    Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                    aaA += 1;
                    draw_figure();
                }
                if (e.KeyCode == Keys.X)
                {
                    Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                    aaA -= 1;
                    draw_figure();
                }
                if (e.KeyCode == Keys.V)
                {
                    aaA = 0;
                    while (aaA <= 360)
                    {
                        aaA += 10;
                        draw_figure();
                    }
                }
            }

            if (set_fig.SelectedIndex == 1)
            {
                Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                if (e.KeyCode == Keys.W)
                {
                    yB += 0.05f;
                    draw_figure();
                }
                if (e.KeyCode == Keys.A)
                {
                    xB -= 0.05f;
                    draw_figure();
                }
                if (e.KeyCode == Keys.S)
                {
                    yB -= 0.05f;
                    draw_figure();
                }
                if (e.KeyCode == Keys.D)
                {
                    xB += 0.05f;
                    draw_figure();
                }
                if (e.KeyCode == Keys.Q)
                {
                    sB += 0.1f;
                    draw_figure();
                }
                if (e.KeyCode == Keys.E)
                {
                    sB -= 0.1f;
                    draw_figure();
                }
                if (e.KeyCode == Keys.R)
                {
                    aB += 1;
                    draw_figure();
                }
                if (e.KeyCode == Keys.F)
                {
                    aB -= 1;
                    draw_figure();
                }
            }
        }

        private void draw_figure()
        {
            Gl.glViewport(0, 0, canvas.Width, canvas.Height);
            Gl.glClearColor(1f, 1f, 1f, 1);

            //фигура A
            Gl.glPushMatrix();
            Gl.glColor4f(1f, 0f, 1f, 0);
            Gl.glLineWidth(2);

            Gl.glTranslatef(-0.6f, 0f, 0);
            Gl.glTranslatef(xA, yA, 0);
            Gl.glRotatef(aA, 0, 0, 1);

            Gl.glTranslatef((B[1, 0] + B[8, 0]) / 2 + 0.6f, (B[0, 1] + B[3, 1]) / 2, 0);
            Gl.glRotatef(aaA, 0, 0, 1);
            Gl.glTranslatef(-((B[1, 0] + B[8, 0]) / 2 + 0.6f), -(B[0, 1] + B[3, 1]) / 2, 0);

            Gl.glScalef(sA, sA, 0);

            Gl.glBegin(Gl.GL_LINE_LOOP);
                Gl.glVertex2f(A[0, 0], A[0, 1]);
                Gl.glVertex2f(A[1, 0], A[1, 1]);
                Gl.glVertex2f(A[2, 0], A[2, 1]);
                Gl.glVertex2f(A[3, 0], A[3, 1]);
                Gl.glVertex2f(A[4, 0], A[4, 1]);
                Gl.glVertex2f(A[5, 0], A[5, 1]);
                Gl.glVertex2f(A[6, 0], A[6, 1]);
                Gl.glVertex2f(A[7, 0], A[7, 1]);
            Gl.glEnd();

            Gl.glPointSize(6f);
            Gl.glEnable(Gl.GL_POINT_SMOOTH);
            Gl.glBegin(Gl.GL_POINTS);
                Gl.glVertex2f(A[0, 0], A[0, 1]);
                Gl.glVertex2f(A[1, 0], A[1, 1]);
                Gl.glVertex2f(A[2, 0], A[2, 1]);
                Gl.glVertex2f(A[3, 0], A[3, 1]);
                Gl.glVertex2f(A[4, 0], A[4, 1]);
                Gl.glVertex2f(A[5, 0], A[5, 1]);
                Gl.glVertex2f(A[6, 0], A[6, 1]);
                Gl.glVertex2f(A[7, 0], A[7, 1]);
            Gl.glEnd();

            Gl.glColor3f(0, 1, 0);
            Gl.glBegin(Gl.GL_LINE_LOOP);
                Gl.glVertex2f(A[0, 0], A[0, 1]);
                Gl.glVertex2f(A[2, 0], A[2, 1]);
                Gl.glVertex2f(A[4, 0], A[4, 1]);
                Gl.glVertex2f(A[6, 0], A[6, 1]);
            Gl.glEnd();

            Gl.glColor3f(0, 0, 0);
            Gl.glLineWidth(1);
            Gl.glBegin(Gl.GL_LINES);
                Gl.glVertex2f(A[0, 0], A[0, 1]);
                Gl.glVertex2f(A[4, 0], A[4, 1]);
                Gl.glVertex2f(A[2, 0], A[2, 1]);
                Gl.glVertex2f(A[6, 0], A[6, 1]);
            Gl.glEnd();

            Gl.glColor3f(0, 0, 0);
            Gl.glBegin(Gl.GL_POINTS);
                Gl.glVertex2f((A[3, 0] + A[7, 0]) / 2, (A[0, 1] + A[4, 1]) / 2);
            Gl.glEnd();

            Gl.glPopMatrix();

            //фигура B
            Gl.glLineWidth(2);
            Gl.glPushMatrix();

            Gl.glTranslatef(xB, yB, 0);
            Gl.glRotatef(aB, 0, 0, 1);
            Gl.glScalef(sB, sB, 0);

            Gl.glBegin(Gl.GL_LINE_LOOP);
                Gl.glVertex2f(B[1, 0], B[1, 1]);
                Gl.glVertex2f(B[2, 0], B[2, 1]);
                Gl.glVertex2f(B[4, 0], B[4, 1]);
                Gl.glVertex2f(B[8, 0], B[8, 1]);
            Gl.glEnd();

            Gl.glBegin(Gl.GL_LINE_LOOP);
                Gl.glVertex2f(B[0, 0], B[0, 1]);
                Gl.glVertex2f(B[3, 0], B[3, 1]);
                Gl.glVertex2f(B[5, 0], B[5, 1]);
                Gl.glVertex2f(B[6, 0], B[6, 1]);
                Gl.glVertex2f(B[7, 0], B[7, 1]);
            Gl.glEnd();

            Gl.glColor3f(0, 0, 0);
            Gl.glBegin(Gl.GL_POINTS);
                Gl.glVertex2f(B[0, 0], B[0, 1]);
                Gl.glVertex2f(B[3, 0], B[3, 1]);
                Gl.glVertex2f(B[4, 0], B[4, 1]);
                Gl.glVertex2f(B[8, 0], B[8, 1]);
            Gl.glEnd();

            Gl.glPopMatrix();

            canvas.Invalidate();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sA = 1;
            sB = 1;
            aA = 0;
            aB = 0;
            xA = 0;
            yA = 0;
            xB = 0;
            yB = 0;
            aaA = 0;
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            draw_figure();
        }
    }
}
