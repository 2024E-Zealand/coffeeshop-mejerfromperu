using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public abstract class CoffeeClass
    {

        public enum CoffeeStrength
        {
            Weak,
            Medium,
            Strong
        }

        public CoffeeClass()
        { 

            Discount = 0;
        }

        public int Discount { get; set; }


        public virtual double Price()
        {
            return 20;
        }

        public abstract CoffeeStrength Strength();

        public override string ToString()
        {
            return $"{this.GetType().Name}: Price = {Price()}, Strength = {Strength()}, Discount = {Discount}";
        }
    }
}
