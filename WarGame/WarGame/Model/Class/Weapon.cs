﻿using System;

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
        {
            get { return _damageMin; }     //сделала проверку
            set { if(_damageMin > 0 && _damageMin < _damageMax) _damageMin = value; }
        }   // если проверка прошла несупешно, то тогда значение данного поля равно 1

        public override int DamageMax
        {
            get { return _damageMax; }
            set { if (_damageMax > 0 && _damageMax > _damageMin) _damageMax = value; }
        }   // если проверка прошла несупешно, то тогда значение данного поля равно 1

        //Constructors
        public Weapon()
        {
            // нужно обязательно сделать конструктор
        }


        // Это написано тестово, тут будет написан ТВОЙ код )))
    }
}