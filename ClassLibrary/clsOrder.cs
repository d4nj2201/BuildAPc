using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public bool Payed { get; set; }
        public DateTime DateAdded { get; set; }
        public string Town { get; set; }
        public bool Delivered { get; set; }
        public string Name { get; set; }
        public string Contents { get; set; }
        public string ID { get; set; }
        public int CustomerID { get; set; }
        public double Total { get; set; }
    }
}