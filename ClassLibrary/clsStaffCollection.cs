using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();

        // private data member thisStaff
        clsStaff mThisStaff = new clsStaff();
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
        public clsStaff ThisStaff
        {
            get
            {
                // returns private this staff value
                return  mThisStaff;
            }

            set
            {
                // Set the private data value
                mThisStaff = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mthisstaff
            // connect to database
            clsDataConnection DB = new clsDataConnection();
            // Set the parameters for the stored procedure
            DB.AddParameter("@FullName", mThisStaff.FullName);
            DB.AddParameter("@PhoneNumber",mThisStaff.PhoneNumber);
            DB.AddParameter("@HourlyWage", mThisStaff.HourlyWage);
            DB.AddParameter("@DateOfBirth", mThisStaff.DateOfBirth);
            DB.AddParameter("@IsWorking", mThisStaff.IsWorking);

            return DB.Execute("sproc_tblStaff_Insert");
        }
    }
}