using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace FroggerProject
{
    internal class Pellets
    {
        public int x, y, width, height;
        public int size = 5;
        public Pellets(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        
    }
}
