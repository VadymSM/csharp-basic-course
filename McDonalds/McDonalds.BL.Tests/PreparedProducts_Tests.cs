using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using McDonalds.BL;
using McDonalds.BL.Products;
using System.Collections.Generic;

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

        [TestMethod]
        public void PreparedProducts_CheckRemoveProduct_Test()
        {
            PreparedProducts preparedProducts = new PreparedProducts();
            // #1 products of the same type
            preparedProducts.Add(new CocaCola(12));
            preparedProducts.Add(new CocaCola(15));
            preparedProducts.Add(new CocaCola(9));
            
            preparedProducts.RemoveByType(new CocaCola(12));            
            
            Assert.AreEqual(2, preparedProducts.Products.Count());

            preparedProducts.RemoveByType(new CocaCola(12), 2);
            Assert.AreEqual(0, preparedProducts.Products.Count());

            // #2 products of different types
            preparedProducts.Add(new CocaCola(12));
            preparedProducts.Add(new Fanta(15));
            preparedProducts.Add(new Tea(9));
            preparedProducts.Add(new CheeseBurger(12));
            preparedProducts.Add(new CheeseBurger(15));
            preparedProducts.Add(new Fanta(9));

            preparedProducts.RemoveByType(new Fanta(12));
            preparedProducts.RemoveByType(new CheeseBurger(12), 2);

            Assert.AreEqual(3, preparedProducts.Products.Count());

            Assert.IsTrue(preparedProducts.Products.Count(p => p.GetType() == typeof(Fanta)) == 1);

            Assert.IsFalse(preparedProducts.Products.Any(p => p.GetType() == typeof(CheeseBurger)));
        }

        [TestMethod]
        public void PreparedProducts_CheckRemoveProducts_Test()
        {
            PreparedProducts preparedProducts = new PreparedProducts();
            preparedProducts.Add(new CocaCola(21));
            preparedProducts.Add(new Fanta(14));
            preparedProducts.Add(new Tea(22));
            preparedProducts.Add(new CheeseBurger(17));
            preparedProducts.Add(new CheeseBurger(23));
            preparedProducts.Add(new Fanta(9));

            List<Product> input = new List<Product>();
            input.Add(new CocaCola(21));
            input.Add(new Fanta(14));
            input.Add(new Tea(22));

            preparedProducts.RemoveByType(input);
            Assert.AreEqual(3, preparedProducts.Products.Count());
            Assert.IsTrue(preparedProducts.Products.Count(p => p.GetType() == typeof(Fanta)) == 1);
            Assert.IsFalse(preparedProducts.Products.Any(p => p.GetType() == typeof(CocaCola)));
            Assert.IsFalse(preparedProducts.Products.Any(p => p.GetType() == typeof(Tea)));
        }

    }
    
}
