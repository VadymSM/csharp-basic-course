using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using McDonalds.BL;
using McDonalds.BL.Products;

namespace McDonalds.BL.Tests
{
    /*
    class MyStub
    {
        public bool _testMethodWasCalled = false;

        public void Test(Product p)
        {
            _testMethodWasCalled = true;
        }
    }
     */

    [TestClass]
    public class PreparedProducts_Tests
    {
        [TestMethod]
        public void PreparedProducts_CreateAndAdding_Test()
        {
            PreparedProducts preparedProducts = new PreparedProducts();
            preparedProducts.Add(new CocaCola(12));
            preparedProducts.Add(new CocaCola(13));

            Assert.AreEqual(2, preparedProducts.Products.Count(), "Error #1. Wrong number of products.");
        }

        [TestMethod]
        public void PreparedProducts_CheckProductAddedEvent_Test()
        {
            bool isHandlerCalled = false;
            bool isProductCorrect = false;

            PreparedProducts.ProductAddedHandler checkEventOccuring = (Product p) =>
            {
                isHandlerCalled = true;

                if (p is CocaCola)
                {
                    isProductCorrect = (p.Price == 12);
                }
            };

            //MyStub myStub = new MyStub();

            PreparedProducts preparedProducts = new PreparedProducts();
            //preparedProducts.ProductAdded += myStub.Test;

            preparedProducts.ProductAdded += checkEventOccuring;

            preparedProducts.Add(new CocaCola(12));

            //Assert.IsTrue(myStub._testMethodWasCalled);
            Assert.IsTrue(isHandlerCalled);
            Assert.IsTrue(isProductCorrect);
        }
    }
}
