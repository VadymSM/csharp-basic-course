using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using McDonalds.BL;


namespace McDonalds.BL.Tests
{
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
    }
}
