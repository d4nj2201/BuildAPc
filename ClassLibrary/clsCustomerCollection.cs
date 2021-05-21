using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        int mCount;
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //int mCount;
        clsCustomer mThisCustomer = new clsCustomer();
     
        //constructor for the class
        public clsCustomerCollection()
        {
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mCustomerList = new List<clsCustomer>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank customer
                clsCustomer ACustomer = new clsCustomer();
                //read in the fields from the current record
                ACustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                ACustomer.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                ACustomer.Username = Convert.ToString(DB.DataTable.Rows[Index]["Username"]);
                ACustomer.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                ACustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                ACustomer.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                //add the record to the private data mamber
                mCustomerList.Add(ACustomer);
                //point at the next record
                Index++;
            }
        }
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

        //public property for This Customer
        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;

            }
            set
            {
                //set the private data
                mThisCustomer = value;
            }
        }

       // public clsCustomer mThisCustomer { get; private set; }



        public int Add()
        {
            //adds a new record to the database based on the values of mThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Username", mThisCustomer.Username);
            DB.AddParameter("@Password", mThisCustomer.Password);
            DB.AddParameter("@DateAdded", mThisCustomer.DateAdded);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@Active", mThisCustomer.Active);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            DB.AddParameter("@Username", mThisCustomer.Username);
            DB.AddParameter("@Password", mThisCustomer.Password);
            DB.AddParameter("@DateAdded", mThisCustomer.DateAdded);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@Active", mThisCustomer.Active);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");

        }

        public void ReportByUsername(string Username)
        {
            //filters the records based on a full or partial username
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the username parameter to the database
            DB.AddParameter("@Username", Username);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByUsername");
            //populate the array list with the data table
            PopulateArray(DB);

          
        }

    }
}

