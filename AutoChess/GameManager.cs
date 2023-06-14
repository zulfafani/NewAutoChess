using System;
using System.Collections.Generic;
using AutoChess;

namespace AutoChess
{
    public class GameManager
    {
        private List<IPlayer> _players; //implemented
        private Board _board;
        private List<IUnit> _units;

        public GameManager()
        {
            _players = new List<IPlayer>(); //implemented
            _board = new Board();
            _units = new List<IUnit>();
        }

        public void StartGame()
        {
            Console.WriteLine("Welcome to AutoChess Game!");

            //Display Board
            PrintBoard();

            

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

                        //Console.Write($"{unit.Name} ");
                    }
                    else
                    {

                        Console.Write("[  ]");

                    }
                }

                Console.WriteLine();
            }

        }

        public void InvitePlayer(IPlayer player)
        {
            _players.Add(player);
        }

        public void CurrentPlayersInfo()
        {
            foreach (IPlayer player in _players)
            {
                player.ShowPlayerInfo();
                Console.WriteLine();
            }
        }

        public void AddUnit(IUnit unit)
        {
            _units.Add(unit);
        }
        public void DisplayAllUnitsInfo()
        {
            foreach (var unit in _units)
            {
                unit.ShowUnitInfo();
                Console.WriteLine();
            }
        }

    }
}
