using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g;
        Brush b;
        Pen p;
        bool pressed = false;
        int x = 0;
        int y = 0;
        int pen_width = 7;
        int[] color = new int[3];

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Клавиши + - для регулирование толщины\nЦифры от 1 до 0 для выбора цвета");
            g = CreateGraphics();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            pressed = true;
            x = e.X;
            y = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            pressed = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            b = new SolidBrush(Color.FromArgb(color[0], color[1], color[2]));
            if (pressed)
            {
                Rectangle rect = new Rectangle(e.X - pen_width, e.Y - pen_width, pen_width, pen_width);
                g.FillEllipse(b, rect);
                x = e.X;
                y = e.Y;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.OemMinus)
            {
                pen_width -= 2;
            } 
            else 
            if (e.KeyCode == Keys.Oemplus)
            {
                pen_width += 2;
            }

            if (e.KeyCode == Keys.D1)
            {
                color[0] = 0;
                color[1] = 0;
                color[2] = 0;
            }
            else if (e.KeyCode == Keys.D2)
            {
                color[0] = 128;
                color[1] = 0;
                color[2] = 0;
            }
            else if (e.KeyCode == Keys.D3)
            {
                color[0] = 128;
                color[1] = 128;
                color[2] = 0;
            }
            else if (e.KeyCode == Keys.D4)
            {
                color[0] = 128;
                color[1] = 128;
                color[2] = 128;
            }
            else if (e.KeyCode == Keys.D5)
            {
                color[0] = 255;
                color[1] = 128;
                color[2] = 128;
            }
            else if (e.KeyCode == Keys.D6)
            {
                color[0] = 255;
                color[1] = 255;
                color[2] = 128;
            }
            else if (e.KeyCode == Keys.D7)
            {
                color[0] = 255;
                color[1] = 20;
                color[2] = 147;
            }
            else if (e.KeyCode == Keys.D8)
            {
                color[0] = 255;
                color[1] = 165;
                color[2] = 0;
            }
            else if (e.KeyCode == Keys.D9)
            {
                color[0] = 255;
                color[1] = 255;
                color[2] = 0;
            }
            else if (e.KeyCode == Keys.D0)
            {
                color[0] = 0;
                color[1] = 0;
                color[2] = 205;
            }
        }
    }
}
