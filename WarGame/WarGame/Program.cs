using System;
using System.Collections.Generic;
using System.IO;

namespace WarGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Armor armor;

            //Console.Write(String.Join("\n", "Name: " + armor.Name,
            //                                "Type: " + armor.ArmorType,
            //                                "Def: " + armor.ArmorDefence));

            int[] counts = { 0, 0, 0 }; 
            for (int i = 0; i < 10000; i++)
            {
                armor = new Armor();
                if (armor.Name == "Aegis") counts[0]++;
                else if (armor.Name == "Bonewall") counts[1]++;
                else if (armor.Name == "Magneto") counts[2]++;
                Console.WriteLine(armor.Name);
            }

            foreach (var item in counts)
            {
                Console.WriteLine($"ItemCount: {item}");
            }

            //foreach (var item in arm)
            //{
            //    Console.WriteLine(item);
            //}

            //Dictionary<string, string[]> items = new Dictionary<string, string[]>();

            //string[] temp = new string[4];
            //for (int i = 0; i < arm.Length; i++)
            //{
            //    temp = arm[i].Split(';');
            //    items[temp[0]] = new string[] { temp[1], temp[2], temp[3] };
            //}

            //foreach (var item in items)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var propertysItems in item.Value)
            //    {
            //        Console.WriteLine(propertysItems);
            //    }
            //}

            //Console.WriteLine(items["shield"][0]);

            //Armor ar = new Armor("Shield", ItemType.Light, 5);

            

            //Armor armor = new Armor(Convert.ToString(temp[1]), (ItemType)Convert.ToInt32(temp[2]), Convert.ToInt32(temp[3]));

            //Weapon sword = new Weapon("Excalibur", ItemType.Heavy, 3, 7);
            //Armor shield = new Armor("Shield", ItemType.Light, 5);

            //Warrior player1 = new Warrior();
            //player1.Display();

            //Warrior player2 = new Warrior("Jack", Gender.Male, 100, 6, 6, 6, sword, shield);
            //player2.Display();

            //Arena arena = new Arena();
            //Console.WriteLine($"Vitorious is {arena.Attack(player1, player2).Name}!!!");
        }
    }
}
