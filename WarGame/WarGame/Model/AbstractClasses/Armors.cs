using System;
using System.Collections.Generic;
using System.Text;

namespace WarGame
{
    public abstract class Armors
    {
        public virtual string NameArm
        {
            get;
            set;
        }

        public virtual Type TypeArm
        {
            get;
            set;
        }
    
        public virtual int ArmorType
        {
            get;
            set;
        }
    
    
    
    }
}