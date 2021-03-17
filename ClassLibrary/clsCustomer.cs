using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private Int16 mCustomerId;
        public Int16 CustomerId
        {
            get
            {
                return mCustomerId;

            }
            set
            {
                mCustomerId = value;
            }
        }

        private bool mActive;
        public bool Active
        {
            get
            {
                return mActive;

            }
            set
            {
                mActive = value;
            }
        }

        private DateTime mDateAdded;
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;

            }
            set
            {
                mDateAdded = value;
            }
        }

        private string mUsername;
        public string Username
        {
            get
            {
                return mUsername;

            }
            set
            {
                mUsername = value;
            }
        }

        private string mPassword;
        public string Password
        {
            get
            {
                return mPassword;

            }
            set
            {
                mPassword = value;
            }
        }

        private string mAddress;
        public string Address
        {
            get
            {
                return mAddress;

            }
            set
            {
                mAddress = value;
            }
        }


        public bool Find(int CustomerId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer id to search for
            DB.AddParameter("@CustomerId", CustomerId);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerId = Convert.ToInt16(DB.DataTable.Rows[0]["CustomerId"]);
                mUsername = Convert.ToString(DB.DataTable.Rows[0]["Username"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string username, string password, string address, string dateAdded)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store the date values
            DateTime DateTemp;
            //if the Username is blank
            if (username.Length == 0)
            {
                //record the error
                Error = Error + "The Username may not be blank : ";
            }
            //if the username is greater than 10 characters
            if (username.Length > 10)
            {
                //record the error
                Error = Error + "The username must be less than 10 characters : ";
            }
            //copy the dateAdded value to the DateTemp variable
            DateTemp = Convert.ToDateTime(dateAdded);
            if (DateTemp < DateTime.Now.Date)
            {
                //record the error
                Error = Error + "The date cannot be in the past : ";
               
            }
            //check to see if the date is greater than today's date

            if (DateTemp > DateTime.Now.Date)
            {
                //record the error
                Error = Error + "The date cannot be in the future : ";
            }
            //return any error messages

            return Error;
        }

    }
}