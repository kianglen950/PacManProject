//Kian Kian Glenfield - 2D Game project (Pac-Man)
//Using using multiple screens and classes

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Media;

namespace FroggerProject
{
    public partial class GameScreen : UserControl
    {
        int points;        //integers for points and lives, how many to win or lose
        int lives = 5;

        Ghost ghost; //make player and ghost class useable on game screen
        player hero;

        Boolean aDown, dDown, wDown, sDown, upDown, downDown, leftDown, rightDown; //movement
        Boolean powered;
        
        
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow); //different brushes to paint each object
        SolidBrush blueBrush = new SolidBrush(Color.DarkBlue);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        
        List<wall> walls = new List<wall>(); //list for all walls
        List<Pellets> pellets = new List<Pellets>(); //list for all pellets
        List<PowerPellet> powerPellet = new List<PowerPellet>(); //list for power pellets

        SoundPlayer moveSound = new SoundPlayer(Properties.Resources.pacman_chomp); //different soundplayers for each sound
        SoundPlayer deathSound = new SoundPlayer(Properties.Resources.pacman_death);
        SoundPlayer ghostEatSound = new SoundPlayer(Properties.Resources.pacman_eatghost);
        public GameScreen()
        {
            InitializeComponent();
            InitializeGame(); //call start game method

        }



        public void InitializeGame() //starts the engine, spawns the player and ghost, and also the pellets and walls
        {
            gameEngine.Start();
            hero = new player(317, 455);
            ghost = new Ghost(317, 280);
            Walls();
            spawnPellets();
            spawnPowerPellets();
            moveSound.PlayLooping(); //start the sound in a loop
        }

        public void Walls() //method for the walls, draws each and adds to the list
        {
            wall newWall = new wall(70, 192, 113, 9);
            walls.Add(newWall);

            newWall = new wall(180, 200, 9, 60);
            walls.Add(newWall);

            newWall = new wall(70, 260, 113, 9);
            walls.Add(newWall);

            newWall = new wall(70, 310, 113, 9);
            walls.Add(newWall);

            newWall = new wall(180, 315, 8, 70);
            walls.Add(newWall);

            newWall = new wall(70, 384, 113, 9);
            walls.Add(newWall);

            newWall = new wall(70, 384, 8, 206);
            walls.Add(newWall);

            newWall = new wall(70, 470, 40, 15);
            walls.Add(newWall);

            newWall = new wall(70, 560, 560, 10);
            walls.Add(newWall);

            newWall = new wall(560, 470, 40, 15);
            walls.Add(newWall);

            newWall = new wall(587, 384, 21, 206);
            walls.Add(newWall);

            newWall = new wall(485, 310, 120, 9);
            walls.Add(newWall);

            newWall = new wall(485, 315, 8, 70);
            walls.Add(newWall);

            newWall = new wall(485, 384, 120, 9);
            walls.Add(newWall);

            newWall = new wall(485, 192, 120, 9);
            walls.Add(newWall);

            newWall = new wall(485, 200, 8, 60);
            walls.Add(newWall);

            newWall = new wall(485, 260, 120, 9);
            walls.Add(newWall);

            newWall = new wall(587, 80, 21, 190);
            walls.Add(newWall);

            newWall = new wall(70, 80, 560, 10);
            walls.Add(newWall);

            newWall = new wall(330, 70, 15, 60);
            walls.Add(newWall);

            newWall = new wall(70, 80, 8, 200);
            walls.Add(newWall);

            newWall = new wall(110, 120, 60, 30);
            walls.Add(newWall);

            newWall = new wall(210, 120, 75, 30);
            walls.Add(newWall);

            newWall = new wall(500, 120, 60, 30);
            walls.Add(newWall);

            newWall = new wall(380, 120, 75, 30);
            walls.Add(newWall);

            newWall = new wall(260, 260, 35, 9);
            walls.Add(newWall);

            newWall = new wall(360, 260, 30, 9);
            walls.Add(newWall);

            newWall = new wall(260, 260, 9, 60);
            walls.Add(newWall);

            newWall = new wall(390, 260, 9, 60);
            walls.Add(newWall);

            newWall = new wall(260, 320, 139, 9);
            walls.Add(newWall);

            newWall = new wall(220, 180, 15, 100);
            walls.Add(newWall);

            newWall = new wall(220, 220, 60, 15);
            walls.Add(newWall);

            newWall = new wall(270, 180, 120, 15);
            walls.Add(newWall);

            newWall = new wall(320, 180, 15, 60);
            walls.Add(newWall);

            newWall = new wall(430, 180, 15, 100);
            walls.Add(newWall);

            newWall = new wall(380, 220, 60, 15);
            walls.Add(newWall);

            newWall = new wall(220, 325, 15, 60);
            walls.Add(newWall);

            newWall = new wall(435, 325, 15, 60);
            walls.Add(newWall);

            newWall = new wall(270, 385, 120, 15);
            walls.Add(newWall);

            newWall = new wall(320, 385, 15, 60);
            walls.Add(newWall);

            newWall = new wall(270, 480, 110, 15);
            walls.Add(newWall);

            newWall = new wall(320, 480, 15, 55);
            walls.Add(newWall);

            newWall = new wall(220, 430, 60, 15);
            walls.Add(newWall);

            newWall = new wall(380, 430, 60, 15);
            walls.Add(newWall);

            newWall = new wall(435, 480, 15, 40);
            walls.Add(newWall);

            newWall = new wall(380, 520, 150, 15);
            walls.Add(newWall);

            newWall = new wall(220, 480, 15, 40);
            walls.Add(newWall);

            newWall = new wall(120, 520, 150, 15);
            walls.Add(newWall);

            newWall = new wall(120, 430, 30, 15);
            walls.Add(newWall);

            newWall = new wall(150, 430, 15, 65);
            walls.Add(newWall);

            newWall = new wall(500, 430, 15, 65);
            walls.Add(newWall);

            newWall = new wall(500, 430, 40, 15);
            walls.Add(newWall);

        }

