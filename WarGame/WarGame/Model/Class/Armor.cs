using System;
using System.Collections.Generic;
using System.Text;

namespace WarGame
{
    public class Armor : Armors
    {

        public string _name;
        public ItemType _armorType;
        public int _armorDefence;

        public override string Name
        {
            get { return _name; }
            set 
            {
                if (Handlers.IsString(value))
                {
                    _name = value;
                }
                else
                {
                    _name = "LETTERS ONLY!";
                    throw new ArgumentException("STRING MUST CONTAINS ONLY LETTERS!");
                }


            }
        }

        public override ItemType ArmorType
        {
            get { return _armorType; }
            set 
            
            { 
                _armorType = value; }   
        }

        public override int ArmorDefence
        {
            get { return _armorDefence; }
            set 
            {

                if (_armorDefence > 0)
                {
                    _armorDefence = value;
                }
              else
                {
                    _armorDefence = 1;
                }
            }
        
            
        
        }   // тут тоже надо делать проверку, если знечение будет отрицательным, то должно ровняться 1

        public Armor(string name, ItemType armorType, int armorDefence)    //КОНСТРУКОР ТАКОЙ ДОЛЖЕН БЫТЬ? 
                                                                             //ЧЕСТНО ГОВОРЯ, НЕ ОЧЕНЬ ПОНИМАЮ, КАК ЕГО ДЕЛАТЬ(
        {
            Name = name;
            ArmorType = armorType;
            ArmorDefence = armorDefence;
            
        }

    }
}