﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{
    class Program
    {
        static void Main(string[] args)
        {
            PingPongGame Game = new PingPongGame(57, 21);
            Game.Run(0);
            Console.ReadLine();
        }
    }
}
