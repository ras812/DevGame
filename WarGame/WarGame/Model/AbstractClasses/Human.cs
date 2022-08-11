using System;

namespace WarGame
{
	public abstract class Human
	{
        // Properties
        public virtual string Name
        {
            get;
            set;
        }
        public virtual Gender HumanGender
        {
            get;
            set;
        }
        public virtual int HP
        {
            get;
            set;
        }
        public virtual int Strenght
        {
            get;
            set;
        }
        public virtual int Dexterity
        {
            get;
            set;
        }
        public virtual int Intellegence
        {
            get;
            set;
        }
    }
}