using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using McDonalds.BL;
using McDonalds.BL.Products;

namespace McDonalds.BLL.IntegrationTests
{
    static class OrdersGenerator
    {
        public static Order Generate(List<Product> products)
        {
            Order order = new Order();
            products.ForEach(p => order.Add(p));

            return order;
        }
    }
}
