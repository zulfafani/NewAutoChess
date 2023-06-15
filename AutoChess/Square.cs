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
    }
}
