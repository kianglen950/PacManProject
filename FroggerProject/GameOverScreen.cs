using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FroggerProject
{
    public partial class GameOverScreen : UserControl
    {
        public GameOverScreen()
        {
            InitializeComponent();
        }

        private void redoButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new MenuScreen()); //go to menu screen
        }

        private void exitButton2_Click(object sender, EventArgs e)
        {
            Application.Exit(); //close the program

        }
    }
}
