using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingParts
{
    [TestClass]
    public class tstParts
    {
        [TestMethod]
        public void InstanceOk()
        {
            //creates a instance of the class we want to create
            clsParts aPart = new clsParts();
            //test to see if it exists
            Assert.IsNotNull(aPart);
        }

        [TestMethod]
        public void AvailablePropertyOk()
        {
            //create instance of class
            clsParts aPart = new clsParts();
            //create test data to assign to the property
            Boolean testData = true;
            //assign data to property
            aPart.Available = testData;
            //test the two values are the same
            Assert.AreEqual(aPart.Available, testData);
        }

        [TestMethod]
        public void DateAddedPropertyOk()
        {
            //create instance of class
            clsParts aPart = new clsParts();
            //create test data to assign to the property
            DateTime testData = DateTime.Now.Date;
            //assign data to property
            aPart.DateAdded = testData;
            //test the two values are the same
            Assert.AreEqual(aPart.DateAdded, testData);
        }

        [TestMethod]
        public void PartIdOk()
        {
            //create instance of class
            clsParts aPart = new clsParts();
            //create test data to assign to the property
            Int32 testData = 123456;
            //assign data to property
            aPart.PartId = testData;
            //test the two values are the same
            Assert.AreEqual(aPart.PartId, testData);
        }
        [TestMethod]
        public void PartDescriptionOk()
        {
            //create instance of class
            clsParts aPart = new clsParts();
            //create test data to assign to the property
            String testData = "asus b450-m mini itx motherboard";
            //assign data to property
            aPart.PartDescription = testData;
            //test the two values are the same
            Assert.AreEqual(aPart.PartDescription, testData);
        }
        [TestMethod]
        public void PartTypeOk()
        {
            //create instance of class
            clsParts aPart = new clsParts();
            //create test data to assign to the property
            String testData = "Motherboard";
            //assign data to property
            aPart.PartType = testData;
            //test the two values are the same
            Assert.AreEqual(aPart.PartType, testData);
        }
        [TestMethod]
        public void PriceOk()
        {
            //create instance of class
            clsParts aPart = new clsParts();
            //create test data to assign to the property
            double testData = 155.99;
            //assign data to property
            aPart.Price = testData;
            //test the two values are the same
            Assert.AreEqual(aPart.Price, testData);
        }
        [TestMethod]
        public void WattageOk()
        {
            //create instance of class
            clsParts aPart = new clsParts();
            //create test data to assign to the property
            Int32 testData = 85;
            //assign data to property
            aPart.Wattage = testData;
            //test the two values are the same
            Assert.AreEqual(aPart.Wattage, testData);
        }
        
        
    }
}