        public void spawnPellets() //method for spawning pellets, draws and put into list
        {
            Pellets newPellet = new Pellets(400, 410);
            pellets.Add(newPellet);

            newPellet = new Pellets(375, 410);
            pellets.Add(newPellet);

            newPellet = new Pellets(355, 410);
            pellets.Add(newPellet);

            newPellet = new Pellets(425, 410);
            pellets.Add(newPellet);

            newPellet = new Pellets(450, 410);
            pellets.Add(newPellet);

            newPellet = new Pellets(475, 410);
            pellets.Add(newPellet);

            newPellet = new Pellets(500, 410);
            pellets.Add(newPellet);

            newPellet = new Pellets(525, 410);
            pellets.Add(newPellet);

            newPellet = new Pellets(550, 410);
            pellets.Add(newPellet);

            newPellet = new Pellets(500, 505);
            pellets.Add(newPellet);

            newPellet = new Pellets(355, 430);
            pellets.Add(newPellet);


            newPellet = new Pellets(355, 450);
            pellets.Add(newPellet);


            newPellet = new Pellets(355, 465);
            pellets.Add(newPellet);


            newPellet = new Pellets(375, 465);
            pellets.Add(newPellet);


            newPellet = new Pellets(335, 465);
            pellets.Add(newPellet);

            newPellet = new Pellets(315, 465);
            pellets.Add(newPellet);

            newPellet = new Pellets(295, 465);
            pellets.Add(newPellet);

            newPellet = new Pellets(275, 465);
            pellets.Add(newPellet);

            newPellet = new Pellets(255, 465);
            pellets.Add(newPellet);

            newPellet = new Pellets(235, 465);
            pellets.Add(newPellet);

            newPellet = new Pellets(215, 465);
            pellets.Add(newPellet);

            newPellet = new Pellets(195, 465);
            pellets.Add(newPellet);

            newPellet = new Pellets(195, 445);
            pellets.Add(newPellet);

            newPellet = new Pellets(195, 425);
            pellets.Add(newPellet);

            newPellet = new Pellets(195, 405);
            pellets.Add(newPellet);

            newPellet = new Pellets(195, 385);
            pellets.Add(newPellet);

            newPellet = new Pellets(195, 365);
            pellets.Add(newPellet);

            newPellet = new Pellets(195, 345);
            pellets.Add(newPellet);

            newPellet = new Pellets(195, 325);
            pellets.Add(newPellet);

            newPellet = new Pellets(195, 305);
            pellets.Add(newPellet);

            newPellet = new Pellets(195, 285);
            pellets.Add(newPellet);

            newPellet = new Pellets(195, 265);
            pellets.Add(newPellet);

            newPellet = new Pellets(195, 245);
            pellets.Add(newPellet);

            newPellet = new Pellets(195, 225);
            pellets.Add(newPellet);

            newPellet = new Pellets(195, 205);
            pellets.Add(newPellet);

            newPellet = new Pellets(195, 185);
            pellets.Add(newPellet);

            newPellet = new Pellets(195, 165);
            pellets.Add(newPellet);

            newPellet = new Pellets(195, 145);
            pellets.Add(newPellet);

            newPellet = new Pellets(195, 125);
            pellets.Add(newPellet);

            newPellet = new Pellets(195, 105);
            pellets.Add(newPellet);

            newPellet = new Pellets(175, 105);
            pellets.Add(newPellet);

            newPellet = new Pellets(155, 105);
            pellets.Add(newPellet);

            newPellet = new Pellets(135, 105);
            pellets.Add(newPellet);

            newPellet = new Pellets(115, 105);
            pellets.Add(newPellet);

            newPellet = new Pellets(90, 105);
            pellets.Add(newPellet);

            newPellet = new Pellets(90, 125);
            pellets.Add(newPellet);

            newPellet = new Pellets(90, 145);
            pellets.Add(newPellet);

            newPellet = new Pellets(110, 165);
            pellets.Add(newPellet);

            newPellet = new Pellets(130, 165);
            pellets.Add(newPellet);

            newPellet = new Pellets(150, 165);
            pellets.Add(newPellet);

            newPellet = new Pellets(170, 165);
            pellets.Add(newPellet);

            newPellet = new Pellets(215, 165);
            pellets.Add(newPellet);

            newPellet = new Pellets(235, 165);
            pellets.Add(newPellet);

            newPellet = new Pellets(255, 165);
            pellets.Add(newPellet);

            newPellet = new Pellets(275, 165);
            pellets.Add(newPellet);

            newPellet = new Pellets(295, 165);
            pellets.Add(newPellet);

            newPellet = new Pellets(315, 165);
            pellets.Add(newPellet);

            newPellet = new Pellets(335, 165);
            pellets.Add(newPellet);

            newPellet = new Pellets(355, 165);
            pellets.Add(newPellet);

            newPellet = new Pellets(375, 165);
            pellets.Add(newPellet);

            newPellet = new Pellets(395, 165);
            pellets.Add(newPellet);

            newPellet = new Pellets(415, 165);
            pellets.Add(newPellet);

            newPellet = new Pellets(435, 165);
            pellets.Add(newPellet);

            newPellet = new Pellets(455, 165);
            pellets.Add(newPellet);

            newPellet = new Pellets(475, 165);
            pellets.Add(newPellet);

            newPellet = new Pellets(495, 165);
            pellets.Add(newPellet);

            newPellet = new Pellets(515, 165);
            pellets.Add(newPellet);

            newPellet = new Pellets(535, 165);
            pellets.Add(newPellet);

            newPellet = new Pellets(555, 165);
            pellets.Add(newPellet);

            newPellet = new Pellets(570, 145);
            pellets.Add(newPellet);

            newPellet = new Pellets(570, 125);
            pellets.Add(newPellet);

            newPellet = new Pellets(570, 105);
            pellets.Add(newPellet);

            newPellet = new Pellets(555, 105);
            pellets.Add(newPellet);

            newPellet = new Pellets(535, 105);
            pellets.Add(newPellet);

            newPellet = new Pellets(515, 105);
            pellets.Add(newPellet);

            newPellet = new Pellets(495, 105);
            pellets.Add(newPellet);

            newPellet = new Pellets(475, 105);
            pellets.Add(newPellet);

            newPellet = new Pellets(475, 125);
            pellets.Add(newPellet);

            newPellet = new Pellets(475, 145);
            pellets.Add(newPellet);

            newPellet = new Pellets(475, 165);
            pellets.Add(newPellet);

            newPellet = new Pellets(455, 105);
            pellets.Add(newPellet);

            newPellet = new Pellets(435, 105);
            pellets.Add(newPellet);

            newPellet = new Pellets(415, 105);
            pellets.Add(newPellet);

            newPellet = new Pellets(395, 105);
            pellets.Add(newPellet);

            newPellet = new Pellets(375, 105);
            pellets.Add(newPellet);

            newPellet = new Pellets(355, 105);
            pellets.Add(newPellet);

            newPellet = new Pellets(355, 125);
            pellets.Add(newPellet);

            newPellet = new Pellets(355, 145);
            pellets.Add(newPellet);

            newPellet = new Pellets(355, 165);
            pellets.Add(newPellet);

            newPellet = new Pellets(295, 145);
            pellets.Add(newPellet);

            newPellet = new Pellets(295, 125);
            pellets.Add(newPellet);

            newPellet = new Pellets(295, 105);
            pellets.Add(newPellet);

            newPellet = new Pellets(275, 105);
            pellets.Add(newPellet);

            newPellet = new Pellets(255, 105);
            pellets.Add(newPellet);

            newPellet = new Pellets(235, 105);
            pellets.Add(newPellet);

            newPellet = new Pellets(215, 105);
            pellets.Add(newPellet);

            newPellet = new Pellets(255, 185);
            pellets.Add(newPellet);

            newPellet = new Pellets(255, 205);
            pellets.Add(newPellet);

            newPellet = new Pellets(29, 205);
            pellets.Add(newPellet);

            newPellet = new Pellets(275, 205);
            pellets.Add(newPellet);

            newPellet = new Pellets(305, 205);
            pellets.Add(newPellet);


            newPellet = new Pellets(355, 205);
            pellets.Add(newPellet);

            newPellet = new Pellets(375, 205);
            pellets.Add(newPellet);

            newPellet = new Pellets(395, 205);
            pellets.Add(newPellet);

            newPellet = new Pellets(415, 205);
            pellets.Add(newPellet);

            newPellet = new Pellets(415, 185);
            pellets.Add(newPellet);

            newPellet = new Pellets(395, 465);
            pellets.Add(newPellet);

            newPellet = new Pellets(415, 465);
            pellets.Add(newPellet);

            newPellet = new Pellets(435, 465);
            pellets.Add(newPellet);

            newPellet = new Pellets(455, 465);
            pellets.Add(newPellet);

            newPellet = new Pellets(475, 465);
            pellets.Add(newPellet);

            newPellet = new Pellets(475, 445);
            pellets.Add(newPellet);

            newPellet = new Pellets(475, 425);
            pellets.Add(newPellet);

            newPellet = new Pellets(475, 485);
            pellets.Add(newPellet);

            newPellet = new Pellets(475, 505);
            pellets.Add(newPellet);

            newPellet = new Pellets(515, 505);
            pellets.Add(newPellet);

            newPellet = new Pellets(535, 505);
            pellets.Add(newPellet);

            newPellet = new Pellets(555, 505);
            pellets.Add(newPellet);

            newPellet = new Pellets(535, 485);
            pellets.Add(newPellet);

            newPellet = new Pellets(535, 465);
            pellets.Add(newPellet);

            newPellet = new Pellets(535, 450);
            pellets.Add(newPellet);

            newPellet = new Pellets(555, 450);
            pellets.Add(newPellet);

            newPellet = new Pellets(570, 450);
            pellets.Add(newPellet);

            newPellet = new Pellets(570, 430);
            pellets.Add(newPellet);

            newPellet = new Pellets(575, 505);
            pellets.Add(newPellet);

            newPellet = new Pellets(575, 525);
            pellets.Add(newPellet);

            newPellet = new Pellets(575, 545);
            pellets.Add(newPellet);

            newPellet = new Pellets(555, 545);
            pellets.Add(newPellet);

            newPellet = new Pellets(535, 545);
            pellets.Add(newPellet);

            newPellet = new Pellets(515, 545);
            pellets.Add(newPellet);

            newPellet = new Pellets(495, 545);
            pellets.Add(newPellet);

            newPellet = new Pellets(475, 545);
            pellets.Add(newPellet);

            newPellet = new Pellets(455, 545);
            pellets.Add(newPellet);

            newPellet = new Pellets(435, 545);
            pellets.Add(newPellet);

            newPellet = new Pellets(415, 545);
            pellets.Add(newPellet);

            newPellet = new Pellets(395, 545);
            pellets.Add(newPellet);

            newPellet = new Pellets(375, 545);
            pellets.Add(newPellet);

            newPellet = new Pellets(355, 545);
            pellets.Add(newPellet);

            newPellet = new Pellets(355, 525);
            pellets.Add(newPellet);

            newPellet = new Pellets(355, 505);
            pellets.Add(newPellet);

            newPellet = new Pellets(375, 505);
            pellets.Add(newPellet);

            newPellet = new Pellets(395, 505);
            pellets.Add(newPellet);

            newPellet = new Pellets(415, 505);
            pellets.Add(newPellet);

            newPellet = new Pellets(415, 485);
            pellets.Add(newPellet);

            newPellet = new Pellets(335, 545);
            pellets.Add(newPellet);

            newPellet = new Pellets(315, 545);
            pellets.Add(newPellet);

            newPellet = new Pellets(295, 545);
            pellets.Add(newPellet);

            newPellet = new Pellets(295, 525);
            pellets.Add(newPellet);

            newPellet = new Pellets(295, 505);
            pellets.Add(newPellet);

            newPellet = new Pellets(275, 505);
            pellets.Add(newPellet);

            newPellet = new Pellets(255, 505);
            pellets.Add(newPellet);

            newPellet = new Pellets(255, 485);
            pellets.Add(newPellet);

            newPellet = new Pellets(275, 545);
            pellets.Add(newPellet);

            newPellet = new Pellets(255, 545);
            pellets.Add(newPellet);

            newPellet = new Pellets(235, 545);
            pellets.Add(newPellet);

            newPellet = new Pellets(215, 545);
            pellets.Add(newPellet);

            newPellet = new Pellets(195, 545);
            pellets.Add(newPellet);

            newPellet = new Pellets(175, 545);
            pellets.Add(newPellet);

            newPellet = new Pellets(155, 545);
            pellets.Add(newPellet);

            newPellet = new Pellets(135, 545);
            pellets.Add(newPellet);

            newPellet = new Pellets(115, 545);
            pellets.Add(newPellet);

            newPellet = new Pellets(95, 545);
            pellets.Add(newPellet);

            newPellet = new Pellets(95, 525);
            pellets.Add(newPellet);

            newPellet = new Pellets(95, 505);
            pellets.Add(newPellet);

            newPellet = new Pellets(115, 505);
            pellets.Add(newPellet);

            newPellet = new Pellets(135, 505);
            pellets.Add(newPellet);

            newPellet = new Pellets(135, 485);
            pellets.Add(newPellet);

            newPellet = new Pellets(135, 465);
            pellets.Add(newPellet);

            newPellet = new Pellets(135, 450);
            pellets.Add(newPellet);

            newPellet = new Pellets(115, 450);
            pellets.Add(newPellet);

            newPellet = new Pellets(95, 450);
            pellets.Add(newPellet);

            newPellet = new Pellets(95, 435);
            pellets.Add(newPellet);

            newPellet = new Pellets(115, 415);
            pellets.Add(newPellet);

            newPellet = new Pellets(135, 415);
            pellets.Add(newPellet);

            newPellet = new Pellets(155, 415);
            pellets.Add(newPellet);

            newPellet = new Pellets(175, 415);
            pellets.Add(newPellet);

            newPellet = new Pellets(215, 415);
            pellets.Add(newPellet);

            newPellet = new Pellets(235, 415);
            pellets.Add(newPellet);

            newPellet = new Pellets(255, 415);
            pellets.Add(newPellet);

            newPellet = new Pellets(275, 415);
            pellets.Add(newPellet);

            newPellet = new Pellets(295, 415);
            pellets.Add(newPellet);

            newPellet = new Pellets(295, 435);
            pellets.Add(newPellet);

            newPellet = new Pellets(295, 445);
            pellets.Add(newPellet);

            newPellet = new Pellets(195, 505);
            pellets.Add(newPellet);

            newPellet = new Pellets(175, 505);
            pellets.Add(newPellet);

            newPellet = new Pellets(155, 505);
            pellets.Add(newPellet);

            newPellet = new Pellets(195, 485);
            pellets.Add(newPellet);

            newPellet = new Pellets(195, 465);
            pellets.Add(newPellet);

            newPellet = new Pellets(470, 180);
            pellets.Add(newPellet);

            newPellet = new Pellets(470, 195);
            pellets.Add(newPellet);

            newPellet = new Pellets(470, 215);
            pellets.Add(newPellet);

            newPellet = new Pellets(470, 235);
            pellets.Add(newPellet);

            newPellet = new Pellets(470, 255);
            pellets.Add(newPellet);

            newPellet = new Pellets(470, 275);
            pellets.Add(newPellet);

            newPellet = new Pellets(470, 295);
            pellets.Add(newPellet);

            newPellet = new Pellets(470, 315);
            pellets.Add(newPellet);

            newPellet = new Pellets(470, 335);
            pellets.Add(newPellet);

            newPellet = new Pellets(470, 355);
            pellets.Add(newPellet);

            newPellet = new Pellets(470, 375);
            pellets.Add(newPellet);

            newPellet = new Pellets(470, 395);
            pellets.Add(newPellet);

        }

