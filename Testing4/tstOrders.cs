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
            Int32 TestData = 1234;
            AnOrder.ID = TestData;
            Assert.AreEqual(AnOrder.ID, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 1234;
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
    }
}
