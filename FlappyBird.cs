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
    public partial class FlappyBird : Form
    {
        int pipeSpeed = 8;
        int gravity = 5;
        int score = 0;
        public FlappyBird()
        {
            InitializeComponent();
        }


        private void gameTimeEvent(object sender, EventArgs e)
        {
            flappyBirdPicture.Top += gravity;
            pipeDown.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            pipeDown2.Left -= pipeSpeed;
            pipeTop2.Left -= pipeSpeed;
            scoreTxt.Text = "Score: " + score;

            if (pipeDown.Left < -150)
            {
                pipeDown.Left = 600;
                score++;

            }

            if (pipeTop.Left < -180)
            {
                pipeTop.Left = 750;

            }

            if (pipeDown2.Left < -150)
            {
                pipeDown2.Left = 600;


            }

            if (pipeTop2.Left < -180)
            {
                pipeTop2.Left = 750;
                score++;
            }

            if (flappyBirdPicture.Bounds.IntersectsWith(pipeDown.Bounds) ||
                flappyBirdPicture.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBirdPicture.Bounds.IntersectsWith(pipeDown2.Bounds) ||
                flappyBirdPicture.Bounds.IntersectsWith(pipeTop2.Bounds) ||
                flappyBirdPicture.Bounds.IntersectsWith(Ground.Bounds) ||
                flappyBirdPicture.Top < -20)
            {
                endGame();
            }


            if (score > 5)
            {
                pipeSpeed = 9;
            }

            if (score > 10)
            {
                pipeSpeed = 10;
            }

            if (score > 15)
            {
                pipeSpeed = 12;
            }

            if (score > 25)
            {
                pipeSpeed = 14;
            }

            if (score > 30)
            {
                pipeSpeed = 18;
            }

            if (score > 35)
            {
                pipeSpeed = 20;
            }

            if (score > 40)
            {
                pipeSpeed = 23;
            }

        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }

        private void endGame()
        {
            gameTimeFlappyBird.Stop();
            scoreTxt.Text += "  Game over  ";

        }
    }
}
