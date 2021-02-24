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
    }
}