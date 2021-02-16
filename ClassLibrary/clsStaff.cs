using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public clsStaff()
        {
        }

        public Boolean IsWorking { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Double HourlyWage { get; set; }
        public String PhoneNumber { get; set; }
        public String FullName { get; set; }
        public Int32 StaffId { get; set; }
    }
}