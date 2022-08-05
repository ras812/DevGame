using System;
using System.Collections.Generic;
using System.Text;

namespace WarGame
{
    public abstract class Weapons
    {
        private string _name = "";  // Field

        // Property
        public virtual string Name { get { return _name; } set {  _name = value; } }

        public Weapons(string name) : this(name, 100, 200)
        {

        }

        public Weapons(string name, int x) : this(name, x, 200)
        {

        }

        public Weapons(string name, int x, int y)
        {

        }
    }
}
