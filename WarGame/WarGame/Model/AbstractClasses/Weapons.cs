using System;
using System.Collections.Generic;
using System.Text;

namespace WarGame
{
    public abstract class Weapons
    {
        // Properties
        public virtual string Name
        {
            get;
            set;
        }
        public virtual ItemType WeaponType
        {
            get;
            set;
        }
        public virtual int DamageMin
        {
            get;
            set;
        }
        public virtual int DamageMax
        {
            get;
            set;
        }

        // НАДО ПРАВИЛЬНО СДЕЛАТЬ КОНСТРУКТОРЫ
        // И НАДО ЛИ ИХ ВООБЩЕ ТО ТУТ ДЕЛАТЬ???

        //public Weapons(string name) : this(name, 100, 200)
        //{

        //}

        //public Weapons(string name, int x) : this(name, x, 200)
        //{

        //}

        //public Weapons(string name, int x, int y)
        //{

        //}
    }
}
