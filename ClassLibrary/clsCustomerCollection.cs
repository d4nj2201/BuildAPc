using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {

        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //public property for the customer list
        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }
        //public property for the count
        public int Count
        {
            get
            {
                //return the count of the list
                return mCustomerList.Count;
            }
            set
            {
                //later
            }
        }

        public clsCustomer ThisCustomer { get; set; }


        //constructor for the class
        public clsCustomerCollection()
        {
            //create the items of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerId = 1;
            TestItem.Username = "username";
            TestItem.Password = "password";
            TestItem.Address = "some address";
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to the test list
            mCustomerList.Add(TestItem);
            //reinitialise the object for some new data
            TestItem = new clsCustomer();
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerId = 2;
            TestItem.Username = "username2";
            TestItem.Password = "password2";
            TestItem.Address = "some address2";
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to the test list
            mCustomerList.Add(TestItem);
        }

    }
}