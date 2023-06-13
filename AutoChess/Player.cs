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
        private int _level;
        private int _experience;

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

        public Player(string id, string name, int level, int experience)
        {
            _id = id;
            _name = name;
            _level = level;
            _experience = experience;
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

        }
        void IPlayer.ReadyBattle()
        {

        }
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
    }
}
