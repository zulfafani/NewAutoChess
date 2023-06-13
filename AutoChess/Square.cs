using System;
using System.Collections.Generic;
using AutoChess;

namespace AutoChess
{
    public class Square
    {
        private int _row;
        private int _col;

        public Square(int row, int col)
        {
            _row = row;
            _col = col;
        }
        public int GetRow()
        {
            return _row;
        }
        public int GetCol()
        {
            return _col;
        }
        public bool IsEmpty()
        {
            return _row == 0 && _col == 0; // Modify the condition based on your definition of an empty square
        }
    }
}
