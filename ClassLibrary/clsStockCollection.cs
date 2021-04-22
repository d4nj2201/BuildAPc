using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        List<clsStock> mStockList = new List<clsStock>();
        int mCount;
        clsStock mThisStock = new clsStock();

        //constructor for the class
        public clsStockCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mStockList = new List<clsStock>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank stock
                clsStock AStock = new clsStock();
                //read in the fields from the current record
                AStock.InStock = Convert.ToBoolean(DB.DataTable.Rows[Index]["InStock"]);
                AStock.StockID = Convert.ToInt32(DB.DataTable.Rows[Index]["StockID"]);
                AStock.Price = Convert.ToDouble(DB.DataTable.Rows[Index]["Price"]);
                AStock.LastEdited = Convert.ToDateTime(DB.DataTable.Rows[Index]["LastEdited"]);
                AStock.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AStock.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
                //add the record to the private data member
                mStockList.Add(AStock);
                //point at the next record
                Index++;
            }
        }

        public List<clsStock> StockList
        {
            get
            {
                return mStockList;
            }
            set
            {
                mStockList = value;
            }
        }
        public int Count
        {
            get
            {
                return mStockList.Count;
            }
            set
            {
                //implement this later
            }
        }
        public clsStock ThisStock
        {
            get
            {
                return mThisStock;
            }
            set
            {
                mThisStock = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Description", mThisStock.Description);
            DB.AddParameter("@LastEdited", mThisStock.LastEdited);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@Quantity", mThisStock.Quantity);
            DB.AddParameter("@InStock", mThisStock.InStock);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStock_Insert");
        }

        public void Update()
        {
            //adds a new record to the database based on the values of mThisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StockID", mThisStock.StockID);
            DB.AddParameter("@Description", mThisStock.Description);
            DB.AddParameter("@LastEdited", mThisStock.LastEdited);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@Quantity", mThisStock.Quantity);
            DB.AddParameter("@InStock", mThisStock.InStock);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StockID", mThisStock.StockID);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_Delete");
        }

        public void ReportByDescription(string Description)
        {
            //filters the records based on a full or partial description
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the Description parameter to the database
            DB.AddParameter("@Description", Description);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterByDescription");
            //populate the array list with the data table
            PopulateArray(DB);
        }
    }
}