using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Cortado : CoffeeClass
    {


        public Cortado()
            :base()
        {
            
        }

        public override double Price()
        {
            return base.Price() + 5;
        }



    }
}
