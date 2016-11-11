using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.BL.Products
{
    abstract class Dessert: Product
    {
        public Dessert(double price, int kcal)
            :base(price, kcal)
        {

        }
    }
}
