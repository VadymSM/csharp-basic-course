using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using McDonalds.BL.Products;

namespace McDonalds.BL
{
    public class Order
    {
        // [T] Property Id (it should be unique), setup this value in constructor

        // [T] add states to order: Open, InProgress, Close
        //      - Open - order no prepared products
        //      - InProgress - we have at least on prepared product
        //      - Ready - all products are ready
        //      Note: use enum - OrderStates, create appropriate field, change this field when necessary
        // [T] add property for OrderStates

        // [T] Property Price - dynamicly calculate price of the Order

        // [T]!!!! cover class by unit tests!

        private static int _startId = 0;
        
        public int Id
        {
            get; protected set;
        }

        public Order()
        {
            Id = _startId++;
        }

        public double Price
        {
            get { return _productsInOrder.Sum(p => p.Price); }
        }

        public enum OrderStates
        {
            Open = 1,
            InProgress = 2,
            Ready = 3
        }

        public OrderStates States
        {
            get; set;
        }

        
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
