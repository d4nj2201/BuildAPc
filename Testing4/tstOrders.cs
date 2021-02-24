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
            AnOrder.Active = TestData;
            //test to see that the two values are the same.
            Assert.AreEqual(AnOrder.Active, TestData);
        }

        [TestMethod]
        public void DeliveryTimePropertyOK()
        {
            //create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property.
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property.
            AnOrder.DateAdded = TestData;
            //test to see that the two values are equal.
            Assert.AreEqual(AnOrder.DateAdded, TestData);
        }
    }
}
