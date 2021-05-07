using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingOrders
{
    [TestClass]
    public class tstOrders
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void PayedPropertyOK()
        {
            //create an instance of the class we wnat to create.
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property.
            Boolean TestData = true;
            //assing the data to the property.
            AnOrder.Payed = TestData;
            //test to see that the two values are the same.
            Assert.AreEqual(AnOrder.Payed, TestData);
        }

        [TestMethod]
        public void DeliveryTimePropertyOK()
        {
            //create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property.
            //test
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property.
            AnOrder.DateAdded = TestData;
            //test to see that the two values are equal.
            Assert.AreEqual(AnOrder.DateAdded, TestData);
        }


        [TestMethod]
        public void AddressPropertyOK()
        {
            //create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property.
            string TestData = "Leicester";
            //assign the data to the property.
            AnOrder.Town = TestData;
            //test to see that the two values are equal.
            Assert.AreEqual(AnOrder.Town, TestData);
        }


        [TestMethod]
        public void DeliveredPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean TestData = true;
            AnOrder.Delivered = TestData;
            Assert.AreEqual(AnOrder.Delivered, TestData);
        }

        [TestMethod]
        public void FullNamePropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            string TestData = "Patrick Carroll";
            AnOrder.Name = TestData;
            Assert.AreEqual(AnOrder.Name, TestData);
        }

        [TestMethod]
        public void OrderContentsPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            string TestData = "some motherboard";
            AnOrder.Contents = TestData;
            Assert.AreEqual(AnOrder.Contents, TestData);
        }

        [TestMethod]
        public void OrderIDPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 1;
            AnOrder.ID = Convert.ToInt32(TestData);
            Assert.AreEqual(AnOrder.ID, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 1;
            AnOrder.CustomerID = TestData;
            Assert.AreEqual(AnOrder.CustomerID, TestData);
        }

        [TestMethod]
        public void TotalPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Double TestData = 20.0;
            AnOrder.Total = TestData;
            Assert.AreEqual(AnOrder.Total, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the results of the validation.
            Boolean Found = false;
            //create some test data to use with the method.
            Int32 ID = 1;
            //invoke the method.
            Found = AnOrder.Find(ID);
            //test to see if the result is true.
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestTownNoFound()
        {
            //create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search.
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is).
            Boolean OK = true;
            //create some test data to use with the method.
            Int32 ID = 1;
            //invoke the method.
            Found = AnOrder.Find(ID);
            //check the Total
            if (AnOrder.ID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ID = 1;
            Found = AnOrder.Find(ID);
            if (AnOrder.DateAdded != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTownFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ID = 1;
            Found = AnOrder.Find(ID);
            if (AnOrder.Town != Convert.ToString("test"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDeliveredFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ID = 1;
            Found = AnOrder.Find(ID);
            if (AnOrder.Delivered != Convert.ToBoolean(false))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNameFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ID = 1;
            Found = AnOrder.Find(ID);
            if (AnOrder.Name != Convert.ToString("patrick"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestContentsFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ID = 1;
            Found = AnOrder.Find(ID);
            if (AnOrder.Contents != Convert.ToString("contents"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustomerIDFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ID = 1;
            Found = AnOrder.Find(ID);
            if (AnOrder.CustomerID != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TotalFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ID = 1;
            Found = AnOrder.Find(ID);
            if (AnOrder.Total != 1.00)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PayedFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ID = 1;
            Found = AnOrder.Find(ID);
            if (AnOrder.Payed != Convert.ToBoolean(true))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create.
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key.
            Int32 PrimaryKey = 0;
            //set its properties.
            TestItem.Contents = "some contents";
            TestItem.CustomerID = 123;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Delivered = true;
            TestItem.ID = 123;
            TestItem.Name = "Patrick";
            TestItem.Payed = true;
            TestItem.Total = 1.00;
            TestItem.Town = "Leicester";
            //set ThisOrder to the test data.
            AllOrders.ThisOrder = TestItem;
            //add the record.
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data.
            TestItem.ID = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same.
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class.
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data.
            clsOrder TestItem = new clsOrder();
            //PK var
            Int32 PrimaryKey = 0;
            //set its properties.
            TestItem.Contents = "some contents";
            TestItem.CustomerID = 123;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Delivered = true;
            TestItem.ID = 123;
            TestItem.Name = "Patrick";
            TestItem.Payed = true;
            TestItem.Total = 1.00;
            TestItem.Town = "Leicester";
            //set thisOrder to the test data.
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data.
            TestItem.ID = PrimaryKey;
            //modify the test data.
            TestItem.Contents = "not some contents";
            TestItem.CustomerID = 1234;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Delivered = false;
            TestItem.ID = 1234;
            TestItem.Name = "Not Patrick";
            TestItem.Payed = false;
            TestItem.Total = 2.00;
            TestItem.Town = "Not Leicester";
            //set the record based on the new test data.
            AllOrders.ThisOrder = TestItem;
            //update the record.
            AllOrders.Update();
            //find the record.
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see thisOrder matches the test data.
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the test item of data.
            clsOrder TestItem = new clsOrder();
            //var to store primary key.
            Int32 PrimaryKey = 0;
            //set its properties.
            TestItem.Contents = "some contents";
            TestItem.CustomerID = 123;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Delivered = true;
            TestItem.ID = 123;
            TestItem.Name = "Patrick";
            TestItem.Payed = true;
            TestItem.Total = 1.00;
            TestItem.Town = "Leicester";
            //set thisOrder to the test data.
            AllOrders.ThisOrder = TestItem;
            //add the record.
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data.
            TestItem.ID = PrimaryKey;
            //find the record.
            AllOrders.ThisOrder.Find(PrimaryKey);
            //delete the record.
            AllOrders.Delete();
            //now find the record
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the record was not found.
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByNameMethodOK()
        {
            //create an instance of the class containing unfiltered results.
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create an instance of the filtered data.
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //apply a blank string (should return all records).
            FilteredOrders.ReportByName("");
            //test to see that the two values are equal.
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByNameNoneFound()
        {
            //create an instance of the filtered data.
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //apply a Name that doesn't exist.
            FilteredOrders.ReportByName("randomName");
            //test to see that there are no records.
            Assert.AreEqual(0, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByNameTestDataFound()
        {
            //create an instance of the filtered data.
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //var to store the outcome.
            Boolean OK = true;
            //apply a name that doens't exist.
            FilteredOrders.ReportByName("noname");
            //check that the correct number of records are found.
            if (FilteredOrders.Count == 2)
            {
                //check that the first record is ID 36
                if (FilteredOrders.OrderList[0].ID != 36)
                {
                    OK = false;
                }
                //check that the first record is ID 37
                if (FilteredOrders.OrderList[1].ID != 37)
                {
                    OK = false;
                }
                else
                {
                    OK = false;
                }
                //test to see that there are no records.
                Assert.IsTrue(OK);
            }
        }
    }
}
