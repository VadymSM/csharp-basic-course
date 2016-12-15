using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.BL.Products
{
    public class Americano: Drink
    {
        const int AMERICANO_KCAL = 0;
        public Americano(double price)
            :base(price, AMERICANO_KCAL)
        {

        }

        public override bool IsHot()
        {
            return false;
        }
    }
}
