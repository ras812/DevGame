﻿using System;

namespace WarGame
{
    public class Weapon : Weapons
    {
        // Fields
        private readonly string _name;
        private readonly ItemType _weaponType;
        private readonly int _damageMin;
        private readonly int _damageMax;

        // Properties
        public override string Name
        {
            get { return _name; }
            //set
            //{
            //    if (Handlers.IsString(value))
            //    {
            //        _name = value;
            //    }
            //    else
            //    {
            //        _name = "LETTERS ONLY!";
            //        throw new ArgumentException("STRING MUST CONTAINS ONLY LETTERS!");
            //    }
            //}
        }

        public override ItemType WeaponType
        {
            get { return _weaponType; }
            //    set { _weaponType = value; } 
            //}

            //public override int DamageMin
            //{                                   // А ТУТ И НЕЛЬЗЯ ЭТОГО ДЕЛАТЬ!!!
            //    get { return _damageMin; }      // ВОТ ТУТ ОН НЕ ДАЕТ ПОСТАВИТЬ VALUE
            //    set
            //    {
            //        if (value > 0)
            //        {
            //            _damageMin = value;
            //        }
            //        else
            //        {
            //            _damageMin = 1;
            //        }
            //}
        }

        public override int DamageMax
        {
            get { return _damageMax; }
            //set
            //{
            //    if (value > 0)
            //    {
            //        _damageMax = value;

            //        if (_damageMax <= _damageMin)
            //        {
            //            _damageMax = _damageMin;
            //        }
            //    }
            //    else
            //    {
            //        _damageMax = 1;
            //    }
            //}
        }

        //Constructors
        public Weapon(string name, ItemType itemType, int dmgMin, int dmgMax)
        {
            try
            {
                if (Handlers.IsString(name))
                {
                    _name = name;
                }
                else
                {
                    _name = "Введен недопустимый символ!";
                    throw new ArgumentException("STRING MUST CONTAINS ONLY LETTERS!");
                }

            }

            catch (ArgumentException ex)
            {
                Console.WriteLine($"[{ex}]");
            }

            _weaponType = itemType;


            try
            {
                if(dmgMin > 0)
                {
                    _damageMin = dmgMin;
                }
             else
                {
                    _damageMin = 1;
                    throw new ArgumentException("VALUE MUST MORE THEN ZERO!");

                }
            
            }
        
           catch(ArgumentException ex)
            {
                Console.WriteLine($"[ex]");
            }

            try
            {
                if (dmgMax > 0)
                {
                    _damageMax = dmgMax;
                }
              else
                {
                    _damageMax= 1;
                    throw new ArgumentException("VALUE MUST MORE THEN ZERO!");
                }
            
            }
        
       
            catch(ArgumentException ex)
            {
                Console.WriteLine($"[ex]");
            }
           try
            {
                if(dmgMax > dmgMin)
                {
                    _damageMax = dmgMax;
                    _damageMin -= dmgMin;
                }
            
             else
                {
                    _damageMax = 1;
                    _damageMin = 1;
                    throw new ArgumentException("_damageMax не может быть меньше, чем _damageMin !");
                }
            
            }
        
            catch(ArgumentException ex)
            {
                Console.WriteLine($"[ex]");
            }
            
            }



    }

}