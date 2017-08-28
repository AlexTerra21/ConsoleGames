using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameLib
{
    abstract class Game 
    {
        private Random _rand = new Random(); 
        private GameField _gameField;
        private bool _gameOver; 

        public Game(int aWidth, int aHeight)
        {
            _gameField = new GameField(aWidth, aHeight);
            _gameOver = false;
        }

        private ConsoleKey ConsoleGetKey()
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
            _gameField.ClearField();
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
                _gameOver = Logic();
                Draw();
                System.Threading.Thread.Sleep(aDelay);
            }
        }
    }

    
}
