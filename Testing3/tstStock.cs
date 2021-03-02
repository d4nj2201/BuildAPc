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

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of clsStock class
            clsStock AStock = new clsStock();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StockID = 13;
            //Invoke the method
            Found = AStock.Find(StockID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStockIDFound()
        {
            //create an instance of clsStock class
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockID = 13;
            //Invoke the method
            Found = AStock.Find(StockID);
            //check the stock ID
            if(AStock.StockID != 13)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastEditedFound()
        {
            //create an instance of clsStock class
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockID = 13;
            //Invoke the method
            Found = AStock.Find(StockID);
            //check the property
            if (AStock.LastEdited != Convert.ToDateTime("13/02/2021"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDescriptionFound()
        {
            //create an instance of clsStock class
            clsStock AStock = new clsStock();
            //boolean variable to store result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockID = 13;
            //Invoke the method
            Found = AStock.Find(StockID);
            //check the property
            if (AStock.Description != "CORSAIR VENGEANCE DDR4 16GB 3200MHZ")
            {
                OK = false;
            }
            //test to see if result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            //create an instance of clsStock class
            clsStock AStock = new clsStock();
            //boolean variable to store result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockID = 13;
            //Invoke the method
            Found = AStock.Find(StockID);
            //check the property
            if (AStock.Price != Convert.ToDouble("64.99"))
            {
                OK = false;
            }
            //test to see if result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQuantityFound()
        {
            //create an instance of clsStock class
            clsStock AStock = new clsStock();
            //boolean variable to store result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockID = 13;
            //Invoke the method
            Found = AStock.Find(StockID);
            //check the property
            if (AStock.Quantity != Convert.ToInt32("100"))
            {
                OK = false;
            }
            //test to see if result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestInStockFound()
        {
            //create an instance of clsStock class
            clsStock AStock = new clsStock();
            //boolean variable to store result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockID = 13;
            //Invoke the method
            Found = AStock.Find(StockID);
            //check the property
            if (AStock.InStock != Convert.ToBoolean("true"))
            {
                OK = false;
            }
            //test to see if result is correct
            Assert.IsTrue(OK);
        }
    }
}
