using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGameLib;

namespace PingPong
{
    class PingPongGame : GameManager
    {
        private Paddle _player1;
        private Paddle _player2;
        private Ball _ball;
        public PingPongGame(int aWidth, int aHeight) : base (aWidth,aHeight)
        {
            _gameField.FrameColor = ConsoleColor.DarkRed;
            _gameField.FrameSymbol = '█';
            _gameField.DrawFrame();
            _player1 = new Paddle(1, aHeight / 2);
            _player1.SetField(_gameField);
            _player2 = new Paddle(aWidth - 2, aHeight / 2);
            _player2.SetField(_gameField);
            _ball = new Ball(aWidth / 2, aHeight / 2);
            _ball.SetField(_gameField);
        }

        protected override bool Input()
        {
            switch (ConsoleGetKey())
            {
                case ConsoleKey.W:
                    _player1.DirectionUp();
                    break;
                case ConsoleKey.S:
                    _player1.DirectionDown();
                    break;
                case ConsoleKey.UpArrow:
                    _player2.DirectionUp();
                    break;
                case ConsoleKey.DownArrow:
                    _player2.DirectionDown();
                    break;
                case ConsoleKey.Spacebar:
                    _ball.SetDirection((Ball.Direction)_rand.Next(1,7));
                    break;
                case ConsoleKey.Q:
                    return true;
                default:
                    break;
            }
            return false;
        }

        protected override bool Logic()
        {
            _gameField.ClearField();

            if (_ball.Y == 0) 
            {
                if (_ball.Dir == Ball.Direction.LeftUp) _ball.SetDirection(Ball.Direction.LeftDown);
                else _ball.SetDirection(Ball.Direction.RightDown);
            }

            if (_ball.Y == _gameField.Height-1)
            {
                if (_ball.Dir == Ball.Direction.LeftDown) _ball.SetDirection(Ball.Direction.LeftUp);
                else _ball.SetDirection(Ball.Direction.RightUp);
            }

            if (_ball.X == 2)
            {
                if (_ball.Y > _player1.Y - 3 && _ball.Y < _player1.Y + 3)
                {
                    _ball.SetDirection((Ball.Direction)_rand.Next(4, 7));
                }
            }

            if (_ball.X == _gameField.Width - 3)
            {
                if (_ball.Y > _player2.Y - 3 && _ball.Y < _player2.Y + 3)
                {
                    _ball.SetDirection((Ball.Direction)_rand.Next(1, 4));
                }
            }

            if (_ball.X == 0 || _ball.X == _gameField.Width-1) 
            {
                _player1.ResetPosition(1, _gameField.Height / 2);
                _player2.ResetPosition(_gameField.Width - 2, _gameField.Height / 2);
                _ball.ResetPosition(_gameField.Width / 2, _gameField.Height / 2);
            }
            _player1.Move();
            _player2.Move();
            _ball.Move();
            return false;
        }

        protected override void Draw()
        {
            _player1.Draw();
            _player2.Draw();
            _ball.Draw();
            base.Draw();
        }

    }
}
