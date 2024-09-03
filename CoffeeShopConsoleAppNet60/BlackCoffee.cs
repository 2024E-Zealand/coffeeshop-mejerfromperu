using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class BlackCoffee : CoffeeClass
    {
        public BlackCoffee()
            : base()
        {
            Console.WriteLine($"The discount: {base.Discount}");
        }

        public override double Price()
        {
            
            return base.Price();

        }

        // Implement the Strength method to return an enum value
        public override CoffeeStrength Strength()
        {
            return CoffeeStrength.Strong; 
        }


    }
}
