using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.BL
{
    class BigMac: Sandwich
    {
        const int BIGMAC_KCAL = 509;
        public BigMac(double price)
            :base(price, BIGMAC_KCAL)
        {

        }
    }
}
