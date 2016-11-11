using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.BL.Products
{
    class Sprite: Drink
    {
        const int SPRITE_KCAL = 100;

        public Sprite(double price)
            : base(price, SPRITE_KCAL)
        {

        }

        public override bool IsHot()
        {
            return false;
        }

        public override bool Equals(object obj)
        {
            Sprite sprite = obj as Sprite;
            if (sprite == null)
            {
                return false;
            }
            return base.Equals(sprite);
        }
    }
}
