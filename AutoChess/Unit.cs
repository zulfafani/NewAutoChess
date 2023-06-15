using System;
using System.Collections.Generic;
using System.Diagnostics;
using AutoChess;

namespace AutoChess
{
    public class Unit : IHealth, IUnit, IAttack
    {
        //private string _id;
        //private string _name;
        private Race _race;
        private Class _class;
        private Quality _quality;

        private int _health;
        private int _attack;
        private int _price;

        //Health
        public event Action<int> HealthModified;
        public int baseHealth { get; set; }
        public int maxHealth { get; set; }

        //Attack
        public event Action<int> AttackModified;
        public int baseAttack { get; set; }
        public int maxAttack { get; set; }

        //public string Name { get { return _name; } }
        public int Health { get { return _health; } }
        public int Attack { get { return _attack; } }
        public int Price { get { return _price; } }

        public Race Race
        {
            get { return _race; }
            set { _race = value; }
        }

        public Class Class
        {
            get { return _class; }
            set { _class = value; }
        }

        public Quality Quality
        {
            get { return _quality; }
            set { _quality = value; }
        }

        public Unit(Race race)
        {
            _race = race;
            _class = (Class)new Random().Next(Enum.GetValues(typeof(Class)).Length);
            _quality = (Quality)new Random().Next(Enum.GetValues(typeof(Quality)).Length);
            _health = 0;
            _attack = 0;
            _price = 1;
        }

        void IHealth.ModifyHealth(int amount)
        {
            baseHealth -= amount;
            HealthModified?.Invoke(amount);
        }
        Action<int> IHealth.OnModifyHealth()
        {
            return HealthModified;
        }
        void IUnit.ShowUnitInfo()
        {
            Console.WriteLine($"Race: {_race}");
            Console.WriteLine($"Class: {_class}");
            Console.WriteLine($"Quality: {_quality}");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Attack: {Attack}");
            Console.WriteLine($"Price: ${Price}");
        }
        void IAttack.ModifyAttack(int amount)
        {
            baseAttack -= amount;
            AttackModified?.Invoke(amount);
        }
        Action<int> IAttack.OnModifyAttack()
        {
            return AttackModified;
        }

    }
}
