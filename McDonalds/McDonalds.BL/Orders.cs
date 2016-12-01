using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using McDonalds.BL.Products;


namespace McDonalds.BL
{
    // [T] Create class Orders
    //      - add new order
    //      - remove order
    //      - clean - remove all orders
    //      - get order by id
    //      - get orders count
    //      - get ready orders
    //      - get closed orders
    //      - get inProgress orders

    class Orders
    {
        List<Order> _orders = new List<Order>();

        public void Add(Order order)
        {
            _orders.Add(order);
        }

        public void Remove(Order order)
        {
            _orders.Remove(order);
        }

        public void Clear()
        {
            _orders.Clear();
        }

        public Order OrderById(int id)
        {
            return _orders.FirstOrDefault(o => o.Id == id);
        }

        public int Count
        {
            get { return _orders.Count; }
        } 
        
        public List<Order> ReadyOrders
        {
            get { return _orders.Where(o => o.States == Order.OrderStates.Ready).ToList(); }
        }

        public List<Order> OpenOrders
        {
            get { return _orders.Where(o => o.States == Order.OrderStates.Open).ToList(); }
        }

        public List<Order> InProgressOrders
        {
            get { return _orders.Where(o => o.States == Order.OrderStates.InProgress).ToList(); }
        }
    }

}

