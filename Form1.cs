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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FlappyBird flappyBird = new FlappyBird();
            flappyBird.Show();
        }

        private void runningDinosaurBtn_Click(object sender, EventArgs e)
        {
            RunningDinosaur runningDinosaur = new RunningDinosaur();
            runningDinosaur.Show();
        }

        private void popTheBalloonsBtn_Click(object sender, EventArgs e)
        {
            PopTheBallonsGame popTheBallonsGame = new PopTheBallonsGame();
            popTheBallonsGame.Show();
        }

        private void saveTheEggsBtn_Click(object sender, EventArgs e)
        {
            SaveTheEggsGame saveTheEggsGame=new SaveTheEggsGame();
            saveTheEggsGame.Show();
        }

        private void ScaryMazeBtn_Click(object sender, EventArgs e)
        {
            ScaryMaze scaryMaze = new ScaryMaze();
            scaryMaze.Show();
        }

        private void tutorialBtn_Click(object sender, EventArgs e)
        {
            TutorialWindow tutorialWindow=new TutorialWindow();
            tutorialWindow.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
