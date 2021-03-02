using System;

namespace ClassLibrary
{
    public class clsStock
    {
        //private data member for the properties
        private Int32 mStockID;
        private DateTime mLastEdited;
        private string mDescription;
        private double mPrice;
        private Int32 mQuantity;
        private bool mInStock;

        public clsStock()
        {
        }

        public Boolean InStock
        {
            get
            {
                return mInStock;
            }
            set
            {
                mInStock = value;
            }
        }
        public Int32 StockID
        {
            get
            {
                //return the current value of StockID
                return mStockID;
            }
            set
            {
                //set the current value of StockID
                mStockID = value;
            }
        }
        public string Description
        {
            get
            {
                return mDescription;
            }
            set
            {
                mDescription = value;
            }
        }
        public DateTime LastEdited
        {
            get
            {
                return mLastEdited;
            }
            set
            {
                mLastEdited = value;
            }
        }
        public int Quantity
        {
            get
            {
                return mQuantity;
            }
            set
            {
                mQuantity = value;
            }
        }
        public double Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }

        public bool Find(int StockID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add parameter for the stock ID to search for
            DB.AddParameter("@StockID", StockID);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterByStockID");
            //if one record is found (should only be either 1 or 0)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStockID = Convert.ToInt32(DB.DataTable.Rows[0]["StockID"]);
                mDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                mLastEdited = Convert.ToDateTime(DB.DataTable.Rows[0]["LastEdited"]);
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mInStock = Convert.ToBoolean(DB.DataTable.Rows[0]["InStock"]);
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
