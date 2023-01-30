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

namespace SoldisMiniGameApp
{
    public partial class ScaryMaze : Form
    {
        SoundPlayer player=new SoundPlayer();
        SoundPlayer scare=new SoundPlayer();
        public ScaryMaze()
        {
            InitializeComponent();
        }

        private void StartButtonEvent(object sender, EventArgs e)
        {
           StartGame();
        }

        private void MouseEvent(object sender, EventArgs e)
        {
            EndGame();
        }

        private void ShowScreamWindow(object sender, EventArgs e)
        {
            ScareWindow scareWindow = new ScareWindow();
            scareWindow.Show();
            player.Stop();
            scare.Play();
        }
        private void StartGame()
        {
            startButton.Enabled = false;
            player.Stream = Properties.Resources.bg_music;
            scare.Stream = Properties.Resources.scare;
            player.PlayLooping();

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox)
                {
                x.Enabled = true;
                x.MouseDown += X_MouseDown;
                    if (x.Tag == null)
                    {
                        x.BackColor = Color.LightBlue;
                    }
                }

            }

        }

        private void X_MouseDown(object sender, MouseEventArgs e)
        {
            EndGame();
        }

        private void EndGame()
        {
            startButton.Enabled = true;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    x.Enabled = false;

                    if (x.Tag == null)
                    {
                        x.BackColor = Color.Black;
                    }
                }

            }
        }
    }
}
