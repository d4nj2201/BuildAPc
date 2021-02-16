using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            // Create new instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // test to see that it exists
            Assert.IsNotNull(AStaff);
        }
        [TestMethod]
        public void IsWorkingPropertyOK()
        {
            // Create new instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // Create test data
            Boolean TestData = true;
            // Assign the data to the property
            AStaff.IsWorking = TestData;
            // Test to see if the two values are the same
            Assert.AreEqual(AStaff.IsWorking, TestData);
        }
        [TestMethod]
        public void DateOfBirthPropertyOK()
        {
            // Create new instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // Create test data
            DateTime TestData = DateTime.Now.Date;
            // Assign the data to the property
            AStaff.DateOfBirth = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AStaff.DateOfBirth, TestData);
        }
        [TestMethod]
        public void HourlyWagePropertyOK()
        {
            // Create new instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // Create test data
            Double TestData = 8.6;
            // Assign the data to the property
            AStaff.HourlyWage = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AStaff.HourlyWage, TestData);
        }
        [TestMethod]
        public void PhoneNumberPropertyOK()
        {
            // Create new instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // Create test data
            String TestData = "07759188305";
            // Assign the data to the property
            AStaff.PhoneNumber = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AStaff.PhoneNumber, TestData);
        }
        [TestMethod]
        public void FullNamePropertyOK()
        {
            // Create new instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // Create test data
            String TestData = "Josh Harrison";
            // Assign the data to the property
            AStaff.FullName = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AStaff.FullName, TestData);
        }
        [TestMethod]
        public void StaffIdPropertyOK()
        {
            // Create new instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // Create test data
            Int32 TestData = 543;
            // Assign the data to the property
            AStaff.StaffId = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffId, TestData);
        }
    }
}