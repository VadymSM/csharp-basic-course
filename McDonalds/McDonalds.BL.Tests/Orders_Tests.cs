using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using McDonalds.BL.Products;
using McDonalds.BL;
using System.Collections.Generic;

namespace McDonalds.BL.Tests
{
    /// <summary>
    /// Summary description for Orders_Tests
    /// </summary>
    [TestClass]
    public class Orders_Tests
    {
        public Orders_Tests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void Orders_BasicOperations_Tests()
        {
            //
            // TODO: Add test logic here
            // 1. Создать обьект Orders
            // 2. Добавить 4 ордера: С разными статусами
            // 3. Проверить свойство Count
            // 4. Удалить 1 ордер со статусом Опен
            // 5. Проверить Geter
            // 6. Вызвать Clear и убедится что Ордер пустой

            Orders orders = new Orders();
            Order order1 = new Order();
            order1.States = Order.OrderStates.Open;
            Order order2 = new Order();
            order2.States = Order.OrderStates.Open;
            Order order3 = new Order();
            order3.States = Order.OrderStates.Ready;
            Order order4 = new Order();
            order4.States = Order.OrderStates.InProgress;

            orders.Add(order1);
            orders.Add(order2);
            orders.Add(order3);
            orders.Add(order4);

            Assert.IsTrue(orders.OpenOrders.Count == 2, "Case 1");

            orders.Remove(order2);

            Assert.IsTrue(orders.OpenOrders.Count == 1, "Case 2");
            Assert.IsTrue(orders.Count == 3, "Case 3");            

            orders.Clear();
            Assert.IsTrue(orders.Count == 0, "Case 4");

            
        }
    }
}
