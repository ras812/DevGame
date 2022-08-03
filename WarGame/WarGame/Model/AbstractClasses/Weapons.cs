using System;
using System.Collections.Generic;
using System.Text;

namespace WarGame
{
    public abstract class Weapons
    {
        private string _name = "";  // Field
        
        // Property
        public string Name { get { return _name; } set { _name = value; } }

        public Weapons() : this(100, 200)
        {

        }

        public Weapons(int x):this(x, 200)
        { 
        
        }

        public Weapons(int x, int y)
        { 
        
        }
    }
}
