using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FroggerProject
{
    internal class Ghost
    {

        public int x, y;
        public int speed = 6;
        public int size = 20;
        public int prevX, prevY;
        public string direction = "";

        public Ghost(int _x, int _y)
        {
            x = _x;
            y = _y;


        }
        public void Move()
        {
            if (direction == "upp")
            {
                y -= speed;
            }
            if (direction == "downn")
            {
                y += speed;
            }
            if (direction == "leftt")
            {
                x -= speed;
            }
            if (direction == "rightt")
            {
                x += speed;
            }
        }



        public bool Collision(wall walls)
        {
            Rectangle ghostRec = new Rectangle(x, y, size, size);
            Rectangle wallRec = new Rectangle(walls.x, walls.y, walls.width, walls.height);


            if (ghostRec.IntersectsWith(wallRec))
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
