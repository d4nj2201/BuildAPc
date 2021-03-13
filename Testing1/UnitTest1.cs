using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test_Framework
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            // Create new instance of the class we want to create
            clsStaffCollection AStaff = new clsStaffCollection();
            // test to see that it exists
            Assert.IsNotNull(AStaff);
        }
        [TestMethod]
        public void StaffListOk()
        {
            // Create new instance of the class we want to create
            clsStaffCollection AStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the iem of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.IsWorking = true;
            TestItem.StaffId = 1;
            TestItem.FullName = "Mary Sproggins";
            TestItem.PhoneNumber = "01234835071";
            TestItem.HourlyWage = 8.7;
            TestItem.DateOfBirth = Convert.ToDateTime("03/09/1990");
            // add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AStaff.StaffList = TestList;
            // test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffList, TestList);
        }
        
        [TestMethod]
        public void ThisStaffPropertyOk()
        {
            // Create new instance of the class we want to create
            clsStaffCollection AStaff = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            // set the properties of the test object
            TestStaff.IsWorking = true;
            TestStaff.StaffId = 1;
            TestStaff.FullName = "Mary Sproggins";
            TestStaff.PhoneNumber = "01234835071";
            TestStaff.HourlyWage = 8.7;
            TestStaff.DateOfBirth = Convert.ToDateTime("03/09/1990");
            //assign the data to the property
            AStaff.ThisStaff = TestStaff;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.ThisStaff, TestStaff);

        }
        [TestMethod]
        public void ListAndCountOK()
        {
            // Create new instance of the class we want to create
            clsStaffCollection AStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the iem of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.IsWorking = true;
            TestItem.StaffId = 1;
            TestItem.FullName = "Mary Sproggins";
            TestItem.PhoneNumber = "01234835071";
            TestItem.HourlyWage = 8.7;
            TestItem.DateOfBirth = Convert.ToDateTime("03/09/1990");
            // add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AStaff.StaffList = TestList;
            // test to see that the two values are the same
            Assert.AreEqual(AStaff.Count, TestList.Count);
        }
       
    }
    }
    

