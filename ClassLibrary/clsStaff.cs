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

        public bool Find(Int32 staffId)
        {
            //Create instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // Add parameter for the full name to seacrh
            DB.AddParameter("StaffId", staffId);
            // Execute filter
            DB.Execute("sproc_tblStaff_FilterByStaffId");
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

        public string Valid(string staffId, string fullName, string dateOfBirth, string hourlyWage, string phoneNumber)
        {
            // Create string variable to store the error
            String Error = " ";

            DateTime TempDate;
            
            // if the full name is blank 
            if (fullName.Length == 0)
            {
                Error = Error + "The Full name may be blank: ";
            }
            // if the full name has one more than the max 
            if (fullName.Length > 50)
            {
                Error = Error + "The Full name may contain more than 50 characters: ";
            }
            try
            {
                TempDate = Convert.ToDateTime(dateOfBirth);
                if (TempDate > DateTime.Now.Date)
                {
                    Error = Error + "The Date of birth cannot be in the future: ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date: ";
            }
            if (phoneNumber.Length != 11)
            {
                Error = Error + "The phone number may not have 11 digits: ";
            }
            try
            {
                if (Convert.ToDouble(hourlyWage) < 4.15)
                {
                    Error = Error + "The wage entered is less than the minimum wage: ";
                }
            }
            catch
            {
                Error = Error + "The wage entered is not formatted correctly";
            }
            return Error;
            }
          
        }
        
}
