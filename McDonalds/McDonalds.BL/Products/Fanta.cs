using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.BL.Products
{
    public class Fanta : Drink
    {
        const int FANTA_KCAL = 100;
        public Fanta(double price)
            : base(price, FANTA_KCAL)
        {

        }
        public override bool IsHot()
        {
            return false;
        }
        public override bool Equals(object obj)
        {
            Fanta fanta = obj as Fanta;
            if (fanta == null)
            {
                return false;
            }
            return base.Equals(fanta);
        }
    }
}
