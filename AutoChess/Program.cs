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
            Player player1 = new Player(playerName);
            Player player2 = new Player("Random Player");
            gameManager.InvitePlayer(player1);
            gameManager.InvitePlayer(player2);

            //Show current players
            Console.WriteLine("--Current Players--");
            Console.WriteLine();
            gameManager.CurrentPlayersInfo();

            //Add Unit
            Console.WriteLine("Enter unit type and location on the board");
            Console.WriteLine("Available unit types: Beast, Human, Goblin, Dragon, Dwarf");
            Console.WriteLine("Enter unit type:");
            string raceInput1 = Console.ReadLine();
            Enum.TryParse(raceInput1, out Race race1);

            Random random = new Random();
            Race race2 = (Race)random.Next(Enum.GetValues(typeof(Race)).Length);

            Unit unit1 = new Unit(race1);
            Unit unit2 = new Unit(race2);

            Console.WriteLine();
            //unit1.ShowUnitInfo();
            Console.WriteLine();
            //unit2.ShowUnitInfo();

            //gameManager.StartGame();





        }
    }
}