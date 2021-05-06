using System;
using System.Collections.Generic;
using ClassLibrary;

namespace TestingOrders
{
     public class clsOrderCollection
    {
        //private data member for the list.
        List<clsOrder> mOrderList = new List<clsOrder>();
        //private data member for thisOrder.
        clsOrder mThisOrder = new clsOrder();
        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }

        
        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {
                //fix later.
            }
        }

        //mb fix this.
        public clsOrder ThisOrder
        {
            get
            {
                //return the private data.
                return mThisOrder;
            }
            set
            {
                //set the private data.
                mThisOrder = value;
            }
        }

        public clsOrderCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsOrder AnOrder = new clsOrder();
                AnOrder.Delivered = Convert.ToBoolean(DB.DataTable.Rows[Index]["Delivered"]);
                AnOrder.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnOrder.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AnOrder.Contents = Convert.ToString(DB.DataTable.Rows[Index]["Contents"]);
                AnOrder.ID = Convert.ToInt32(DB.DataTable.Rows[Index]["ID"]);
                AnOrder.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                AnOrder.Payed = Convert.ToBoolean(DB.DataTable.Rows[Index]["Payed"]);
                AnOrder.Total = Convert.ToDouble(DB.DataTable.Rows[Index]["Total"]);
                AnOrder.Town = Convert.ToString(DB.DataTable.Rows[Index]["Town"]);
                mOrderList.Add(AnOrder);
                Index++;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisOrder.
            //connect to the database.
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure.
            DB.AddParameter("@ID", mThisOrder.ID);
            DB.AddParameter("@Contents", mThisOrder.Contents);
            DB.AddParameter("@Delivered", mThisOrder.Delivered);
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            DB.AddParameter("@DateAdded", mThisOrder.DateAdded);
            DB.AddParameter("@Name", mThisOrder.Name);
            DB.AddParameter("@Payed", mThisOrder.Payed);
            DB.AddParameter("@Total", mThisOrder.Total);
            DB.AddParameter("@Town", mThisOrder.Town);
            //execute the query returning the primary key value (PK).
            return DB.Execute("sproc_tblOrder_Insert");
        }
    }
}