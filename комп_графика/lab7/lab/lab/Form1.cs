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

namespace lab
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
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);
            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(45, (float)canvas.Width / (float)canvas.Height, 0.1, 200);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();

            Gl.glViewport(0, 0, canvas.Width, canvas.Height);
            Gl.glClearColor(0.5f, 0.5f, 0.5f, 1f);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glEnable(Gl.GL_DEPTH_TEST);

            float[] fogColor = { 0.5f, 0.5f, 0.5f, 1f };
            Gl.glEnable(Gl.GL_FOG);
            Gl.glFogi(Gl.GL_FOG_MODE, Gl.GL_EXP);
            Gl.glFogfv(Gl.GL_FOG_COLOR, fogColor);
            Gl.glFogf(Gl.GL_FOG_DENSITY, 0.3f);
            Gl.glFogf(Gl.GL_FOG_START, 0.5f);
            Gl.glFogf(Gl.GL_FOG_END, 10f);

            draw();
            timer1.Start();
        }

        float angle = 0;

        public void torus()
        {
            Gl.glPushMatrix();

            Gl.glEnable(Gl.GL_BLEND);
            Gl.glBlendFunc(Gl.GL_SRC_ALPHA, Gl.GL_ONE_MINUS_SRC_ALPHA);

            Gl.glColor4f(0.5f, 0, 0, 0.5f);

            Gl.glTranslated(0, 0, -6);

            Glut.glutSolidTorus(0.3f, 0.6, 20, 20);
            Gl.glPopMatrix();
        }

        public void octaedron()
        {
            Gl.glColor3f(0, 1f, 0);
            Gl.glPushMatrix();

            Gl.glEnable(Gl.GL_BLEND);
            Gl.glBlendFunc(Gl.GL_SRC_ALPHA, Gl.GL_ONE_MINUS_SRC_ALPHA);

            Gl.glColor4f(0, 1f, 0, 0.5f);

            Gl.glTranslated(0, 0, -6);

            Gl.glRotated(angle, 0, 1, 0);
            Gl.glTranslated(-3, 0, 0);

            Glut.glutSolidOctahedron();
            Gl.glPopMatrix();
        }

        public void tetrahedron()
        {
            Gl.glColor3f(0, 0, 1f);
            Gl.glPushMatrix();

            Gl.glTranslated(0, 0, -6);

            Gl.glRotated(angle, 90, 0, 0);
            Gl.glTranslated(0, 3, 0);

            Glut.glutWireTetrahedron();
            Gl.glPopMatrix();
        }

        private void canvas_Load(object sender, EventArgs e)
        {

        }

        public void draw()
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);

            torus();
            octaedron();
            tetrahedron();

            canvas.Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            angle = (angle + 1) % 360;
            draw();
        }
    }
}
