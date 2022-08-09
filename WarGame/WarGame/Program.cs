using System;

namespace WarGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon mase = new Weapon("Boulder", ItemType.Medium, -5, -6);
            Console.WriteLine($"Name[{mase.Name}], ItemType[{mase.WeaponType}], " +
                              $"dmgMin[{mase.DamageMin}], dmgMax[{mase.DamageMax}]");

            Weapon sword = new Weapon("Excalibur", ItemType.Heavy, 10, 5);
            Console.WriteLine($"Name[{sword.Name}], ItemType[{sword.WeaponType}], " +
                              $"dmgMin[{sword.DamageMin}], dmgMax[{sword.DamageMax}]");
            
            Weapon dagger = new Weapon("Kriss", ItemType.Light, 3, 7);
            Console.WriteLine($"Name[{dagger.Name}], ItemType[{dagger.WeaponType}], " +
                              $"dmgMin[{dagger.DamageMin}], dmgMax[{dagger.DamageMax}]");

            // ВОТ ТАКИМ ОБРАЗОМ МОЖНО ПРОТЕСТИРОВАТЬ КЛАСС ОРУЖИЕ

            Armor shield = new Armor("Shield", ItemType.Light, 5);
            Console.WriteLine($"Название {shield.Name}, уровень защиты: {shield.ArmorType}, " +
                              $"количество защиты: {shield.ArmorDefence}");

            Armor plate = new Armor("P1ate", ItemType.Heavy, -5); //    КАК-ТО СТРАННО ПРОВЕРКА РАБОТАЕТ. МНЕ НЕ ОЧЕНЬ НРАВИТСЯ ПРОВЕРКА В КОНСТРУКТОРЕ
            Console.WriteLine($"Название {plate.Name}, уровень защиты: {plate.ArmorType}, " +
                              $"количество защиты: {plate.ArmorDefence}");


            Armor magicProtect = new Armor("MagicProtect", ItemType.Medium, 20);
            Console.WriteLine($"Название {magicProtect.Name}, уровень защиты: {magicProtect.ArmorType}, " +
                             $"количество защиты: {magicProtect.ArmorDefence}");

            //ПРОТЕСТИРОВАЛА КЛАСС ЗАЩИТА
        }


    }

}
