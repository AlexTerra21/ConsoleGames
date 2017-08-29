using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            SnakeGame Game = new SnakeGame(40, 20);
            Game.Run(100);
            Console.ReadLine();
        }
    }
}
