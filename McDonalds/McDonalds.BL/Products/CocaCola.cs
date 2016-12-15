using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.BL.Products
{
    public class CocaCola : Drink
    {
        const int COCACOLA_KCAL = 100;
        public CocaCola(double price)
            : base(price, COCACOLA_KCAL)
        {

        }
        public override bool IsHot()
        {
            return false;
        }

        public override bool Equals(object obj)
        {
            CocaCola cola = obj as CocaCola;
            if (cola == null)
            {
                return false;
            }
            return base.Equals(cola);
        }
    }
}
