using System;

namespace ClassLibrary
{
    public class clsStaff
    {

        // Full name private member varaible 
        private String mFullName;
        // Full name public property
        public String FullName {
            get
            {
                // Sends data out of property
                return mFullName;
            }
            set
            {
                // allows data into the property
                mFullName = value;
            }
        }
        // private member varaible 
        private DateTime mDateOfBirth;
        //  public property
        public DateTime DateOfBirth { get
            {
                // Sends data out of property
                return mDateOfBirth;
            }

            set
            {
                // allows data into the property
                mDateOfBirth = value;
            }
        }

        // private member varaible 
        private Boolean mIsWorking;
        //  public property
        public Boolean IsWorking { get
            {
                // Sends data out of property
                return mIsWorking;
            }
            set
            {
                // allows data into the property
                mIsWorking = value;
            }
        }
        // private member varaible 
        private Double mHourlyWage;
        //  public property
        public Double HourlyWage { get
            {
                // Sends data out of property
                return mHourlyWage;
            }
            set
            {
                // allows data into the property
                mHourlyWage = value;
            }
            }
        // private member varaible
        private String mPhoneNumber;
        //  public property
        public String PhoneNumber { get
            {
                // Sends data out of property
                return mPhoneNumber;
            }
            set
            {
                // allows data into the property
                mPhoneNumber = value;
            }
        }
        // private member varaible
        private Int32 mStaffId;
        //  public property
        public Int32 StaffId { get
            {
                // Sends data out of property
                return mStaffId;
            } set
            {
                // allows data into the property
                mStaffId = value;
            }
        }

        public bool Find(string name)
        {
            //Create instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // Add parameter for the full name to seacrh
            DB.AddParameter("FullName", name);
            // Execute filter
            DB.Execute("sproc_tblStaff_FilterByFullName");
            // If a record is found
            if (DB.Count == 1){
                // set the private data members
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mFullName = Convert.ToString(DB.DataTable.Rows[0]["FullName"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                mHourlyWage = Convert.ToDouble(DB.DataTable.Rows[0]["HourlyWage"]);
                mIsWorking = Convert.ToBoolean(DB.DataTable.Rows[0]["IsWorking"]);
                // Return that everything worked ok
                return true;
            }
            // If no record was found
            else
            {
                // return false indicating a problem
                return false;
            }
        }

    }
}