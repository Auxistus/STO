using System;

namespace ManagementSystem.BusinessLogic.Stock
{
    public class InventoryData
    {
        public int ID { get; set; }
        public DateTime Entered { get; set; }
        public bool IsApproved { get; set; }
    }
}
