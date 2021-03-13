using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsStaffCollection
    {
        public clsStaffCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsStaff AStaff = new clsStaff();
                //set its properties
                AStaff.IsWorking = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsWorking"]);
                AStaff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AStaff.FullName = Convert.ToString(DB.DataTable.Rows[Index]["FullName"]);
                AStaff.PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["Phonenumber"]);
                AStaff.HourlyWage = Convert.ToDouble(DB.DataTable.Rows[Index]["HourlyWage"]);
                AStaff.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                // add the item to the test list
                mStaffList.Add(AStaff);
                Index++;
            }
            

        }
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        public List<clsStaff> StaffList {
            get
            {
                //return private staff list 
                return mStaffList;
            }
            set
            {
                // set staff list
                mStaffList = value;
            }
        }

        public int Count { get
            {
                //return count of list
                return mStaffList.Count;
            }
            set
            {
                // worry about later
            }
                }
        public clsStaff ThisStaff { get; set; }
    }
}