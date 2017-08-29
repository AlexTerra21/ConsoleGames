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
        enum eDir {  }

        public enum Direction { Stop = 0, LeftUp, Left, LeftDown, RightUp, Right, RightDown }
        private Direction _dir = Direction.Stop;
        public Direction Dir { get { return _dir; } }
        private int _x;
        public int X { get { return _x; } }
        private int _y;
        public int Y { get { return _y; } }

        public Ball(int aX, int aY)
            : base()
        {
            _x = aX;
            _y = aY;
        }

        public void SetDirection(Direction aDir)
        {
            _dir = aDir;
        }

        public override void Move()
        {

            switch (_dir)
            {
                case Direction.Stop:
                    break;
                case Direction.RightUp:
                    _y--; _x++;
                    break;
                case Direction.Right:
                    _x++;
                    break;
                case Direction.RightDown:
                    _y++;_x++;
                    break;
                case Direction.LeftUp:
                    _y--;_x--;
                    break;
                case Direction.Left:
                    _x--;
                    break;
                case Direction.LeftDown:
                    _y++;_x--;
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
            _gameField.Field[_y][_x].Val = ((char)9787).ToString();
            _gameField.Field[_y][_x].Color = ConsoleColor.Cyan;
        }
    

    }
}
