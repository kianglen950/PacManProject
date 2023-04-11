using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FroggerProject
{
    public partial class MenuScreen : UserControl
    {
        SoundPlayer startSound = new SoundPlayer(Properties.Resources.pacman_beginning); //sound player for intro sound
        public MenuScreen()
        {
            InitializeComponent();
            startSound.Play(); //start the sound
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new GameScreen()); //go to game screen
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); //close program
        }
    }
}
