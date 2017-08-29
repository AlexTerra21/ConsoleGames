using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameLib
{
    public abstract class GameManager 
    {
        protected Random _rand = new Random(); 
        protected GameField _gameField;
        protected bool _gameOver; 

        public GameManager(int aWidth, int aHeight)
        {
            _gameField = new GameField(aWidth, aHeight);
            _gameOver = false;
        }

        protected ConsoleKey ConsoleGetKey()
        {
            ConsoleKeyInfo lKey = new ConsoleKeyInfo();
            if (Console.KeyAvailable)
            {
                lKey = Console.ReadKey(true);
            }
            return lKey.Key;
        }

        protected virtual bool Input()
        {
            switch (ConsoleGetKey())
            {
                case ConsoleKey.LeftArrow:
                    break;
                case ConsoleKey.RightArrow:
                    break;
                case ConsoleKey.UpArrow:
                    break;
                case ConsoleKey.DownArrow:
                    break;
                case ConsoleKey.Q:
                    return true;
                default:
                    break;
            }
            return false;
        }

        protected virtual bool Logic()
        {
            return false;
        }


        protected virtual void Draw()
        {
            _gameField.Draw();
        }

        public void Run(int aDelay)
        {
            while (!_gameOver)
            {
                _gameOver = Input();
                if (_gameOver) continue;
                _gameOver = Logic();
                Draw();
                System.Threading.Thread.Sleep(aDelay);
            }
        }
    }

    
}
