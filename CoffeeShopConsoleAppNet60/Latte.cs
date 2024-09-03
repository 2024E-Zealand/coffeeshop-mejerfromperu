using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Latte : CoffeeClass, IMilk
    {

        public Latte()
            : base()
        {
            Console.WriteLine($"The discount: {base.Discount}");
        }

        public int mlMilk()
        {
            return 200;
        }

        public override double Price()
        {
            return 45;
        }

        public override CoffeeStrength Strength()
        {
            return CoffeeStrength.Weak;
        }

    }
}
