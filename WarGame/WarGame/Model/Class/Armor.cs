using System;
using System.Collections.Generic;
using System.IO;

namespace WarGame
{
    public class Armor : Armors
    {
        private readonly string _name;
        private readonly ItemType _armorType;
        private readonly int _armorDefence;

        public override string Name
        {
            get { return _name; }
        }

        public override ItemType ArmorType
        {
            get { return _armorType; }
        }

        public override int ArmorDefence
        {
            get { return _armorDefence; }
        }

        public Armor()
        {
            Random rnd = new Random();
            string path = @"/Users/Aleks/Projects/DevGame/WarGame/WarGame/Model/DataBase/ArmorBase.txt";

            List<string[]> itemsList;
            itemsList = CreateItemsListFromFile(path);
            int itemsListCount = itemsList.Count;

            int rndNum = rnd.Next(0, itemsListCount);

            _name = ValidName(Convert.ToString(itemsList[rndNum][0]));
            _armorType = (ItemType)Convert.ToInt32(itemsList[rndNum][1]);
            _armorDefence = ValidArmorDefence(Convert.ToInt32(itemsList[rndNum][2]));
        }

        public Armor(string name, ItemType armorType, int armorDefence)
        {
            _name = ValidName(name);
            _armorType = armorType;
            _armorDefence = ValidArmorDefence(armorDefence);
        }

        public List<string[]> CreateItemsListFromFile(string filePath)
        {
            List<string[]> res = new List<string[]>();

            string[] itemPropertiesLine = File.ReadAllLines(filePath, System.Text.Encoding.UTF8);
            int iPLlen = itemPropertiesLine.Length;
            for (int i = 0; i < iPLlen; i++)
            {
                string[] temp = itemPropertiesLine[i].Split(';');
                res.Add(temp);
            }
            return res;
        }

        private string ValidName(string name)
        {
            string res = "";
            try
            {
                if (Handlers.IsString(name))
                {
                    res = name;
                }
                else
                {
                    res = "LETTERS ONLY!";
                    throw new ArgumentException("STRING MUST CONTAINS ONLY LETTERS!");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"[{ex}]");
            }
            return res;
        }

        private int ValidArmorDefence(int armorDefenceValue)
        {
            int res = 0;
            try
            {
                if (armorDefenceValue > 0)
                {
                    res = armorDefenceValue;
                }
                else
                {
                    res = 1;
                    throw new ArgumentException("VALUE MUST MORE THEN ZERO!");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"[{ex}]");
            }
            return res;
        }

    }
}