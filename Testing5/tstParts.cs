using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingParts
{
    [TestClass]
    public class tstParts
    {
        [TestMethod]
        public void TestMethod1()
        {
            //creates a instance of the class we want to create
            clsParts aPart = new clsParts();
            //test to see if it exists
            Assert.IsNotNull(aPart);
        }
    }
}
