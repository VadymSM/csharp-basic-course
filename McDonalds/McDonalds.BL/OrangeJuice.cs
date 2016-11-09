using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.BL
{
    class OrangeJuice : Drink
    {
        const int ORANJEJUICE_KCAL = 110;
        public OrangeJuice(double price)
            :base(price, ORANJEJUICE_KCAL)
        {

        }

        public override bool IsHot()
        {
            return false;
        }
    }
}
