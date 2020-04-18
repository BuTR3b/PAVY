using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics; //----
using System.IO;

namespace FormGame
{
    public partial class Form1 : Form
    {
        int level;
        bool alive;
        bool is_spined;
        bool is_spined_twice;
        int[] pistol_drum;
        int bullet;
        Random cell_drum;

        public Form1()
        {
            InitializeComponent();
            level = 0;
            alive = true;
            is_spined = false;
            is_spined_twice = false;
        }

        public void Win()
        {
            MessageBox.Show("YOU WIN!");
        }

        private void buttonDrum_Click(object sender, EventArgs e)
        {
            if (is_spined_twice != true)
            {
                textBox1.Clear();
                level++;
                is_spined = true;
                is_spined_twice = true;
                SoundPlayer drumSound = new SoundPlayer(Environment.CurrentDirectory + "/spin.wav");
                drumSound.Play();
                textBox1.Text += Convert.ToString(level);
            }
            else
            {
                SoundPlayer drumSound = new SoundPlayer(Environment.CurrentDirectory + "/spin.wav");
                drumSound.Play();
            }
            
        }

        private void buttonShot_Click(object sender, EventArgs e)
        {
            SoundPlayer shotSound = new SoundPlayer(Environment.CurrentDirectory + "/shot.wav");
            SoundPlayer notShotSound = new SoundPlayer(Environment.CurrentDirectory + "/notshot.wav");
            cell_drum = new Random();
            bullet = cell_drum.Next(0, 7);
            bullet = cell_drum.Next(0, 7);
            bullet = cell_drum.Next(0, 7);
            bullet = cell_drum.Next(0, 7);
            bullet = cell_drum.Next(0, 7);
            bullet = cell_drum.Next(0, 7);           
            pistol_drum = new int[] { 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < level; i++)
            {
                pistol_drum[i] = 1;
            }
            if (alive == true && is_spined == true)
            {
                if (pistol_drum[bullet] == 0 && level < 7)
                {
                    notShotSound.Play();
                    is_spined = false;
                    is_spined_twice = false;
                } 
                else if (pistol_drum[bullet] == 0 && level == 7) // для проверки pistol_drum[7] == 0 && level == 7
                {
                    MessageBox.Show("YOU WIN!");
                    Application.Exit();
                }
                else if (pistol_drum[bullet] == 1 && level <= 7)
                {
                    shotSound.Play();
                    Process.Start("shutdown", "/s /t 5 /c \" Wasted\"");
                }
            }
            else if (alive == true && is_spined == false)
            {
                MessageBox.Show("Номер \"тринадцать\", крутите барабан!");
            }

        }
    }
}
