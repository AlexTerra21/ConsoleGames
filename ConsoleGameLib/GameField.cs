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
            Console.SetWindowSize(Width + 2, Height + 4);
            Console.SetBufferSize(Width + 2, Height + 4);
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
                for (int j = 0; j < Width; j++)
                {
                    _field[i][j].Val = " ";
                    _field[i][j].Color = ConsoleColor.White;
                }
            }
        }

        public void DrawFrame()
        {
            Console.CursorVisible = false;
            Console.ForegroundColor = FrameColor;
            for (int i = 0; i < Width + 2; i++)
                for (int j = 0; j < Height + 2; j++)
                {
                    if ((j == 0 || j == Height + 1) || (i == 0 || i == Width + 1))
                    {
                        Console.SetCursorPosition(i, j);
                        Console.Write(FrameSymbol);
                    }
                }
        }

        public void PrintScore(string aScore)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(Width/2 - aScore.Length /2,Height+2);
            Console.Write(aScore);
        }

        public void PrinGameOver()
        {
            string lGameOverMessage = "GAME OVER!";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(Width / 2 - lGameOverMessage.Length / 2, Height / 2);
            Console.Write(lGameOverMessage);
        }

        public void Draw()
        {
            Console.CursorVisible = false;
            for (int i = 0; i < Width; i++)
                for (int j = 0; j < Height; j++)
                {
                    Console.ForegroundColor = _field[j][i].Color;
                    Console.SetCursorPosition(i + 1, j + 1);
                    Console.Write(_field[j][i].Val);
                }
        }
    }
}
