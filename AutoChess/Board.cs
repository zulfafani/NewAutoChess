using System;
using System.Collections.Generic;
using System.Data.Common;
using AutoChess;

namespace AutoChess
{
    public class Board
    {
        private Dictionary<Square, IUnit> _board;

        public Board()
        {
            _board = new Dictionary<Square, IUnit>();
        }

        public void AddUnit(Square square, IUnit unit)
        {
            _board[square] = unit;
        }

        public void RemoveUnit(Square square)
        {
            if (_board.ContainsKey(square))
            {
                _board.Remove(square);
            }
        }

        public void MoveUnit(Square sourceSquare, Square targetSquare)
        {
            if (_board.ContainsKey(sourceSquare))
            {
                IUnit unit = _board[sourceSquare];
                _board.Remove(sourceSquare);
                _board[targetSquare] = unit;
            }
        }

        public void DisplayBoard()
        {
            Console.WriteLine("AutoChess Board:");

            for (int row = 1; row <= 8; row++)
            {
                for (int col = 1; col <= 8; col++)
                {
                    Square square = new Square(col, row);

                    if (_board.ContainsKey(square))
                    {
                        IUnit unit = _board[square];
                        //Console.Write(value: $"[{unit.Race}-{unit.Class}] ");
                    }
                    else
                    {
                        Console.Write("[  ] ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
