using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGameLib;

namespace Snake
{
    class Snake : GameObject
    {
        private enum Direction { Stop = 0, Left, Right, Up, Down }
        private Direction Dir = Direction.Stop;
        public Point Head { get; set; }
        private List<Point> _tail = new List<Point>();
        public List<Point> Tail
        {
            get { return _tail; }
        }

        public Snake(int aStartX, int aStartY) : base()
        {
            Head = new Point(aStartX, aStartY);
        }

       
        public void Eat()
        {
            _tail.Insert(0,new Point(Head.X,Head.Y));
        }



        public void DirectionLeft()
        {
            Dir = Direction.Left;
        }

        public void DirectionRight()
        {
            Dir = Direction.Right;
        }

        public void DirectionUp()
        {
            Dir = Direction.Up;
        }

        public void DirectionDown()
        {
            Dir = Direction.Down;
        }

        public override void Move()
        {
            _tail.Insert(0, new Point(Head.X, Head.Y));
            _tail.RemoveAt(_tail.Count - 1);
            switch (Dir)
            {
                case Direction.Left:
                    Head.X--;
                    break;
                case Direction.Right:
                    Head.X++;
                    break;
                case Direction.Up:
                    Head.Y--;
                    break;
                case Direction.Down:
                    Head.Y++;
                    break;
                default:
                    break;
            }
        }

        public override void Draw()
        {
            _gameField.Field[Head.Y][Head.X].Val = "O";
            _gameField.Field[Head.Y][Head.X].Color = ConsoleColor.Green;
            foreach (Point t in Tail)
            {
                _gameField.Field[t.Y][t.X].Val = "o";
                _gameField.Field[t.Y][t.X].Color = ConsoleColor.Green;
            }
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int aX, int aY)
        {
            X = aX;
            Y = aY;
        }
    }


}
