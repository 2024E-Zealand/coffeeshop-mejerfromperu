using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    abstract class CoffeeClass
    {

        public enum CoffeeStrength
        {
            Weak,
            Medium,
            Strong
        }

        public CoffeeClass()
        {s
            
        }

        public virtual double Price()
        {
            return 20;
        }

        public abstract string Strength();
        

    }
}
