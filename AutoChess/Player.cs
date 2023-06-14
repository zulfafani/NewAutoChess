using System;
using System.Collections.Generic;
using AutoChess;

namespace AutoChess
{
    public class Player : IPoint, IPlayer, IGold, ILevel
    {
        //Player
        private string _id;
        private string _name;
        private int _point;
        private int _gold;
        private int _level;
        private int _exp;

        //Point
        public event Action<int> PointModified;
        public int startingPoint { get; set; }
        public int endPoint { get; set; }

        //Gold
        public event Action<int> GoldModified;
        public int startingGold { get; set; }
        public int maxGold { get; set; }

        //Level
        public event Action<int> LevelModified;
        int startingLevel { get; set; }
        int maxLevel { get; set; }

        public Player(string name)
        {
            _id = GenerateRandomId();
            _name = name;
            _point = 100;
            _gold = 1;
            _level = 1;
            _exp = 0;
        }

        void IPoint.ModifyPoint(int amount)
        {
            startingPoint += amount;
            PointModified?.Invoke(amount);
        }
        Action<int> IPoint.OnModifyPoint()
        {
            return PointModified;
        }
        void IPoint.CheckPoint(int result)
        {
            endPoint = result;
        }
        void IPlayer.ShowPlayerInfo()
        {
            Console.WriteLine($"Player ID: {_id}");
            Console.WriteLine($"Player Name: {_name}");
            Console.WriteLine($"Player Point: {_point}");
            Console.WriteLine($"Player Gold: ${_gold}");
            Console.WriteLine($"Player Level: {_level}");
            Console.WriteLine($"Player Exp: {_exp}");
        }
        //void IPlayer.ReadyBattle()
        //{

        //}
        void IGold.ModifyGold(int amount)
        {
            startingGold += amount;
            GoldModified?.Invoke(amount);
        }
        Action<int> IGold.OnModifyGold()
        {
            return GoldModified;
        }
        void ILevel.ModifyLevel(int amount)
        {
            startingLevel += amount;
            LevelModified?.Invoke(amount);
        }
        Action<int> ILevel.OnModifyLevel()
        {
            return LevelModified;
        }
        void ILevel.AmountUnitDeployed()
        {

        }
        public string GenerateRandomId()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] idChars = new char[6];

            for (int i = 0; i < idChars.Length; i++)
            {
                idChars[i] = chars[random.Next(chars.Length)];
            }

            return new string(idChars);
        }
    }
}
