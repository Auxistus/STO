using System;

namespace ManagementSystem.BusinessLogic.Stock
{
    public class SupplyData
    {
        public int ID { get; set; }
        public DateTime Delivered { get; set; }
        public string SupplierName { get; set; }
        public string Description { get; set; }
        public bool IsApproved { get; set; }
    }
}
