using System;
using System.Collections.Generic;
using AutoChess;

namespace AutoChess
{
    public class GameManager
    {

        private Player _players;
        private Board _board;
        private List<IUnit> _units;

        public GameManager()
        {
            _board = new Board();
            _units = new List<IUnit>();
        }

        private Board chessBoard;

        public void RunGame()
        {
            Console.WriteLine("Auto Chess Game");

            while (true)
            {
                Console.WriteLine("1. Place a unit on the board");
                Console.WriteLine("2. Remove a unit from the board");
                Console.WriteLine("3. Print the board");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                int choice;
                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1:

                        _board.PlaceUnitOnSquare();
                        break;
                    case 2:
                        _board.RemoveUnitFromSquare();
                        break;
                    case 3:
                        PrintBoard();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

        private void PrintBoard()
        {
            Console.WriteLine("Auto Chess Board:");

            for (int row = 1; row <= 8; row++)
            {
                for (int col = 1; col <= 8; col++)
                {
                    Square square = new Square(row, col);


                    if (_board.GetBoard().ContainsKey(square))
                    {
                        Unit unit = _board.GetBoard()[square];

                        Console.Write($"{unit.Name} ");
                    }
                    else
                    {

                        Console.Write("|__|");

                        Console.Write("Empty ");

                    }
                }

                Console.WriteLine();
            }

        }

        void CreateUnit()
        {
            // Create a unit
            IUnit unit = new Unit("Knight", 100, 20, 10);

            // Add the unit to the list
            _units.Add(unit);

            // Display unit status
            unit.ShowProfileInfo();
        }
    }
}
