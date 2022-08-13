using System;

namespace WarGame
{
    class Program
    {
        static void Main(string[] args)    //ПОЧЕМУ-ТО НЕ РАБОТАЕТ КОНСТРУКТОР ДЛЯ Weapon И Armor !
        {
            Weapon sword = new Weapon("Excalibur", ItemType.Heavy, 3, 7);

            Console.WriteLine(String.Join("\n", "Name: " + sword.Name,
                                                "ItemType: " + sword.WeaponType,
                                                "Damage Min: " + sword.DamageMin,
                                                "Damage Max: " + sword.DamageMax));
            // НАВЕРНОЕ ПОТОМУ, ЧТО ОБЬЕКТ БЫЛ СОЗДАН НО НЕ ВЫВЕДЕН НА ЭКРАН?

            Armor shield = new Armor("Shield", ItemType.Light, 5);
            

            //    Warrior player1 = new Warrior();
            //    player1.Display();

            //    Warrior player2 = new Warrior("Jack", Gender.Male, 100, 6, 6, 6, sword, shield);
            //    player2.Display();

            //    Arena arena = new Arena();
            //    Console.WriteLine($"Vitorious is {arena.Attack(player1, player2).Name}!!!");
            //}


        }
    }
}
