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
            set { _name = value; }
        }

        public override ItemType ArmorType
        {
            get { return _armorType; }
            set { _armorType = value; }   
        }

        public override int ArmorDefence
        {
            get { return _armorDefence; }
            set { if(_armorDefence > 0) _armorDefence = value; }
        }   // тут тоже надо делать проверку, если знечение будет отрицательным, то должно ровняться 1
    
    }
}