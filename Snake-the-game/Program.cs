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

            //Console.WindowLeft = Console.WindowTop = 0;
            //Console.WindowHeight = Console.BufferHeight = Console.LargestWindowHeight;
            //Console.WindowWidth = Console.BufferWidth = Console.LargestWindowWidth;
            


            //Console.WindowLeft = Console.WindowTop = 0;
            //Console.WindowHeight = Console.BufferHeight = 40;
            //Console.WindowWidth = Console.BufferWidth = 70;

            SnakeGame Game = new SnakeGame(40, 20);
            Game.Run(100);
        }
    }
}
