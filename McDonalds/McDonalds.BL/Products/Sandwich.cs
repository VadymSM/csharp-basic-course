using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.BL.Products
{
    abstract class Sandwich : Product
    {
        public Sandwich(double price, int kcal)
            : base(price, kcal)
        {

        }
        public virtual bool HasCheese()
        {
            return true;
        }
    }
}
