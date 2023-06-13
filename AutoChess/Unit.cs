using System;
using System.Collections.Generic;
using AutoChess;

namespace AutoChess
{
    public class Unit : IHealth, IUnit, IAttack
    {
        //private string _id;
        //private string _name;
        //private int _level;
        //private int _exp;

        private string _name;
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

        public string Name { get { return _name; } }
        public int Health { get { return _health; } }
        public int Attack { get { return _attack; } }
        public int Price { get { return _price; } }

        public Unit(string name, int health, int attack, int price)
        {
            _name = name;
            _health = health;
            _attack = attack;
            _price = price;
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
        public void ShowProfileInfo()
        {
            Console.WriteLine($"Unit: {Name}");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Attack: {Attack}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine();
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
