using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.FreeGlut;
using Tao.OpenGl;
using Tao.Platform.Windows;

namespace Kursovaia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            space.InitializeContexts();
        }

        private int SpeedRotation = 0;
        private int Angle = 0;

        /*
        * если не работает glutInit() -> из папки C:\Windows\System32 скопировать freeglut.dll в папку выше
        */
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label3.Text = String.Format("Current speed: {0}", trackBar1.Value);
            SpeedRotation = trackBar1.Value;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void Torus(int small_radius, int big_radius)
        {
            double Two_Pi = 2 * Math.PI;
            for (int i = 0; i < small_radius; i++)
            {   
                if (radioButtonWire.Checked)
                {
                    Gl.glBegin(Gl.GL_LINE_LOOP);
                }
                else
                if (radioButtonSolid.Checked)
                {
                    Gl.glBegin(Gl.GL_QUAD_STRIP);
                }
                else
                if (radioButtonPoints.Checked)
                {
                    Gl.glPointSize(4f);
                    Gl.glBegin(Gl.GL_POINTS);
                }
                else
                if (radioButtonLine.Checked)
                {
                    Gl.glBegin(Gl.GL_LINES);
                }
                for (int j = 0; j <= big_radius; j++)
                {
                    for (int k = 1; k >= 0; k--) // соединяем образующие окружности
                    {
                        double r = (i + k) % small_radius + 0.5; // радиус образующей окружн
                        double t = j % big_radius;
                        double x = (0.4 + 0.1 * Math.Cos(r * Two_Pi / small_radius)) * Math.Cos(t * Two_Pi / big_radius);
                        double y = (0.4 + 0.1 * Math.Cos(r * Two_Pi / small_radius)) * Math.Sin(t * Two_Pi / big_radius);
                        double z = 0.1 * Math.Sin(r * Two_Pi / small_radius);
                        Gl.glColor3d(z + 0.5, y + 0.5, x + 0.5);
                        Gl.glVertex3d(x, y, z);
                    }
                }
                Gl.glEnd();
            }
        }

        private void Draw()
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glClearColor(0, 0, 0, 1);
            Gl.glLoadIdentity();
            Gl.glPushMatrix();
            Gl.glTranslated(0, 0, -2);
            if ( !checkBoxX.Checked && !checkBoxY.Checked && !checkBoxZ.Checked)
            {
                Gl.glRotated(0, 0, 0, 0);
            }
            else
            {
                Gl.glRotated(Angle, Convert.ToInt32(checkBoxX.Checked), Convert.ToInt32(checkBoxY.Checked), Convert.ToInt32(checkBoxZ.Checked));
            } 
            Gl.glPushMatrix();
            Torus(20, 50);
            Gl.glPopMatrix();
            Gl.glFlush();
            space.Invalidate();
        }   

        private void VisualButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE );
            Gl.glClearColor(0, 0, 0, 1);
            Gl.glViewport(0, 0, space.Width, space.Height);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Glu.gluPerspective(45, (float)space.Width / (float)space.Height, 1, 200);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glEnable(Gl.GL_DEPTH_TEST);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Angle <= 360)
            {
                Angle += SpeedRotation;
            }
            else
            {
                Angle = 0;
                Angle += SpeedRotation;
            }
            Draw();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }
    }
}
