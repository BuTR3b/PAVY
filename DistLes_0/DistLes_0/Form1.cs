using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistLes_0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Brush b = new SolidBrush(Color.FromArgb(255, 200, 200));
        private Graphics g;
        private int x = 0;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            e.Graphics.FillEllipse(b, x, y: 10, width: 200, height: 200);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x++;
            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.TransferValue(s: "!!!");
            f2.ShowDialog();
        }
    }
}
