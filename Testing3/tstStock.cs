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
    }
}
