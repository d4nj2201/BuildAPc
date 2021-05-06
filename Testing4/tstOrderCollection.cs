using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingOrders;
using ClassLibrary;
using System.Collections.Generic;

namespace Test_Framework
{
    [TestClass]
    class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create.
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see that it exists.
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data, in this case needs to be a list of objects.
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list.
            //create hte item of test data.
            clsOrder TestItem = new clsOrder();
            //set its properties.
            TestItem.Contents = "some stuff";
            TestItem.CustomerID = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Delivered = true;
            TestItem.ID = 1;
            TestItem.Name = "Patrick";
            TestItem.Payed = true;
            TestItem.Total = 1.00;
            TestItem.Town = "leicester";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property.
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same.
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Int32 SomeCount = 0;
            AllOrders.Count = SomeCount;
            Assert.AreEqual(AllOrders.Count, SomeCount);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();
            TestOrder.Contents = "some stuff";
            TestOrder.CustomerID = 1;
            TestOrder.DateAdded = DateTime.Now.Date;
            TestOrder.Delivered = true;
            TestOrder.ID = 1;
            TestOrder.Name = "Patrick";
            TestOrder.Payed = true;
            TestOrder.Total = 1.00;
            TestOrder.Town = "leicester";
            //assign the data to the property.
            AllOrders.ThisOrder = TestOrder;
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.Contents = "some stuff";
            TestItem.CustomerID = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Delivered = true;
            TestItem.ID = 1;
            TestItem.Name = "Patrick";
            TestItem.Payed = true;
            TestItem.Total = 1.00;
            TestItem.Town = "leicester";
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.AreEqual(AllOrders.Count, 2);
        }

    }
}
