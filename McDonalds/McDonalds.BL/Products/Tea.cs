using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.BL.Products
{
    public class Tea : Drink
    {
        const int TEA_KCAL = 1;
        public Tea(double price)
            : base(price, TEA_KCAL)
        {

        }
        public override bool IsHot()
        {
            return true;
        }
    }
}
