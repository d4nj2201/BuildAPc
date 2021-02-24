using System;

namespace ClassLibrary
{
    public class clsParts
    {
        public int PartId { get; set; }
        public string PartDescription { get; set; }
        public string PartType { get; set; }
        public DateTime DateAdded { get; set; }
        public double Price { get; set; }
        public int Wattage { get; set; }
        public bool Available { get; set; }
    }
}