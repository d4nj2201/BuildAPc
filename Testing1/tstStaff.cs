using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {


        //Good test data
        //create some test data to pass to the method
        String StaffId = "1";
        String FullName = "Josh Harrison";
        String HourlyWage = "8.6";
        String DateOfBirth = DateTime.Now.Date.ToString();
        String PhoneNumber = "07759188304";

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
        [TestMethod]
        public void FindMethodOk()
        {
            // Create new instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // Create test data
            Boolean Found = true;
            // Create some test data to use the method with
            int Id = 1;
            // invoke the method
            Found = AStaff.Find(Id);
            // Test to see that the value is present
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestFullNameFound()
        {
            // Create new instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean varaible to store the result of the search
            Boolean Found = false;
            // boolean variable to record if data is ok(Assume it it)
            Boolean OK = true;
            // Create some test data to use the method with
            int Id = 1;
            // invoke the method
            Found = AStaff.Find(Id);
            //check the name
            if(AStaff.FullName != "Josh Harrison")
            {
                OK = false;
            }
            // Test to see that the value is present
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateOfBirthFound()
        {
            // Create new instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean varaible to store the result of the search
            Boolean Found = false;
            // boolean variable to record if data is ok(Assume it it)
            Boolean OK = true;
            // Create some test data to use the method with
            int Id = 1;
            // invoke the method
            Found = AStaff.Find(Id);
            //check the name
            if (AStaff.DateOfBirth != Convert.ToDateTime("07/11/2000"))
            {
                OK = false;
            }
            // Test to see that the value is present
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPhoneNumberFound()
        {
            // Create new instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean varaible to store the result of the search
            Boolean Found = false;
            // boolean variable to record if data is ok(Assume it it)
            Boolean OK = true;
            // Create some test data to use the method with
            int Id = 1;
            // invoke the method
            Found = AStaff.Find(Id);
            //check the name
            if (AStaff.PhoneNumber != ("07759188304"))
            {
                OK = false;
            }
            // Test to see that the value is present
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestHourlyWageFound()
        {
            // Create new instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean varaible to store the result of the search
            Boolean Found = false;
            // boolean variable to record if data is ok(Assume it it)
            Boolean OK = true;
            // Create some test data to use the method with
            int Id = 1;
            // invoke the method
            Found = AStaff.Find(Id);
            //check the name
            if (AStaff.HourlyWage != Convert.ToDouble("8.5"))
            {
                OK = false;
            }
            // Test to see that the value is present
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffIdFound()
        {
            // Create new instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean varaible to store the result of the search
            Boolean Found = false;
            // boolean variable to record if data is ok(Assume it it)
            Boolean OK = true;
            // Create some test data to use the method with
            int Id = 1;
            // invoke the method
            Found = AStaff.Find(Id);
            //check the name
            if (AStaff.StaffId != 1)
            {
                OK = false;
            }
            // Test to see that the value is present
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOk()
        {
        // Create new instance of the class we want to create
        clsStaff AStaff = new clsStaff();
        // String varaible to store error message
        String Error = " ";
            // Invoke the method
            Error = AStaff.Valid(StaffId, FullName, DateOfBirth, HourlyWage, PhoneNumber);
        // test 
        Assert.AreEqual(Error, " ");
    }
        [TestMethod]
        public void FullNameMinMinusOne()
        {
            // Create new instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // String varaible to store error message
            String Error = " ";
            // create test value
            string FullName = ""; // this should fail
            //Invoke the method 
            Error = AStaff.Valid(StaffId, FullName, DateOfBirth, HourlyWage, PhoneNumber);
            // test to see that the value is correct
            Assert.AreNotEqual(Error, " ");
        }
        [TestMethod]
        public void FullNameMin()
        {
            // Create new instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // String varaible to store error message
            String Error = " ";
            // create test value
            string FullName = "A"; // this should be okay
            //Invoke the method 
            Error = AStaff.Valid(StaffId, FullName, DateOfBirth, HourlyWage, PhoneNumber);
            // test to see that the value is correct
            Assert.AreEqual(Error, " ");
        }
        [TestMethod]
        public void FullNameMinPlusOne()
        {
            // Create new instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // String varaible to store error message
            String Error = " ";
            // create test value
            string FullName = "AA"; // this should be okay
            //Invoke the method 
            Error = AStaff.Valid(StaffId, FullName, DateOfBirth, HourlyWage, PhoneNumber);
            // test to see that the value is correct
            Assert.AreEqual(Error, " ");
        }

        [TestMethod]
        public void FullNameMaxMinusOne()
        {
            // Create new instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // String varaible to store error message
            String Error = " ";
            // create test value
            string FullName = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"; // this should be okay
            //Invoke the method 
            Error = AStaff.Valid(StaffId, FullName, DateOfBirth, HourlyWage, PhoneNumber);
            // test to see that the value is correct
            Assert.AreEqual(Error, " ");
        }
        [TestMethod]
        public void FullNameMax()
        {
            // Create new instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // String varaible to store error message
            String Error = " ";
            // create test value
            string FullName = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"; // this should be okay
            //Invoke the method 
            Error = AStaff.Valid(StaffId, FullName, DateOfBirth, HourlyWage, PhoneNumber);
            // test to see that the value is correct
            Assert.AreEqual(Error, " ");
        }
        [TestMethod]
        public void FullNameMaxPlusOne()
        {
            // Create new instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // String varaible to store error message
            String Error = " ";
            // create test value
            string FullName = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"; // this should Fail
            //Invoke the method 
            Error = AStaff.Valid(StaffId, FullName, DateOfBirth, HourlyWage, PhoneNumber);
            // test to see that the value is correct
            Assert.AreNotEqual(Error, " ");
        }
        [TestMethod]
        public void FullNameMid()
        {
            // Create new instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // String varaible to store error message
            String Error = " ";
            // create test value
            string FullName = "AAAAAAAAAAAAAAAAAAAAAAAAA"; // this should be okay
            //Invoke the method 
            Error = AStaff.Valid(StaffId, FullName, DateOfBirth, HourlyWage, PhoneNumber);
            // test to see that the value is correct
            Assert.AreEqual(Error, " ");
        }

        [TestMethod]
        public void FullNameExtremeMax()
        {
            // Create new instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // String varaible to store error message
            String Error = " ";
            // create test value
            string FullName = "";
            FullName = FullName.PadRight(500, 'A'); // this should fail
            //Invoke the method 
            Error = AStaff.Valid(StaffId, FullName, DateOfBirth, HourlyWage, PhoneNumber);
            // test to see that the value is correct
            Assert.AreNotEqual(Error, " ");
        }
        [TestMethod]
        public void DateOfBirthMaxMinusOne()
        {
            // Create new instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // String varaible to store error message
            String Error = " ";
            // create test value
            DateTime TestDate;
            TestDate = (DateTime.Now.Date);
            TestDate = TestDate.AddDays(-1);
            string DateOfBirth = TestDate.ToString(); // this should be okay
            //Invoke the method 
            Error = AStaff.Valid(StaffId, FullName, DateOfBirth, HourlyWage, PhoneNumber);
            // test to see that the value is correct
            Assert.AreEqual(Error, " ");
        }
        [TestMethod]
        public void DateOfBirthMax()
        {
            // Create new instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // String varaible to store error message
            String Error = " ";
            // create test value
            DateTime TestDate;
            TestDate = (DateTime.Now.Date);
            string DateOfBirth = TestDate.ToString(); // this should be okay
            //Invoke the method 
            Error = AStaff.Valid(StaffId, FullName, DateOfBirth, HourlyWage, PhoneNumber);
            // test to see that the value is correct
            Assert.AreEqual(Error, " ");
        }
        [TestMethod]
        public void DateOfBirthMaxPlusOne()
        {
            // Create new instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // String varaible to store error message
            String Error = " ";
            // create test value
            DateTime TestDate;
            TestDate = (DateTime.Now.Date);
            TestDate = TestDate.AddDays(1);
            string DateOfBirth = TestDate.ToString(); // this should fail
            //Invoke the method 
            Error = AStaff.Valid(StaffId, FullName, DateOfBirth, HourlyWage, PhoneNumber);
            // test to see that the value is correct
            Assert.AreNotEqual(Error, " ");
        }
        [TestMethod]
        public void DateOfBirthExtrememax()
        {
            // Create new instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // String varaible to store error message
            String Error = " ";
            // create test value
            DateTime TestDate;
            TestDate = (DateTime.Now.Date);
            TestDate = TestDate.AddYears(20);
            string DateOfBirth = TestDate.ToString(); // this should fail
            //Invoke the method 
            Error = AStaff.Valid(StaffId, FullName, DateOfBirth, HourlyWage, PhoneNumber);
            // test to see that the value is correct
            Assert.AreNotEqual(Error, " ");
        }
        [TestMethod]
        public void DateOfBirthInvalidType()
        {
            // Create new instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // String varaible to store error message
            String Error = " ";
            // create test value
            string DateOfBirth = "This is not a date!"; // this should fail
            //Invoke the method 
            Error = AStaff.Valid(StaffId, FullName, DateOfBirth, HourlyWage, PhoneNumber);
            // test to see that the value is correct
            Assert.AreNotEqual(Error, " ");
        }
        [TestMethod]
        public void PhoneNumberMinMinusOne()
        {
            // Create new instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // String varaible to store error message
            String Error = " ";
            // create test value
            string PhoneNumber =""; 
            PhoneNumber = PhoneNumber.PadRight(10,'1'); // this should fail
            //Invoke the method 
            Error = AStaff.Valid(StaffId, FullName, DateOfBirth, HourlyWage, PhoneNumber);
            // test to see that the value is correct
            Assert.AreNotEqual(Error, " ");
        }
        [TestMethod]
        public void PhoneNumberMin()
        {
            // Create new instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // String varaible to store error message
            String Error = " ";
            // create test value
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(11, '1'); // this should pass
            //Invoke the method 
            Error = AStaff.Valid(StaffId, FullName, DateOfBirth, HourlyWage, PhoneNumber);
            // test to see that the value is correct
            Assert.AreEqual(Error, " ");
        }
        [TestMethod]
        public void PhoneNumberMinPlusOne()
        {
            // Create new instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // String varaible to store error message
            String Error = " ";
            // create test value
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(12, '1'); // this should fail
            //Invoke the method 
            Error = AStaff.Valid(StaffId, FullName, DateOfBirth, HourlyWage, PhoneNumber);
            // test to see that the value is correct
            Assert.AreNotEqual(Error, " ");
        }
        [TestMethod]
        public void HourlyWageMinMinusOne()
        {
            // Create new instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // String varaible to store error message
            String Error = " ";
            // create test value
            double TestWage = 4.05 ;
            HourlyWage = Convert.ToString(TestWage); // this should fail
            //Invoke the method 
            Error = AStaff.Valid(StaffId, FullName, DateOfBirth, HourlyWage, PhoneNumber);
            // test to see that the value is correct
            Assert.AreNotEqual(Error, " ");
        }
        [TestMethod]
        public void HourlyWageExtremeMin()
        {
            // Create new instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // String varaible to store error message
            String Error = " ";
            // create test value
            double TestWage = 1;
            HourlyWage = Convert.ToString(TestWage); // this should fail
            //Invoke the method 
            Error = AStaff.Valid(StaffId, FullName, DateOfBirth, HourlyWage, PhoneNumber);
            // test to see that the value is correct
            Assert.AreNotEqual(Error, " ");
        }
        [TestMethod]
        public void HourlyWageMinPlusOne()
        {
            // Create new instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // String varaible to store error message
            String Error = " ";
            // create test value
            double TestWage = 5.15;
            HourlyWage = Convert.ToString(TestWage); // this should pass
            //Invoke the method 
            Error = AStaff.Valid(StaffId, FullName, DateOfBirth, HourlyWage, PhoneNumber);
            // test to see that the value is correct
            Assert.AreEqual(Error, " ");
        }
        [TestMethod]
        public void HourlyWageMin()
        {
            // Create new instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // String varaible to store error message
            String Error = " ";
            // create test value
            double TestWage = 4.15;
            HourlyWage = Convert.ToString(TestWage); // this should pass
            //Invoke the method 
            Error = AStaff.Valid(StaffId, FullName, DateOfBirth, HourlyWage, PhoneNumber);
            // test to see that the value is correct
            Assert.AreEqual(Error, " ");
        }
        [TestMethod]
        public void AddMethodOk()
        {
            // Create new instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            // creat the item of test data
            clsStaff TestItem = new clsStaff();
            // Var to store primary key
            Int32 PrimaryKey = 0;
            // set its properties
            TestItem.IsWorking = true;
            TestItem.FullName = "Natasha Longboy";
            TestItem.HourlyWage = 7.5;
            TestItem.PhoneNumber = "07759188504";
            TestItem.DateOfBirth = Convert.ToDateTime("09 / 03 / 1986");
            // Set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            // add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            // find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            // Test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
            }
    }
}