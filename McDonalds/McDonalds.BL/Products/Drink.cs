﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.BL.Products
{
    abstract public class Drink: Product
    {
        public Drink(double price, int kcal)
            : base(price, kcal)
        {

        }

        public abstract bool IsHot();
    }
}
