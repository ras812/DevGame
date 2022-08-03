using System;
using System.Collections.Generic;

namespace WarGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WarGame");
            Warrior obj = new Warrior();
            Console.WriteLine("Victory!");
            Weapon sword = new Weapon();
            Weapon mace = new Weapon(100);
        }
    }
}
