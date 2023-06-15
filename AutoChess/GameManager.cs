using System;
using System.Collections.Generic;
using AutoChess;

namespace AutoChess
{
    public class GameManager
    {
        private List<IPlayer> _players;
        private Dictionary<Square, List<IUnit>> _board;
        private Dictionary<IPlayer, List<IUnit>> _units;

        public GameManager()
        {
            _players = new List<IPlayer>();
            _board = new Dictionary<Square, List<IUnit>>();
            _units = new Dictionary<IPlayer, List<IUnit>>();
        }

        public void StartGame()
        {
            Console.WriteLine("Welcome to AutoChess Game!");
            //Display Board
            for (int row = 1; row <= 8; row++)
            {
                for (int col = 1; col <= 8; col++)
                {
                    Console.Write("[   ]");
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
        public void AddUnit(IPlayer player, IUnit unit)
        {
            if (!_units.ContainsKey(player))
            {
                _units[player] = new List<IUnit>();
            }
            _units[player].Add(unit);
        }
        public void DisplayAllUnitsInfo()
        {
            foreach (var player in _units.Keys)
            {
                player.ShowPlayerInfo();
                Console.WriteLine("Units:");

                foreach (var unit in _units[player])
                {
                    unit.ShowUnitInfo();
                    Console.WriteLine();
                }
            }
        }

        public void AddUnitUpdate(IPlayer player, IUnit unit, Square square)
        {
            if (!_board.ContainsKey(square))
                _board[square] = new List<IUnit>();

            _units[player].Add(unit);
            _board[square].Add(unit);
        }
        public void RemoveUnitUpdate(IPlayer player, IUnit unit, Square square)
        {
            if (_board.ContainsKey(square))
            {
                _board[square].Remove(unit);
                _units[player].Remove(unit);
            }
        }
        public void DisplayBoardUpdate()
        {
            Console.WriteLine("AutoChess Board:");

            for (int row = 1; row <= 8; row++)
            {
                for (int col = 1; col <= 8; col++)
                {
                    if (AddUnitUpdate != null)
                    {
                        Console.Write("[Player1]");
                    }
                    else
                    {
                        Console.Write("[   ]");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}