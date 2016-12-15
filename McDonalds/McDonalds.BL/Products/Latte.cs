using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.BL.Products
{
    public class Latte: Drink
    {
        const int LATTE_KCAL = 75;
        public Latte(double price)
            :base(price, LATTE_KCAL)
        {

        }

        public override bool IsHot()
        {
            return false;
        }
    }
}
