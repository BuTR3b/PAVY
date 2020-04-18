using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPAKTOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Brush black = new SolidBrush(Color.Black);
        Brush gray = new SolidBrush(Color.Gray);
        Brush brown = new SolidBrush(Color.Brown);
        Brush white = new SolidBrush(Color.White);
        Pen black_pen = new Pen(Color.Black);
        private Graphics g;
        private int x = 0;
        private int y = 0;
        private bool right = false;
        private bool down = false;
        private bool left = false;
        private bool up = false;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            if (x < 510 && y == 0)
            {
                right = true;
                down = false;
                left = false;
                up = false;
                e.Graphics.FillRectangle(brown, x + 115, y + 100, 120, 80);                   // тело
                e.Graphics.FillRectangle(brown, x + 70, y + 50, 70, 80);                      // лицо
                e.Graphics.FillEllipse(white, x + 120, y + 55, 20, 40);                       // глаз
                e.Graphics.FillEllipse(black, x + 130, y + 65, 10, 20);                       // зрачок
                e.Graphics.FillEllipse(brown, x + 70, y + 40, 70, 20);                        // шляпа
                e.Graphics.FillRectangle(brown, x + 235, y + 120, 20, 60);                    // рот
                e.Graphics.FillRectangle(black, x + 200, y + 135, 55, 5);                     // еще рот
                e.Graphics.FillEllipse(brown, x + 225, y + 99, 30, 30);                       // нос
                e.Graphics.FillRectangle(brown, x + 205, y + 50, 10, 50);                     // труба
                e.Graphics.FillEllipse(black, x + 10, y + 100, width: 130, height: 130);      // задняя шина
                e.Graphics.FillEllipse(gray, x + 35, y + 125, width: 80, height: 80);         // задний диск
                e.Graphics.FillEllipse(black, x + 200, y + 150, width: 80, height: 80);       // передняя шина
                e.Graphics.FillEllipse(gray, x + 223, y + 172, width: 35, height: 35);        // передний диск

            }
            else if (x == 510 && y < 180)
            {
                right = false;
                down = true;
                left = false;
                up = false;
                e.Graphics.FillRectangle(brown, x + 115, y + 100, 120, 80);
                e.Graphics.FillRectangle(brown, x + 70, y + 50, 70, 80);
                e.Graphics.FillEllipse(white, x + 120, y + 55, 20, 40);
                e.Graphics.FillEllipse(black, x + 130, y + 65, 10, 20);
                e.Graphics.FillEllipse(brown, x + 70, y + 40, 70, 20);
                e.Graphics.FillRectangle(brown, x + 235, y + 120, 20, 60);
                e.Graphics.FillRectangle(black, x + 200, y + 135, 55, 5);
                e.Graphics.FillEllipse(brown, x + 225, y + 99, 30, 30);
                e.Graphics.FillRectangle(brown, x + 205, y + 50, 10, 50);
                e.Graphics.FillEllipse(black, x + 10, y + 100, width: 130, height: 130);
                e.Graphics.FillEllipse(gray, x + 35, y + 125, width: 80, height: 80);
                e.Graphics.FillEllipse(black, x + 200, y + 150, width: 80, height: 80);
                e.Graphics.FillEllipse(gray, x + 223, y + 172, width: 35, height: 35);
            } 
            else if (x > 10 && y == 180)
            {
                right = false;
                down = false;
                left = true;
                up = false;
                e.Graphics.FillRectangle(brown, x + 115, y + 100, 120, 80);
                e.Graphics.FillRectangle(brown, x + 70, y + 50, 70, 80);
                e.Graphics.FillEllipse(white, x + 120, y + 55, 20, 40);
                e.Graphics.FillEllipse(black, x + 130, y + 65, 10, 20);
                e.Graphics.FillEllipse(brown, x + 70, y + 40, 70, 20);
                e.Graphics.FillRectangle(brown, x + 235, y + 120, 20, 60);
                e.Graphics.FillRectangle(black, x + 200, y + 135, 55, 5);
                e.Graphics.FillEllipse(brown, x + 225, y + 99, 30, 30);
                e.Graphics.FillRectangle(brown, x + 205, y + 50, 10, 50);
                e.Graphics.FillEllipse(black, x + 10, y + 100, width: 130, height: 130);
                e.Graphics.FillEllipse(gray, x + 35, y + 125, width: 80, height: 80);
                e.Graphics.FillEllipse(black, x + 200, y + 150, width: 80, height: 80);
                e.Graphics.FillEllipse(gray, x + 223, y + 172, width: 35, height: 35);
            }
            else if (x == 10 && y > 0)
            {
                right = false;
                down = false;
                left = false;
                up = true;
                e.Graphics.FillRectangle(brown, x + 115, y + 100, 120, 80);                   
                e.Graphics.FillRectangle(brown, x + 70, y + 50, 70, 80);                      
                e.Graphics.FillEllipse(white, x + 120, y + 55, 20, 40);                       
                e.Graphics.FillEllipse(black, x + 130, y + 65, 10, 20);                       
                e.Graphics.FillEllipse(brown, x + 70, y + 40, 70, 20);                        
                e.Graphics.FillRectangle(brown, x + 235, y + 120, 20, 60);                    
                e.Graphics.FillRectangle(black, x + 200, y + 135, 55, 5);                     
                e.Graphics.FillEllipse(brown, x + 225, y + 99, 30, 30);                      
                e.Graphics.FillRectangle(brown, x + 205, y + 50, 10, 50);                     
                e.Graphics.FillEllipse(black, x + 10, y + 100, width: 130, height: 130);      
                e.Graphics.FillEllipse(gray, x + 35, y + 125, width: 80, height: 80);       
                e.Graphics.FillEllipse(black, x + 200, y + 150, width: 80, height: 80);      
                e.Graphics.FillEllipse(gray, x + 223, y + 172, width: 35, height: 35);  
            }

            //e.Graphics.FillEllipse(black, xx, y: 100, width: 100, height: 100);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (right)
            {
                x += 2;
            }
            else if (down)
            {
                y += 2;
            }
            else if (left)
            {
                x -= 2;
            }
            else
            {
                y -= 2;
            }
            Refresh();
        }
    }
}
