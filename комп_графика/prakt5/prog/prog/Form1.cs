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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DrawAxises();
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {

        }

        public void DrawAxises()
        {
            Gl.glViewport(0, 0, canvas.Width, canvas.Height);
            Gl.glClearColor(1f, 1f, 1f, 1);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);

            Gl.glLineWidth(3);
            Gl.glColor3f(0, 0, 0);

            Gl.glBegin(Gl.GL_LINES);//координатные линии
                Gl.glVertex2f(0, 1);
                Gl.glVertex2f(0, -1);
                Gl.glVertex2f(-1, 0);
                Gl.glVertex2f(1, 0);
            Gl.glEnd();

            Gl.glBegin(Gl.GL_LINE_STRIP);//стрелочка у
                Gl.glVertex2f(0.95f, 0.02f);
                Gl.glVertex2f(1, 0);
                Gl.glVertex2f(0.95f, -0.02f);
            Gl.glEnd();

            Gl.glBegin(Gl.GL_LINE_STRIP);//стрелочка х
                Gl.glVertex2f(-0.02f, 0.95f);
                Gl.glVertex2f(0, 1);
                Gl.glVertex2f(0.02f, 0.95f);
            Gl.glEnd();
        }

        private void stripToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawAxises();

            Gl.glColor3f(1, 0, 0);

            Gl.glBegin(Gl.GL_LINE_LOOP);
                Gl.glVertex2f(-0.2f, 0.3f);
                Gl.glVertex2f(-0.3f, -0.2f);
                Gl.glVertex2f(0.2f, -0.3f);
                Gl.glVertex2f(0.3f, -0.2f);
                Gl.glVertex2f(0.2f, 0.2f);
                Gl.glVertex2f(0, 0);
            Gl.glEnd();

            canvas.Invalidate();
        }

        private void polygonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawAxises();

            Gl.glBegin(Gl.GL_POLYGON);
                Gl.glColor3f(1, 1, 0);
                Gl.glVertex2f(-0.2f, 0.3f);
                Gl.glColor3f(0, 1, 1);
                Gl.glVertex2f(-0.3f, -0.2f);
                Gl.glColor3f(0, 0, 0);
                Gl.glVertex2f(0, -0.265f);
                Gl.glColor3f(0, 1, 0);
                Gl.glVertex2f(0, 0);
            Gl.glEnd();

            Gl.glBegin(Gl.GL_POLYGON);
                Gl.glColor3f(1, 0, 1);
                Gl.glVertex2f(0, -0.265f);
                Gl.glColor3f(0, 0, 1);
                Gl.glVertex2f(0.2f, -0.3f);
                Gl.glColor3f(0, 1, 0);
                Gl.glVertex2f(0.3f, -0.2f);
                Gl.glColor3f(1, 0, 1);
                Gl.glVertex2f(0.2f, 0.2f);
                Gl.glColor3f(1, 0, 0);
                Gl.glVertex2f(0, 0);
            Gl.glEnd();

            canvas.Invalidate();
        }
    }
}
