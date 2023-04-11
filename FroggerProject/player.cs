using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FroggerProject
{
    internal class player
    {
        //declare all variables
        public int x, y, width, height;
        public int speed = 5;
        public int size = 20;
        public int prevX, prevY;
        public string direction = "";

        public player(int _x, int _y)
        {
            x = _x;
            y = _y;
           

        }
        public void Move() //move method
        {
            if (direction == "up")
            {
                y -= speed;
            }
            if (direction == "down")
            {
                y += speed;
            }
            if (direction == "left")
            {
                x -= speed;
            }
            if (direction == "right")
            {
                x += speed;
            }
        }

       

        public bool Collision(wall walls) //collision with walls, using bool
        {
            Rectangle playerRec = new Rectangle(x, y, size, size);
            Rectangle wallRec = new Rectangle(walls.x, walls.y, walls.width, walls.height);


            if (playerRec.IntersectsWith(wallRec))
            {
                return true;
            }
            else
            {

                return false;

            }

        }
            public bool Collision(Pellets pellet) //collision with pellets, bool
            {
                Rectangle playerRec = new Rectangle(x, y, size, size);
                Rectangle pelletRec = new Rectangle(pellet.x, pellet.y, pellet.width, pellet.height);

            if (playerRec.IntersectsWith(pelletRec))
            {
                return true;
            }
            else
            {
                return false;
            }
            }
        public bool Collision(Ghost ghost) //collision with ghosts, bool
        {
            Rectangle playerRec = new Rectangle(x, y, size, size);
            Rectangle ghostRec = new Rectangle(ghost.x, ghost.y, ghost.size, ghost.size);

            if (playerRec.IntersectsWith(ghostRec))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Collision(PowerPellet powerpellet) //collision with power pellets, bool
        {
            Rectangle playerRec = new Rectangle(x, y, size, size);
            Rectangle powerpelletRec = new Rectangle(powerpellet.x, powerpellet.y, powerpellet.width, powerpellet.height);

            if (playerRec.IntersectsWith(powerpelletRec))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
