using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using McDonalds.BL.Products;

namespace McDonalds.BL.Tests
{
    /// <summary>
    /// Summary description for Order_Tests
    /// </summary>
    [TestClass]
    public class Order_Tests
    {
        public Order_Tests()
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
        public void Order_ProductWasPrepared_Tests()
        {
            // 0 Создать булевую переменную isOrderReady !
            // 1 Создать переменную PreparedProduct !
            // 2 Создать переменную типа Order и заполнить его !
            // 3 Подписать Ордер на событие PreparedProduct
            // 4 Подписать лямбду на событие Ордер
            // 5 Добавить в PreparedProduct все нужные продукты !
            // 6 Проверить что лямба была вызвана

            bool isOrderReady = false;
            bool isProductCorrect = false;

            PreparedProducts _preparedProduct = new PreparedProducts();
            

            Order _order = new Order();
            _order.Add(new CocaCola(22));
            _order.Add(new Tea(15));
            _order.Add(new Fanta(19));

            _preparedProduct.ProductAdded += _order.ProductWasPrepared;

            Order.OrderIsReadyHandler checkEventOccuring = (Product p) =>
            {
                isOrderReady = true;
                if (p is CocaCola || p is Tea || p is Fanta)
                {
                    isProductCorrect = true;
                }
            };

            _order.OrderIsReadyEvent += checkEventOccuring;

            _preparedProduct.Add(new CocaCola(22));
            _preparedProduct.Add(new Tea(15));
            _preparedProduct.Add(new Fanta(19));

            Assert.IsTrue(isOrderReady);
            Assert.IsTrue(isProductCorrect);

        }
        [TestMethod]
        public void Order_ProductWasNotPrepared_Tests()
        {
            // 0 Создать булевую переменную isOrderReady !
            // 1 Создать переменную PreparedProduct !
            // 2 Создать переменную типа Order и заполнить его !
            // 3 Подписать Ордер на событие PreparedProduct
            // 4 Подписать лямбду на событие Ордер
            // 5 Добавить в PreparedProduct все нужные продукты !
            // 6 Проверить что лямба была вызвана

            bool isOrderReady = false;

            PreparedProducts _preparedProduct = new PreparedProducts();


            Order _order = new Order();
            _order.Add(new CocaCola(22));
            _order.Add(new Tea(15));
            _order.Add(new Fanta(19));

            _preparedProduct.ProductAdded += _order.ProductWasPrepared;

            Order.OrderIsReadyHandler checkEventOccuring = (Product p) =>
            {
                isOrderReady = true;                
            };

            _order.OrderIsReadyEvent += checkEventOccuring;

            _preparedProduct.Add(new CocaCola(22));
            _preparedProduct.Add(new Burger(15));

            Assert.IsFalse(isOrderReady);

        }
    }
}
