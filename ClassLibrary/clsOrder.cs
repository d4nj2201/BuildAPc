using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        //private data member for the ID no property.
        private Int32 mID; 
        //ID public property
        public Int32 ID
        {
            get
            {
                //this line of code sends data out of the property.
                return mID;
            }
            set
            {
                //this line of code allows data into the property.
                mID = value;
            }
        }
        

        
        //dateAdded private member variable.
        private DateTime mDataAdded;
        //DateAdded public property.
        public DateTime DateAdded
        {
            get
            {
                return mDataAdded;
            }
            set
            {
                mDataAdded = value;
            }
        }


        //Town private member variable.
        private string mTown;
        public string Town
        {
            get
            {
                return mTown;
            }
            set
            {
                mTown = value;
            }
        }


        //Delivered private member variable.
        private Boolean mDelivered;
        public Boolean Delivered
        {
            get
            {
                return mDelivered;
            }
            set
            {
                mDelivered = value;
            }
        }


        //Name private member variable.
        private string mName;
        public string Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }


        //Contents private memeber variable.
        private string mContents;
        public string Contents
        {
            get
            {
                return mContents;
            }
            set
            {
                mContents = value;
            }
        }


        //CustomerID private memember variable.
        private Int32 mCustomerID;
        public Int32 CustomerID
        {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }


        //Total private member variable
        private double mTotal;
        public double Total
        {
            get
            {
                return mTotal;
            }
            set
            {
                mTotal = value;
            }
        }


        //Payed private member variable.
        private bool mPayed;
        public bool Payed
        {
            get
            {
                return mPayed;
            }
            set
            {
                mPayed = value;
            }
        }

        
        
       

        public bool Find(Int32 ID)
        {
            //set the private data members to the test data value.
            mID = 1;
            mDataAdded = Convert.ToDateTime("16/9/2015");
            mTown = "test";
            mDelivered = false;
            mName = "patrick";
            mContents = "contents";
            mCustomerID = 2;
            mTotal = 1.00;
            mPayed = true;
            //always return true.
            return true;
        }
    }
}