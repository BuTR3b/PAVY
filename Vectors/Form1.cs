using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vectors
{
    public partial class Form1 : Form
    {
        private myVector a, b;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double[] razn = new double[3];
            textBox8.Clear();
            a = new myVector(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
            b = new myVector(Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text), Convert.ToDouble(textBox6.Text));
            razn = a - b;
            for (int i = 0; i < 3; i++)
            {
                textBox8.Text += Convert.ToString(razn[i]);
                textBox8.Text += ' ';
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox8.Clear();
            try
            {
                double num = Convert.ToDouble(textBox7.Text);
                a = new myVector(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
                b = new myVector(Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text), Convert.ToDouble(textBox6.Text));
                textBox8.Text += "  1й: " + a.X * num + ' ' + a.Y * num + ' ' + a.Z * num;
                textBox8.Text += "           ";
                textBox8.Text += "  2й: " + b.X * num + ' ' + b.Y * num + ' ' + b.Z * num;
            }
            catch
            {
                MessageBox.Show("Введите число");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                a = new myVector(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
                b = new myVector(Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text), Convert.ToDouble(textBox6.Text));
                label11.Text = Convert.ToString(a.get_length(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text)));
                label12.Text = Convert.ToString(b.get_length(Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text), Convert.ToDouble(textBox6.Text)));
            }
            catch
            {
                MessageBox.Show("Введите координаты векторов");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double proizved;
            textBox8.Clear();
            a = new myVector(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
            b = new myVector(Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text), Convert.ToDouble(textBox6.Text));
            proizved = a * b;
            textBox8.Text += proizved;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] summa = new double[3];
            textBox8.Clear();
            a = new myVector(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
            b = new myVector(Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text), Convert.ToDouble(textBox6.Text));
            summa = a + b;
            for (int i = 0; i < 3; i++)
            {
                textBox8.Text += Convert.ToString(summa[i]);
                textBox8.Text += ' ';
            }
        }
    }
}
