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

        private DateTime mDateOfBirth;
        public DateTime DateOfBirth { get
            {
                return mDateOfBirth;
            }

            set
            {
                mDateOfBirth = value;
            }
        }


        private Boolean mIsWorking;
        public Boolean IsWorking { get
            {
                return mIsWorking;
            }
            set
            {
                mIsWorking = value;
            }
        }
        private Double mHourlyWage;
        public Double HourlyWage { get
            {
                return mHourlyWage;
            }
            set
            {
                mHourlyWage = value;
            }
            }
        private String mPhoneNumber;
        public String PhoneNumber { get
            {
                return mPhoneNumber;
            }
            set
            {
                mPhoneNumber = value;
            }
        }
        private Int32 mStaffId;
        public Int32 StaffId { get
            {
                return mStaffId;
            } set
            {
                mStaffId = value;
            }
        }

        public bool Find(string name)
        {
            // set the private data members
            mStaffId = 1;
            mFullName = "Josh Harrison";
            mDateOfBirth = Convert.ToDateTime("07/11/2000");
            mPhoneNumber = "07759188304";
            mHourlyWage = 8.5;
           
            // Always return true (Just for now)
            return true;
        }
    }
}