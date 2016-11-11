using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.BL.Products
{
    class FiletOFish: Sandwich
    {
        const int FILETOFISH_KCAL = 333;
        public FiletOFish(double price)
            :base(price, FILETOFISH_KCAL)
        {

        }
    }
}
