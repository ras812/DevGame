using System;

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
            //set 
            //{
            //    try
            //    {
            //        if (Handlers.IsString(value))
            //        {
            //            _name = value;
            //        }
            //        else
            //        {
            //            _name = "LETTERS ONLY!";
            //            throw new ArgumentException("STRING MUST CONTAINS ONLY LETTERS!");
            //        }
            //    }
            //    catch(ArgumentException ex)  {
            //        Console.WriteLine($"[{ex}]");
            //    }
            //}
        }

        public override ItemType ArmorType
        {
            get { return _armorType; }
            // set { _armorType = value; }
        }

        public override int ArmorDefence
        {
            get { return _armorDefence; }
            //set 
            //{
            //    if (value > 0)
            //    {
            //        _armorDefence = value;
            //    }
            //    else
            //    {
            //        _armorDefence = 1;
            //    }
            //}
        }   // тут тоже надо делать проверку, если знечение будет отрицательным, то должно ровняться 1

        public Armor(string name, ItemType armorType, int armorDefence)    //КОНСТРУКОР ТАКОЙ ДОЛЖЕН БЫТЬ? 
        {
            try
            {
                if (Handlers.IsString(name))
                {
                    _name = name;
                }
                else
                {
                    _name = "LETTERS ONLY!";
                    throw new ArgumentException("STRING MUST CONTAINS ONLY LETTERS!");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"[{ex}]");
            }

            _armorType = armorType;

            try
            {
                if (armorDefence > 0)
                {
                    _armorDefence = armorDefence;
                }
                else
                {
                    _armorDefence = 1;
                    throw new ArgumentException("VALUE MUST MORE THEN ZERO!");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"[{ex}]");
            }
        }

    }

}
