using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using McDonalds.BL.Products;

namespace McDonalds.BL
{
    class Order
    {
        // [T] list of products connected with the Order
        // [T] list of prepared products

        // [T] AddProduct method
        // [T] RemoveProduct method

        // [T] declare delegate for event
        // [T] event Ready, occur when all products in Order are prepared.
        //      when prepared list is equal products list we should generate event

        // [T] ProductWasPrepared(Product)  - add product to the prepared list

        // [T] Property Price - dynamicly calculate price of the Order

        // [T]!!!! cover class by unit tests!

        List<Product> _productsInOrder = new List<Product>();

        List<Product> _preparedProducts = new List<Product>();

        public delegate void OrderIsReadyHandler(Product product);

        public event OrderIsReadyHandler OrderIsReadyEvent;

        public void Add(Product product)
        {
            _productsInOrder.Add(product);
                                    
        }

        public void Remove(Product product)
        {
            _productsInOrder.Remove(product);
        }

        public void ProductWasPrepared(Product product)
        {
            _preparedProducts.Add(product);
            var checkEqual = _preparedProducts.SequenceEqual(_productsInOrder);
            if (OrderIsReadyEvent != null && checkEqual == true)
            {
                OrderIsReadyEvent(product);
            }
        }

    }
}
