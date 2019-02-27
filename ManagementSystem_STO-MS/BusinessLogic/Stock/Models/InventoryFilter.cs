using System;

namespace ManagementSystem.BusinessLogic.Stock
{
    public class InventoryFilter
    {
        public int? ID { get; set; }
        public int? ComponentID { get; set; }
        public DateTime? EnteredFrom { get; set; }
        public DateTime? EnteredTo { get; set; }
        public bool IsNotApprovedOnly { get; set; }
    }
}
