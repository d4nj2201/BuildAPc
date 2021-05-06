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
            if (AnOrder.ID != 1){
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
    }
}
