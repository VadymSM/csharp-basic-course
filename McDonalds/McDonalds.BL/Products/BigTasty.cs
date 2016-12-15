using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.BL.Products
{
    public class BigTasty: Sandwich
    {
        const int BIGTASTY_KCAL = 842;
        public BigTasty(double price)
            :base(price, BIGTASTY_KCAL)
        {

        }
    }
}
