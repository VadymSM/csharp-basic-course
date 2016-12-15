using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.BL.Products
{
    public class Burger : Sandwich
    {
        const int BURGER_KCAL = 254;
        public Burger(double price)
            : base(price, BURGER_KCAL)
        {

        }
        public override bool HasCheese()
        {
            return false;
        }
    }
}

