using System;

namespace ManagementSystem.BusinessLogic.Stock
{
    public class SaleData
    {
        public int ID { get; set; }
        public DateTime Sold { get; set; }
        public string CustomerName { get; set; }
        public bool IsApproved { get; set; }
    }
}
