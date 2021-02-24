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


        public bool Find(int customerId)
        {
            mCustomerId = 1;
            mDateAdded = Convert.ToDateTime("20/02/2021");
            mUsername = "doha";
            mPassword = "password";
            mAddress = "36 Treehill Road LE3 7GH";
            mActive = true;
            //always return true
            return true;
        }

        public string Valid(string username, string password, string address, string dateAdded)
        {
            return "";
        }
    }
}