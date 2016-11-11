using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds.BL.Products
{
    abstract class Product
    {
        public double Price
        {
            get; set;
        }

        public int KCal
        {
            get; set;
        }

        public Product(double price, int kcal)
        {
            Price = price;
            KCal = kcal;
        }

        public override bool Equals(object obj)
        {
            Product product = obj as Product;
            if (product == null)
            {
                return false;
            }

            return this.Price == product.Price &&
                   this.KCal == product.KCal;
        }
    }
}
