using System;
using System.Numerics;
using AutoChess;

namespace AutoChess
{
    public class Program
    {
        public static void Main()
        {
            GameManager gameManager = new GameManager();

            //Invite Players
            Console.Write("Enter player name: ");
            string playerName = Console.ReadLine();
            IPlayer player1 = new Player(playerName);
            IPlayer player2 = new Player("Random Player");
            gameManager.InvitePlayer(player1);
            gameManager.InvitePlayer(player2);

            //Show current players
            Console.WriteLine("--Current Players--");
            Console.WriteLine();
            gameManager.CurrentPlayersInfo();

            //Add Unit player1
            Console.WriteLine("Available Race: Beast, Human, Goblin, Dragon, Dwarf");
            Console.WriteLine("Enter Race for Units:");
            string raceInput1 = Console.ReadLine();
            Enum.TryParse(raceInput1, out Race race1);
            //Add Unit player2
            Random random = new Random();
            Race race2 = (Race)random.Next(Enum.GetValues(typeof(Race)).Length);

            //Show current Players with Units
            IUnit unit1 = new Unit(race1);
            IUnit unit2 = new Unit(race2);
            gameManager.AddUnit(player1, unit1);
            gameManager.AddUnit(player2, unit2);
            gameManager.DisplayAllUnitsInfo();

            //gameManager.StartGame();

            //Add location of Units on Board belum exeption handling
            Console.WriteLine("Place a unit on the board");
            Console.WriteLine($"Enter location of unit on the board: ");
            Console.Write("Enter row: ");
            string inputRow = Console.ReadLine();
            int numberRow = int.Parse(inputRow);
            Console.Write("Enter column: ");
            string inputCol = Console.ReadLine();
            int numberCol = int.Parse(inputCol);

            Square square1 = new Square(numberRow, numberCol);
            Square square2 = new Square(8, 5);

            gameManager.AddUnitUpdate(player1, unit1, square1);
            gameManager.AddUnitUpdate(player2, unit2, square2);

            //gameManager.DisplayBoardUpdate();


        }
    }
}