using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.ScrollBars = ScrollBars.Vertical;
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            int n;
            try
            {
                n = Convert.ToInt32(textBox1.Text);
                StreamWriter file = new StreamWriter(@"C:\test\test.txt");
                for (int i = 2; i <= n; i++)
                {
                    bool prime = true;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0 & i % 1 == 0)
                        {
                            prime = false;
                        }
                    }
                    if (prime)
                    {
                        textBox2.Text += i + "\r\n";
                        file.WriteLine(Convert.ToString(i));
                    }
                    else
                    {
                        textBox2.Text += i + " ";
                        file.Write(Convert.ToString(i) + " ");
                    }
                }
                file.Close();
            }
            catch
            {
                MessageBox.Show("Введите N");
            }
        }

        private void open_button_Click(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader(@"C:\test\test.txt");
            textBox2.Text = file.ReadToEnd();
            file.Close();
        }
    }
}
