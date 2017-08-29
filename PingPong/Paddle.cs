using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGameLib;

namespace PingPong
{
    class Paddle : GameObject
    {
        private enum Direction { Stop = 0, Up, Down }
        private Direction _dir = Direction.Stop;
        private int _x;
        public int X { get { return _x; } }
        private int _y;
        public int Y { get { return _y; } }

        public Paddle(int aX, int aY)
            : base()
        {
            _x = aX;
            _y = aY;
        }

        public void DirectionUp()
        {
            _dir = Direction.Up;
        }

        public void DirectionDown()
        {
            _dir = Direction.Down;
        }

        public override void Move()
        {
            
            switch (_dir)
            {
                case Direction.Up:
                    if (_y > 2)_y--;
                    break;
                case Direction.Down:
                     if (_y < _gameField.Height-3)_y++;
                    break;
                default:
                    break;
            }
        }

        public void ResetPosition(int aX, int aY)
        {
            _x = aX;
            _y = aY;
            _dir = Direction.Stop;

        }
        public override void Draw()
        {
            for (int i = _y-2; i < _y+3; i++)
            {
                _gameField.Field[i][_x].Val = "▓";
                _gameField.Field[i][_x].Color = ConsoleColor.Yellow;
            }
            
        }
    }
}
