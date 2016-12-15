using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.BL.Products
{
    public class Espresso: Drink
    {
        const int ESPRESSO_KCAL = 0;
        public Espresso(double price)
            :base(price, ESPRESSO_KCAL)
        {

        }

        public override bool IsHot()
        {
            return false;
        }
    }
}
