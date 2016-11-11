using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.BL.Products
{
    class RoyalCheeseBurger : Sandwich
    {
        const int ROYALCHEESEBURGER_KCAL = 567;
        public RoyalCheeseBurger(double price)
            :base(price, ROYALCHEESEBURGER_KCAL)
        {

        }
    }
}
