using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public clsStock()
        {
        }

        public Boolean InStock { get; set; }
        public int StockID { get; set; }
        public string Description { get; set; }
        public DateTime LastEdited { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
