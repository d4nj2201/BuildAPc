using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingStock
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an of clsStock class
            clsStock AStock = new clsStock();
            //test the class exists
            Assert.IsNotNull(AStock);
        }

        [TestMethod]
        public void InStockPropOK()
        {
            //create an instance of clsStock class
            clsStock AStock = new clsStock();
            //create test data to assign to property
            Boolean TestData = true;
            //assign test data to property
            AStock.InStock = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.InStock, TestData);
        }

        [TestMethod]
        public void StockIDPropOK()
        {
            //create an instance of clsStock class
            clsStock AStock = new clsStock();
            //create test data to assign to property
            int TestData = 1;
            //assign test data to property
            AStock.StockID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.StockID, TestData);
        }

        [TestMethod]
        public void DescriptionPropOK()
        {
            //create an instance of clsStock class
            clsStock AStock = new clsStock();
            //create test data to assign to property
            string TestData = "test description";
            //assign test data to property
            AStock.Description = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Description, TestData);
        }

        [TestMethod]
        public void LastEditedPropOK()
        {
            //create an instance of clsStock class
            clsStock AStock = new clsStock();
            //create test data to assign to property
            DateTime TestData = DateTime.Now.Date;
            //assign test data to property
            AStock.LastEdited = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.LastEdited, TestData);
        }

        [TestMethod]
        public void PricePropOK()
        {
            //create an instance of clsStock class
            clsStock AStock = new clsStock();
            //create test data to assign to property
            double TestData = 65.99;
            //assign test data to property
            AStock.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Price, TestData);
        }

        [TestMethod]
        public void QuantityPropOK()
        {
            //create an instance of clsStock class
            clsStock AStock = new clsStock();
            //create test data to assign to property
            int TestData = 5;
            //assign test data to property
            AStock.Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Quantity, TestData);
        }
    }
}
