using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingCustomer
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Assert.IsNotNull(ACustomer);

        }
        [TestMethod]
        public void ActivePropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean TestData = true;
            ACustomer.Active = TestData;
            Assert.AreEqual(ACustomer.Active, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            ACustomer.DateAdded = TestData;
            Assert.AreEqual(ACustomer.DateAdded, TestData);
    

        }
        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Int16 TestData = 1;
            ACustomer.CustomerId = TestData;
            Assert.AreEqual(ACustomer.CustomerId, TestData);

        }
        [TestMethod]
        public void UsernamePropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "dohafekouss";
            ACustomer.Username = TestData;
            Assert.AreEqual(ACustomer.Username, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "password";
            ACustomer.Password = TestData;
            Assert.AreEqual(ACustomer.Password, TestData);
        }
        [TestMethod]
        public void AddressPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "36 Treehill Road LE3 7GD";
            ACustomer.Address = TestData;
            Assert.AreEqual(ACustomer.Address, TestData);
        }



    }
}
