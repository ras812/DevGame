using System;

namespace WarGame
{
    public class Weapon : Weapons
    {
        private readonly string _name = "";
        public Type _type1 = Type.Light;
        public int _damageMin;
        public int _damageMax;

        public override string Name
        {
            get { return this._name; }
            set { if(IsDiggit(_name)) value = _name; };
  
        }

        public override Type Type1 //что не так?
        {
            get { return this._type1; }
            set { value = _type1; }
        }
        
        public override int DamageMin
        {
            get { return this._damageMin; }
            set {  value = _damageMin; }
        }

        public override int DamageMax
        {
            get { return this._damageMax; }
            set { value = _damageMax; }
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
