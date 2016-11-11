using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.BL.Products
{
    class DoubleCheeseBurger : Sandwich
    {
        const int DOUBLECHEESEBURGER_KCAL = 448;
        public DoubleCheeseBurger(double price)
            : base(price, DOUBLECHEESEBURGER_KCAL)
        {

        }
    }
}
