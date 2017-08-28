using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameLib
{
    public abstract class GameObject
    {
        protected GameField _gameField;

        public GameObject ()
        {

        }

        public void SetField(GameField aGameField)
        {
            _gameField = aGameField;
        }

        public virtual void Move()
        {

        }

        public virtual void Draw()
        {

        }

    }
}
