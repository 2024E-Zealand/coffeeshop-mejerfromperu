﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Latte : CoffeeClass
    {

        public Latte()
            : base()
        {
            
        }

        public override double Price()
        {
            return 45;
        }

    }
}
