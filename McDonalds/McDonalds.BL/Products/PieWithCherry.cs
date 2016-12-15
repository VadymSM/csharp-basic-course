using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.BL.Products
{
    public class PieWithCherry : Dessert
    {
        const int PIEWITHCHERRY_KCAL = 272;
        public PieWithCherry(double price)
            : base(price, PIEWITHCHERRY_KCAL)
        {

        }
    }
}
