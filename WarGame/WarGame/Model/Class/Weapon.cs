using System;

namespace WarGame
{
    public class Weapon : Weapons
    {
        private readonly string _name = "";

        public override string Name
        {
            get { return this._name; }  //readonly property
        }

        public Weapon() : this("Kings Arthur Excalibur")
        {

        }

        public Weapon(string weaponName) : base(weaponName, 100, 200)
        {
            _name = weaponName;
        }

        // Это написано тестово, тут будет написан ТВОЙ код )))
        // (можешь эту хрень удалить)
    }
}