        public void spawnPowerPellets() //method for spawning power pellets, draws them then add to the list
        {
            PowerPellet newPowerPellet = new PowerPellet(570, 410);
            powerPellet.Add(newPowerPellet);

            newPowerPellet = new PowerPellet(90, 410);
            powerPellet.Add(newPowerPellet);

            newPowerPellet = new PowerPellet(90, 165);
            powerPellet.Add(newPowerPellet);

            newPowerPellet = new PowerPellet(570, 165);
            powerPellet.Add(newPowerPellet);
        }


        private async void gameEngine_Tick(object sender, EventArgs e)
        {
            hero.prevX = hero.x; //collision
            hero.prevY = hero.y;
            ghost.prevX = ghost.x;
            ghost.prevY = ghost.y;

            if (upDown) //movement for ghost using arrow keys
            {
                ghost.direction = "upp";
            }
            if (downDown && ghost.y < this.Height - hero.size)
            {
                ghost.direction = "downn";
            }
            if (leftDown && ghost.x > 0)
            {
                ghost.direction = "leftt";
            }

            if (rightDown && ghost.x < this.Width - ghost.size)
            {
                ghost.direction = "rightt";
            }

            ghost.Move();

            if (wDown) //movement for hero using wasd
            {
                hero.direction = "up";
            }

            if (sDown && hero.y < this.Height - hero.size)
            {
                hero.direction = "down";
            }

            if (aDown && hero.x > 0)
            {
                hero.direction = "left";
            }

            if (dDown && hero.x < this.Width - hero.size)
            {
                hero.direction = "right";
            }

            hero.Move();

            foreach (wall wall in walls) //foreach loop for collision with the walls
            {
                if (hero.Collision(wall))
                {
                    hero.x = hero.prevX;
                    hero.y = hero.prevY;

                }
                if (ghost.Collision(wall))
                {
                    ghost.x = ghost.prevX;
                    ghost.y = ghost.prevY;
                }
            }

            foreach (Pellets pellet in pellets) //foreach loop for collision with pellets
            {
                if (hero.Collision(pellet))
                {
                    points++;
                    pellets.Remove(pellet);
                    break;
                }
            }

            if (hero.Collision(ghost)) //when player collides with the ghost, lose a life and spawn both back to starting point
            {
                if (powered == true)
                {
                    ghostEatSound.Play(); //play ghosteat sound
                    ghost.x = 317;
                    ghost.y = 280;
                    powered = false;
                    await Task.Delay(1000); //delay to wait full ghosteat sound
                    moveSound.PlayLooping(); //start the move again in a loop
                }
                else if (powered == false)
                {
                    hero.x = hero.prevX;
                    hero.y = hero.prevY;
                    lives--;
                    ghost.x = 317;
                    ghost.y = 280;
                    hero.x = 317;
                    hero.y = 455;
                }
            }
            foreach (PowerPellet powpellet in powerPellet)
            {
                if (hero.Collision(powpellet))
                {
                    powered = true;
                    PoweredTimer();
                    RespawnPowPellet(powpellet);



                    break;
                }
            }
            pointLabel.Text = $"Points: {points}"; //label to show how close you are to winning
            livesLabel.Text = $"Lives: {lives}"; //label for how many lives you have
            if (hero.x <= 10) //teleportation on edge of map, if you walk of one side end up on other
            {
                hero.x = 575;
            }
            else if (hero.x >= 600)
            {
                hero.x = 25;
            }
            if(ghost.x <= 10) //teleportation for ghost
            {
                ghost.x = 575;
            }
            else if(ghost.x >= 600)
            {
                ghost.x = 25;
            }

            if (points == 199) //win method called if all pellets are collected
            {
                gameEngine.Stop();
                winGame();
            }
            if (lives == 0) //lose method called if all lives are lost
            {
                moveSound.Stop();
                deathSound.Play(); //play death sound
                gameEngine.Stop();
                GameOver();
            }
            Refresh();

        }

