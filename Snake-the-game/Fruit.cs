using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGameLib;

namespace Snake
{
    class Fruit : GameObject
    {
        private int _x;
        public int X { get { return _x; } }
        private int _y;
        public int Y { get { return _y; } }

        public Fruit(int aX, int aY) : base()
        {
            _x = aX;
            _y = aY;
        }

        public void ResetPosition(int aX, int aY)
        {
            _x = aX;
            _y = aY;
        }
        public override void Draw()
        {
            _gameField.Field[_y][_x].Val = "$";
            _gameField.Field[_y][_x].Color = ConsoleColor.Yellow;
        }

    }

}
