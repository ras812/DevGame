using System;
using System.Collections.Generic;
using System.Text;

namespace WarGame
{
    public abstract class Armors
    {
        public virtual string Name
        {
            get;
            //set;
        }

        public virtual ItemType ArmorType
        {
            get;
            //set;
        }
    
        public virtual int ArmorDefence
        {
            get;
            //set;
        }
    }
}