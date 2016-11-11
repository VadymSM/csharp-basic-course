using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.BL.Products
{
    class CheeseBurger : Sandwich
    {
        const int CHEESEBURGER_KCAL = 304;
        public CheeseBurger(double price)
            : base(price, CHEESEBURGER_KCAL)
        {

        }
    }
}
