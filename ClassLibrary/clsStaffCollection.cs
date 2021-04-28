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
            // object for data connection
            clsDataConnection DB = new clsDataConnection();
            // execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            // populate array list with data table
            PopulateArray(DB);
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

        public void Update()
        {
            //adds a new record to the database based on the values of mthisstaff
            // connect to database
            clsDataConnection DB = new clsDataConnection();
            // Set the parameters for the stored procedure
            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            DB.AddParameter("@FullName", mThisStaff.FullName);
            DB.AddParameter("@PhoneNumber", mThisStaff.PhoneNumber);
            DB.AddParameter("@HourlyWage", mThisStaff.HourlyWage);
            DB.AddParameter("@DateOfBirth", mThisStaff.DateOfBirth);
            DB.AddParameter("@IsWorking", mThisStaff.IsWorking);
            // Execute the stored procedure
            DB.Execute("sproc_tblStaff_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisStaff
            // connect to DB
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedure
            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            DB.Execute("sproc_tblStaff_delete");
        }

        public void ReportByFullName(string FullName)
        {
            // filters the records based on an hourly wage
            // connect to db
            clsDataConnection DB = new clsDataConnection();
            // send full name parameter to the database
            DB.AddParameter("@FullName", FullName);
            // execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByFullName");
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            //populate the array list based on the data table in the parameter DB
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mStaffList = new List<clsStaff>();
            while (Index < RecordCount)
            {
                // create a blank Staff
                clsStaff AStaff = new clsStaff();
                AStaff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AStaff.FullName = Convert.ToString(DB.DataTable.Rows[Index]["FullName"]);
                AStaff.PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNumber"]);
                AStaff.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                AStaff.HourlyWage = Convert.ToDouble(DB.DataTable.Rows[Index]["HourlyWage"]);
                AStaff.IsWorking = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsWorking"]);
                mStaffList.Add(AStaff);
                Index++;
            }
        }
    }
}