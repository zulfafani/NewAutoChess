using System;
using System.Collections.Generic;
using System.Data.Common;
using AutoChess;

namespace AutoChess
{
    public class Board
    {
        private Dictionary<Square, Unit> _square;

        public Board()
        {
            _square = new Dictionary<Square, Unit>();
        }

        public Square GetSquare()
        {
            Console.Write("Enter the row of the square: ");
            int row;
            int.TryParse(Console.ReadLine(), out row);

            Console.Write("Enter the column of the square: ");
            int column;
            int.TryParse(Console.ReadLine(), out column);

            Square square = new Square(row, column);

            return square;
        }

        public void PlaceUnitOnSquare()
        {
            Console.WriteLine("Enter unit type and location (row, column) on the board:");
            Console.WriteLine("Available unit types: Rook, Knight, Bishop, Queen, King, Pawn");
            Console.WriteLine("Enter 'exit' to finish.");

            while (true)
            {
                Console.Write("Unit type: ");
                string unitType2 = Console.ReadLine();

                if (unitType2 == "exit")
                {
                    break;
                }

                Square square = GetSquare();

                Console.Write("Unit ID: ");
                string unitId = Console.ReadLine();

                int unitLevel;
                do
                {
                    Console.Write("Unit Level: ");
                } while (!int.TryParse(Console.ReadLine(), out unitLevel));

                int unitExp;
                do
                {
                    Console.Write("Unit Exp: ");
                } while (!int.TryParse(Console.ReadLine(), out unitExp));

                Unit unit = new Unit(unitId, unitType, unitLevel, unitExp);

                _square[square] = unit;
            }
        }

        public void RemoveUnitFromSquare()
        {
            Square square = GetSquare();

            if (_square.ContainsKey(square))
            {
                _square.Remove(square);
                Console.WriteLine("Unit removed from the square.");
            }
            else
            {
                Console.WriteLine("No unit found at the specified square.");
            }
        }

        public Unit GetUnitFromSquare(Square square)
        {
            if (_square.ContainsKey(square))
            {
                return _square[square];
            }
            else
            {
                return null;
            }
        }

        public Dictionary<Square, Unit> GetBoard()
        {
            return _square;
        }
    }
}
