using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Notebook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            StreamWriter sw = new StreamWriter(path: @"C:\test\test.txt", append: true);
            sw.Write(textBox1.Text);
            sw.Close();
            */
            File.WriteAllText(path: @"C:\test\test.txt", contents: textBox1.Text);
            File.AppendAllText(path: @"C:\test\test.txt", contents: textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Process.Start("notepad.exe", @"C:\test\test.txt");
            /*
            StreamReader sr = new StreamReader(path: @"C:\test\test.txt");
            textBox1.Text = sr.ReadToEnd();
            sr.Close();
            */
            string s = File.ReadAllText(path: @"C:\test\test.txt");
            MessageBox.Show(s);
        }
    }
}
