using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.BL.Products
{
    class McChicken: Sandwich
    {
        const int MCCHICKEN_KCAL = 426;
        public McChicken(double price)
            :base(price, MCCHICKEN_KCAL)
        {

        }
    }
}
