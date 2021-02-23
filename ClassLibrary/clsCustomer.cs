using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public short CustomerId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
    }
}