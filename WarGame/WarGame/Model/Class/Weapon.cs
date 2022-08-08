using System;

namespace WarGame
{
    public class Weapon : Weapons
    {
        // Fields
        private string _name;
        private ItemType _weaponType;
        private int _damageMin;
        private int _damageMax;

        // Properties
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

        public override ItemType WeaponType
        {
            get { return _weaponType; }
            set { _weaponType = value; } 
        }
        
        public override int DamageMin
        {                                   // А ТУТ И НЕЛЬЗЯ ЭТОГО ДЕЛАТЬ!!!
            get { return _damageMin; }      // ВОТ ТУТ ОН НЕ ДАЕТ ПОСТАВИТЬ VALUE
            set
            {
                if (value > 0)
                {
                    _damageMin = value;
                }
                else
                {
                    _damageMin = 1;
                }
            }
        }

        public override int DamageMax
        {
            get { return _damageMax; }
            set
            {
                if (value > 0)
                {
                    _damageMax = value;

                    if (_damageMax <= _damageMin)
                    {
                        _damageMax = _damageMin;
                    }
                }
                else
                {
                    _damageMax = 1;
                }
            }
        }

        //Constructors
        public Weapon(string name, ItemType itemType, int dmgMin, int dmgMax)
        {
            Name = name;
            WeaponType = itemType;
            DamageMin = dmgMin;
            DamageMax = dmgMax;
        }

        // Это написано тестово, тут будет написан ТВОЙ код )))
    }
}