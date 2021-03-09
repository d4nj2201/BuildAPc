using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingStock
{
    [TestClass]
    public class tstStock
    {
        //good test data
        string StockID = "13";
        string Description = "AMD RYZEN 5 5600X";
        string LastEdited = DateTime.Now.Date.ToString();
        string Price = "325.99";
        string Quantity = "10";
        //string InStock = "true";

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

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of clsStock class
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //invoke the method
            Error = AStock.Valid(StockID, Description, LastEdited, Price, Quantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //StockID validation tests
        /**[TestMethod]
        public void StockIDMinLessOne()
        {
            //create an instance of the clsStock class
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            int TestID = 0; //this should trigger an error
            //convert integer to string
            string StockID = TestID.ToString();
            //invoke the method
            Error = AStock.Valid(StockID, Description, LastEdited, Price, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockIDInvalidData()
        {
            //create an instance of the clsStock class
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string StockID = "this is not a stock ID!";
            //invoke the method
            Error = AStock.Valid(StockID, Description, LastEdited, Price, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }**/

        //Description validation tests
        [TestMethod]
        public void DescriptionMinLessOne()
        {
            //create an instance of clsStock class
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Description = ""; //this should trigger an error
            //invoke the method
            Error = AStock.Valid(StockID, Description, LastEdited, Price, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMin()
        {
            //create an instance of clsStock class
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Description = "a"; //this should work
            //invoke the method
            Error = AStock.Valid(StockID, Description, LastEdited, Price, Quantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMinPlusOne()
        {
            //create a new instance of clsStock class
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Description = "aa";
            //invoke the method
            Error = AStock.Valid(StockID, Description, LastEdited, Price, Quantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMid()
        {
            //create a new instance of clsStock class
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Description = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AStock.Valid(StockID, Description, LastEdited, Price, Quantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMaxLessOne()
        {
            //create an instance of the clsStock class
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Description = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AStock.Valid(StockID, Description, LastEdited, Price, Quantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMax()
        {
            //create an instance of clsStock class
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Description = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AStock.Valid(StockID, Description, LastEdited, Price, Quantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMaxPlusOne()
        {
            //create an instance of clsStock class
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Description = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AStock.Valid(StockID, Description, LastEdited, Price, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionExtremeMax()
        {
            //create a new instance of clsStock class
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to method
            string Description = "";
            Description = Description.PadRight(500, 'a');
            //invoke the method
            Error = AStock.Valid(StockID, Description, LastEdited, Price, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        // LastEdited validation tests
        [TestMethod]
        public void LastEditedExtremeMin()
        {
            //create an instance of clsStock class
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100); //this should trigger an error
            //convert to date to string
            string LastEdited = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(StockID, Description, LastEdited, Price, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastEditedMinLessOne()
        {
            //create an instance of clsStock class
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1); //this should trigger an error
            //convert date to string
            string LastEdited = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(StockID, Description, LastEdited, Price, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastEditedMin()
        {
            //create an instance of clsStock class
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            DateTime TestDate = DateTime.Now.Date; //this should work
            //convert date to string
            string LastEdited = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(StockID, Description, LastEdited, Price, Quantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastEditedMinPlusOne()
        {
            //create a new instance of clsStock class
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            //convert date to string
            string LastEdited = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(StockID, Description, LastEdited, Price, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastEditedExtremeMax()
        {
            //create a new instance of clsStock class
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            //convert date to string
            string LastEdited = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(StockID, Description, LastEdited, Price, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastEditedInvalidData()
        {
            //create an instance of the clsStock class
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string LastEdited = "this is not a date!";
            //invoke the method
            Error = AStock.Valid(StockID, Description, LastEdited, Price, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //Price validation tests
        [TestMethod]
        public void PriceMinLessOne()
        {
            //create an instance of clsStock class
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            double TestPrice = 0.00; //this should trigger an error
            //convert double to string
            string Price = Convert.ToString(TestPrice);
            //invoke the method
            Error = AStock.Valid(StockID, Description, LastEdited, Price, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            //create an instance of clsStock class
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            double TestPrice = 0.01; //this should work
            //convert double to string
            string Price = Convert.ToString(TestPrice);
            //invoke the method
            Error = AStock.Valid(StockID, Description, LastEdited, Price, Quantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            //create a new instance of clsStock class
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            double TestPrice = 0.02; //this should work
            //convert double to string
            string Price = Convert.ToString(TestPrice);
            //invoke the method
            Error = AStock.Valid(StockID, Description, LastEdited, Price, Quantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceInvalidData()
        {
            //create an instance of the clsStock class
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Price = "this is not a price!";
            //invoke the method
            Error = AStock.Valid(StockID, Description, LastEdited, Price, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //Quantity validation tests
        [TestMethod]
        public void QuantityMinLessOne()
        {
            //create an instance of clsStock class
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            int TestQuantity = -1; //this should trigger an error
            //convert integer to string
            string Quantity = TestQuantity.ToString();
            //invoke the method
            Error = AStock.Valid(StockID, Description, LastEdited, Price, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMin()
        {
            //create an instance of clsStock class
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            int TestQuantity = 0; //this should work
            //convert integer to string
            string Quantity = TestQuantity.ToString();
            //invoke the method
            Error = AStock.Valid(StockID, Description, LastEdited, Price, Quantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinPlusOne()
        {
            //create a new instance of clsStock class
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            int TestQuantity = 1;
            //convert integer to string
            string Quantity = TestQuantity.ToString();
            //invoke the method
            Error = AStock.Valid(StockID, Description, LastEdited, Price, Quantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityInvalidData()
        {
            //create an instance of the clsStock class
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Quantity = "this is not a quantity!";
            //invoke the method
            Error = AStock.Valid(StockID, Description, LastEdited, Price, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
