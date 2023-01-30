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
    public partial class RunningDinosaur : Form
    {
        bool jumping = false;
        int jumpSpeed = 12;
        int force = 12;
        int score = 0;
        int obstaclespeed = 10;
        Random rand = new Random();
        int position;
        bool isGameOver = false;
        int meteorspeed = 3;
        public RunningDinosaur()
        {
            InitializeComponent();
            GameReset();
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            dinosaur.Top += jumpSpeed;
            txtScore.Text = "Score: " + score;

            if (jumping == true && force < 0)
            {
                jumping = false;

            }

            if (jumping == true)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }

            if (dinosaur.Top > 279 && jumping == false)
            {
                force = 12;
                dinosaur.Top = 285;
                jumpSpeed = 0;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= obstaclespeed;

                    if (x.Left + x.Width < -100)
                    {
                        x.Left = this.ClientSize.Width + rand.Next(200, 500) + (x.Width * 15);
                        score++;
                    }
                    if (dinosaur.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameTimer.Stop();
                        dinosaur.Image = Properties.Resources.dead;
                        txtScore.Text += "   Press R to restart the game";
                        isGameOver = true;
                    }
                }
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "meteors")
                {
                    x.Left -= meteorspeed;

                    if (x.Left + x.Width < -100)
                    {
                        x.Left = this.ClientSize.Width + rand.Next(100, 300) + (x.Width * 15);
                    }
                }
            }


            if (score > 10)
            {
                obstaclespeed = 12;
            }

            if (score > 20)
            {
                obstaclespeed = 14;
            }
            if (score > 20)
            {

                obstaclespeed = 16;
            }

            if (score > 40)
            {

                obstaclespeed = 18;
            }

            if (score > 60)
            {

                obstaclespeed = 20;
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (jumping == true)
            {
                jumping = false;
            }

            if (e.KeyCode == Keys.R && isGameOver == true)
            {
                GameReset();
            }
        }
        private void GameReset()
        {
            force = 12;
            jumpSpeed = 0;
            jumping = false;
            score = 0;
            obstaclespeed = 10;
            txtScore.Text = "Score: " + score;
            dinosaur.Image = Properties.Resources.running;
            isGameOver = false;
            dinosaur.Top = 282;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    position = this.ClientSize.Width + rand.Next(500, 800) + (x.Width * 10);
                    x.Left = position;
                }
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "meteors")
                {
                    position = this.ClientSize.Width + rand.Next(500, 800) + (x.Width * 10);
                    x.Left = position;
                }
            }

            gameTimer.Start();
        }
    }
}
