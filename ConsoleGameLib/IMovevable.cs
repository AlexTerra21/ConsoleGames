using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameLib
{
    public interface IMovable
    {
        void DirectionLeft();
        void DirectionRight();
        void DirectionUp();
        void DirectionDown();
        void Move();
    }
}
