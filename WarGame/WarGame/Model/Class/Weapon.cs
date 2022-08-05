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
            set { _name = value; }
        }

        public override ItemType WeaponType //уже все норм!!!
        {
            get { return _weaponType; }
            set { _weaponType = value; }
        }
        
        public override int DamageMin
        {
            get { return _damageMin; }
            set { _damageMin = value; }
        }

        public override int DamageMax
        {
            get { return _damageMax; }
            set { _damageMax = value; }
        }

        //Constructors
        public Weapon() //: this("Kings Arthur Excalibur")
        {

        }

        //public Weapon(string weaponName) : base(weaponName, 100, 200)
        //{
        //    _name = weaponName;
        //}

        // Это написано тестово, тут будет написан ТВОЙ код )))
        // (можешь эту хрень удалить)
    }
}