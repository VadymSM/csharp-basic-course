using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.BL
{
    class CheeseBurgerWithBacon : Sandwich
    {
        const int CHEESEBURGERWITHBACON_KCAL = 332;
        public CheeseBurgerWithBacon(double price)
            :base(price, CHEESEBURGERWITHBACON_KCAL)
        {

        }
    }
}
