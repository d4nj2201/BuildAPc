using System;
using System.Collections.Generic;
using ClassLibrary;

namespace TestingOrders
{
     class clsOrderCollection
    {
        //private data member for the list.
        List<clsOrder> mOrderList = new List<clsOrder>();
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
        public clsOrder ThisOrder { get; internal set; }

        public clsOrderCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblAddress_SelectAll");
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
    }
}