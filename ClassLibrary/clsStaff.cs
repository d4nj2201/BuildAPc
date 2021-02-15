using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public clsStaff()
        {
        }

        public bool IsWorking { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double HourlyWage { get; set; }
        public long PhoneNumber { get; set; }
        public string FullName { get; set; }
        public long StaffId { get; set; }
    }
}