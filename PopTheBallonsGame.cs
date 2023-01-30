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
    public partial class PopTheBallonsGame : Form
    {
        int speed;
        int score;
        Random random=new Random();
        bool isGameOver;
        public PopTheBallonsGame()
        {
            InitializeComponent();
            RestartTheGame();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            scoreTxt.Text = "Score: " + score;
            if (isGameOver == true)
            {
                gameBalloonTimer.Stop();
                scoreTxt.Text = "Score: " + score + "  Game over, press R to restart!";
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    x.Top -= speed;

                    if(x.Top < -100)
                    {
                        x.Top=random.Next(700, 1000);
                        x.Left = random.Next(5, 500);
                    }

                    if((string)x.Tag == "balloon")
                    {
                        if (x.Top < -50)
                        {
                            isGameOver = true;
                        }
                        if (bomb.Bounds.IntersectsWith(x.Bounds))
                        {
                            x.Top = random.Next(700, 1000);
                            x.Left = random.Next(5, 500);
                        }
                    }
                }
            }
            if (score > 5)
            {
                speed = 8;
            }
            if (score > 12)
            {
                speed = 12;
            }
            if (score > 20)
            {
                speed = 15;
            }
            if (score > 30)
            {
                speed = 20;
            }
        }

        private void PopBallon(object sender, EventArgs e)
        {
            if (isGameOver == false)
            {
                var balloon=(PictureBox)sender;
                balloon.Top=random.Next(750,1000);
                balloon.Left=random.Next(5,500);
                score += 1;
            }
        }
        private void goBoom(object sender, EventArgs e)
        {
            if (isGameOver == false)
            {
                bomb.Image = Properties.Resources.boom;
                isGameOver = true;
            }

        }
        private void keyisup(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.R && isGameOver == true)
            {
                RestartTheGame();
            }
        }

        private void RestartTheGame()
        {
            speed = 5;
            score = 0;
            isGameOver = false;
            bomb.Image = Properties.Resources.bomb;

            foreach(Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    x.Top=random.Next(750, 1000);
                    x.Left = random.Next(5, 500);
                }
            }
            gameBalloonTimer.Start();
        }

    }
}
