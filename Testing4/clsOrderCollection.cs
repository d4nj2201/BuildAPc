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
    }
}