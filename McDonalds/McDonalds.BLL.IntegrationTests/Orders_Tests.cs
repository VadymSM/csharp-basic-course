using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using McDonalds.BL.Products;
using System.Collections.Generic;
using McDonalds.BL;

namespace McDonalds.BLL.IntegrationTests
{
    [TestClass]
    public class Orders_Tests
    {
        [TestMethod]
        public void AddOrderAndReceiveIt_Test()
        {
            // create order
            var productsInOrder = new List<Product>();
            productsInOrder.Add(new CocaCola(17));
            productsInOrder.Add(new Burger(19));

            Order newOrder = OrdersGenerator.Generate(productsInOrder);

            // KitchenService.StartUp();

            // OrdersService.AddOrder(newOrder);

            //int times = 0;
            // while( !OrdersService.IsReady(newOrder.Id) && times < 5) { Thread.Sleep(1000); times++; }

            //Assert.IsTrue(OrdersService.IsReady(newOrder.Id));
        }
    }
}
