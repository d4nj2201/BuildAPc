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
        private DateTime mDateAdded;
        //DateAdded public property.
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
            //create an instanace of the data connection.
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the order ID to search for
            DB.AddParameter("@ID", ID);
            //execute the stored procedure.
            DB.Execute("sproc_tblAddress_FilterByAddressNo");
            //if one record is found
            if (DB.Count == 1)
            {
                //set the private data members to the test data value.
                mID = Convert.ToInt32(DB.DataTable.Rows[0]["ID"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mTown = Convert.ToString(DB.DataTable.Rows[0]["Town"]);
                mDelivered = Convert.ToBoolean(DB.DataTable.Rows[0]["Delivered"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mContents = Convert.ToString(DB.DataTable.Rows[0]["Contents"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mTotal = Convert.ToDouble(DB.DataTable.Rows[0]["Total"]);
                mPayed = Convert.ToBoolean(DB.DataTable.Rows[0]["Payed"]);
                //return that everything worked.
                return true;
            }
            //if no record was found.
            else
            {
                //return flace indicating a problem.
                return false;
            }
        }
    }
}