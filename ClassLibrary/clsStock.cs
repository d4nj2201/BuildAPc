using System;

namespace ClassLibrary
{
    public class clsStock
    {
        //private data member for the Stock ID property
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
            mStockID = 5;
            mLastEdited = Convert.ToDateTime("13/02/2021");
            mDescription = "Test Description";
            mPrice = Convert.ToDouble("65.99");
            mQuantity = Convert.ToInt32("10");
            mInStock = true;
            return true;
        }
    }
}