        private async void PoweredTimer() //method for how long the powered phase lasts
        {
           await Task.Delay(10000);
           powered = false;
        }
        private async void RespawnPowPellet(PowerPellet powPellet) //respawn the pellets after being taken, teleporting them off screen rather than deleting them
        {
            int tempX, tempY;
            tempX = powPellet.x;
            tempY = powPellet.y;
            powPellet.x = 600;
            powPellet.y = 600;
            await Task.Delay(45000);
            powPellet.x = tempX;
            powPellet.y = tempY;
        }
        private void GameScreen_Paint(object sender, PaintEventArgs e) //paint method
        {
            if(powered == true) //change colour when power pellet grabbed
            {
                e.Graphics.FillRectangle(blueBrush, ghost.x, ghost.y, ghost.size, ghost.size);
            }
            else
            {
            e.Graphics.FillRectangle(redBrush, ghost.x, ghost.y, ghost.size, ghost.size); //draw ghost
            }
            e.Graphics.FillEllipse(yellowBrush, hero.x, hero.y, hero.size, hero.size); //draw hero

            foreach (wall w in walls) //foreach loop to paint each wall
            {
                e.Graphics.FillRectangle(blueBrush, w.x, w.y, w.width, w.height);
            }
            foreach (Pellets p in pellets) //foreach loop to paint each pellet
            {
                e.Graphics.FillRectangle(whiteBrush, p.x, p.y, p.size, p.size);
            }
            foreach (PowerPellet po in powerPellet) //foreach loop to pain each power pellet
            {
                e.Graphics.FillRectangle(yellowBrush, po.x, po.y, po.size, po.size);
            }
        }
        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) //hero & ghost movement switch statement
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.Up:
                    upDown = true;
                    break;
                case Keys.Right:
                    rightDown = true;
                    break;
                case Keys.Left:
                    leftDown = true;
                    break;
                case Keys.Down:
                    downDown = true;
                    break;


            }
        }
        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.Up:
                    upDown = false;
                    break;
                case Keys.Right:
                    rightDown = false;
                    break;
                case Keys.Left:
                    leftDown = false;
                    break;
                case Keys.Down:
                    downDown = false;
                    break;

            }
        }

        public void winGame() //open winscreen
        {
            Form1.ChangeScreen(this, new WinScreen());

        }

        public void GameOver() //open gameoverscreen
        {
            Form1.ChangeScreen(this, new GameOverScreen());
        }


    }
}
