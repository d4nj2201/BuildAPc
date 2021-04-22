using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;

namespace TestingStock
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class tstStockCollection
    {

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>

        [TestMethod]
        public void InstanceOk()      {
            clsStockCollection AllStock = new clsStockCollection();

            Assert.IsNotNull(AllStock);
        }

        [TestMethod]
        public void StockListOK()
        {
            //create an instance of the clsStockCollection class
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data
            //create a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.InStock = true;
            TestItem.StockID = 11;
            TestItem.Price = 64.99;
            TestItem.LastEdited = DateTime.Now.Date;
            TestItem.Quantity = 10;
            TestItem.Description = "Test Stock";
            //add item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStock.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.StockList, TestList);
        }

        /*[TestMethod]
        public void countPropertyOK()
        {
            //create an instance of the clsStockCollection class
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data
            Int32 SomeCount = 2;
            //assign data to the property
            AllStock.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.Count, SomeCount);
        }*/

        [TestMethod]
        public void ThisStockPropertyOK()
        {
            //create an instance of the clsStockCollection class
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data
            clsStock TestStock = new clsStock();
            //set the properties of test object
            TestStock.InStock = true;
            TestStock.StockID = 11;
            TestStock.Price = 64.99;
            TestStock.LastEdited = DateTime.Now.Date;
            TestStock.Quantity = 10;
            TestStock.Description = "Test Stock";
            //assign the data to the property
            AllStock.ThisStock = TestStock;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the clsStockCollection class
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data
            //create a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.InStock = true;
            TestItem.StockID = 11;
            TestItem.Price = 64.99;
            TestItem.LastEdited = DateTime.Now.Date;
            TestItem.Quantity = 10;
            TestItem.Description = "Test Stock";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStock.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }

        /*[TestMethod]
        public void TwoRecordsPresent()
        {
            //create an instance of the clsStockCollection class
            clsStockCollection AllStock = new clsStockCollection();
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.Count, 2);
        }*/

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the clsStockCollection class
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.InStock = true;
            TestItem.StockID = 11;
            TestItem.Price = 79.99;
            TestItem.LastEdited = DateTime.Now.Date;
            TestItem.Quantity = 150;
            TestItem.Description = "ASROCK B450M PRO4-F MOTHERBOARD";
            //set ThisStock to the test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.StockID = PrimaryKey;
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create 
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.InStock = true;
            TestItem.Price = 32.49;
            TestItem.LastEdited = DateTime.Now.Date;
            TestItem.Quantity = 125;
            TestItem.Description = "ORIGINAL MINT-IN-BOX WILL WEATON";
            //set ThisAddress to the test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.StockID = PrimaryKey;
            //modify the test data 
            TestItem.InStock = false;
            TestItem.Price = 3;
            TestItem.LastEdited = DateTime.Now.Date;
            TestItem.Quantity = 110;
            TestItem.Description = "SEASONIC PRIME PX 650W PSU";
            //set the record based on the new test data 
            AllStock.ThisStock = TestItem;
            //update the record 
            AllStock.Update();
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see ThisAddress matches the test data
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the clsStockCollection class
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.InStock = true;
            TestItem.StockID = 11;
            TestItem.Price = 79.99;
            TestItem.LastEdited = DateTime.Now.Date;
            TestItem.Quantity = 150;
            TestItem.Description = "ASROCK B450M PRO4-F MOTHERBOARD";
            //set ThisStock to the test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.StockID = PrimaryKey;
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //delete record
            AllStock.Delete();
            //now find the record
            Boolean Found = AllStock.ThisStock.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByDescriptionMethodOK()
        {
            //create an instance of the clsStockCollection class
            clsStockCollection AllStock = new clsStockCollection();
            //create an instance of the filtered data
            clsStockCollection FilteredStock = new clsStockCollection();
            //apply a blank string (should return all records)
            FilteredStock.ReportByDescription("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.Count, FilteredStock.Count);
        }

        [TestMethod]
        public void ReportByDescriptionNoneFound()
        {
            //create an instance of the filtered data
            clsStockCollection FilteredStock = new clsStockCollection();
            //apply a description that doesn't exist
            FilteredStock.ReportByDescription("ARCTIC MX-4 THERMAL PASTE");
            //test to see that the two values are the same
            Assert.AreEqual(0, FilteredStock.Count);
        }

        [TestMethod]
        public void ReportByDescriptionTestDataFound()
        {
            //create an instance of the filtered data
            clsStockCollection FilteredStock = new clsStockCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a Description that doesn't exist
            FilteredStock.ReportByDescription("COOLERMASTER MASTERBOX Q300L");
            //check that the correct number of records are found
            if (FilteredStock.Count == 2)
            {
                if (FilteredStock.StockList[0].StockID != 29)
                {
                    OK = false;
                }
                if (FilteredStock.StockList[1].StockID != 30)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}
