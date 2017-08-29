using System;
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
            PingPongGame Game = new PingPongGame(50, 30);
            Game.Run(0);
        }
    }
}
