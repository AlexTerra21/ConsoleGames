using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGameLib;

namespace PingPong
{
    class Ball : GameObject
    {
        enum eDir { STOP = 0, LEFTUP, LEFT, LEFTDOWN, RIGHTUP, RIGHT, RIGHTDOWN }

        private int _x;
        public int X { get { return _x; } set { _x = value; } }
        private int _y;
        public int Y { get { return _y; } set { _y = value; } }

        private eDir _direction; 

    }
}
