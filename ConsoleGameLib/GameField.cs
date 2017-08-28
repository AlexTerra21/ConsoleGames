using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameLib
{
    public class GameField
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public ConsoleColor FrameColor { get; set; }
        public char FrameSymbol { get; set; }

        private List<List<Cell>> _field  = new List<List<Cell>>();
        public List<List<Cell>> Field
        {
            get { return _field; }
        }
        public GameField(int aWidth, int aHeight)
        {
            Width = aWidth;
            Height = aHeight;
            FrameColor = ConsoleColor.White;
            FrameSymbol = '#';
            InitField();
        }

        private void InitField()
        {
            for (int i = 0; i < Height; i++)
            {
                List<Cell> lRow = new List<Cell>();
                for (int j = 0; j < Width; j++)
                {
                    Cell lCell = new Cell(" ", ConsoleColor.White);
                    lRow.Add(lCell);
                }
                _field.Add(lRow);
            }
        }

        public void ClearField()
        {
            for (int i = 0; i < Height; i++)
            {
                //List<string> lRow = new List<string>();
                for (int j = 0; j < Width; j++)
                {
                    _field[i][j].Val = " ";
                    _field[i][j].Color = ConsoleColor.White;
                }
            }
        }

        public void Draw()
        {
            Console.Clear();
            Console.CursorVisible = false;
            Console.ForegroundColor = FrameColor;
            for (int i = 0; i < Width + 2; i++)
            {
                Console.Write(FrameSymbol);
            }
            Console.WriteLine();
            //Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width + 2; j++)
                {
                    if (j == 0 || j == Width + 1)
                    {
                        Console.ForegroundColor = FrameColor;
                        Console.Write(FrameSymbol);
                        //Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = _field[i][j - 1].Color;
                        Console.Write(_field[i][j - 1].Val);
                    }
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = FrameColor;
            for (int i = 0; i < Width + 2; i++)
            {
                Console.Write(FrameSymbol);
            }
            Console.WriteLine();
            //Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
