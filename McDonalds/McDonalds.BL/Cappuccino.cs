using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.BL
{
    class Cappuccino: Drink
    {
        const int CAPPUCCINO_KCAL = 59;
        public Cappuccino(double price)
            :base(price, CAPPUCCINO_KCAL)
        {

        }

        public override bool IsHot()
        {
            return false;
        }
    }
}
