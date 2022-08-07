using System;
using System.Collections.Generic;
using System.Text;

namespace WarGame
{
    public class Armor : Armors
    {

        public string _nameArm;
        public Type _typeArm;
        public int _armorType;

        public override string NameArm
        {
            get { return _nameArm; }
            set { _nameArm = value; }
        }

        public override Type TypeArm
        {
            get { return _typeArm; }
            set { _typeArm = value; }   
        }

        public override int ArmorType
        {
            get { return _armorType; }
            set {if(value > 0) _armorType = value; }
        }
    
    }
}