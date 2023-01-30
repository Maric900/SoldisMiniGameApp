using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoldisMiniGameApp
{
    public partial class SaveTheEggsGame : Form
    {
        bool goLeft, goRight;
        int speed;
        int score;
        int missed;

        Random randomX=new Random();
        Random randomY = new Random();

        PictureBox splash=new PictureBox();
        public SaveTheEggsGame()
        {
            InitializeComponent();
            RestartTheGame();
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Saved: " + score;
            txtMissed.Text = "Missed: " + missed;

            if (goLeft == true && player.Left > 0)
            {
                player.Left -= 12;
                player.Image = Properties.Resources.chicken_normal2;
            }

            if (goRight == true && player.Left +player.Width<this.ClientSize.Width)
            {
                player.Left += 12;
                player.Image = Properties.Resources.chicken_normal;
            }

            foreach(Control x in this.Controls)
            {
                    
                if(x is PictureBox && (string)x.Tag == "eggs")
                {

              
                x.Top += speed;

                if (x.Top + x.Height > this.ClientSize.Height)
                {
                    splash.Image= Properties.Resources.splash;
                    splash.Location = x.Location;
                    splash.Height = 60;
                    splash.Width = 60;
                    splash.BackColor = Color.Transparent;

                    this.Controls.Add(splash);

                    x.Top=randomX.Next(5, this.ClientSize.Width - x.Width);
                    x.Top = randomY.Next(80, 300) * -1;
                    missed += 1;
                    player.Image = Properties.Resources.chicken_hurt;
                }
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        x.Top = randomX.Next(5, this.ClientSize.Width - x.Width);
                        x.Top = randomY.Next(80, 300) * -1;
                        score += 1;
                    }
                }
            }
            if (score > 10)
            {
                speed = 11;
            }
            if (score > 20)
            {
                speed = 12;
            }
            if (score > 30)
            {
                speed = 13;
            }
            if (missed > 5)
            {
                GameTimer.Stop();
                MessageBox.Show("Game over!" + Environment.NewLine + " You lost to much egg" + Environment.NewLine + "Click ok to retry");
                RestartTheGame();
            }
        }


        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
            goLeft = true;
            }
        
            if (e.KeyCode == Keys.Right)
       
            {
            goRight = true;
       
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
        }

        private void RestartTheGame()
        {
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "eggs")
                {
                    x.Left = randomX.Next(5, this.ClientSize.Width - x.Width);
                    x.Top = randomY.Next(80,300)*-1;  //problem?
                }
            }
            player.Left=this.ClientSize.Width/2;
            player.Image = Properties.Resources.chicken_normal;

            score = 0;
            missed = 0;
            speed = 8;

            goLeft = false;
            goRight = false;
            GameTimer.Start();
        }
    }
}

