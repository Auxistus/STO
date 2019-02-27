using System;

namespace ManagementSystem.BusinessLogic.Stock
{
    public class SupplyFilter
    {
        public int? ID { get; set; }
        public string SupplierName { get; set; }
        public int? ComponentID { get; set; }
        public DateTime? DeliveredFrom { get; set; }
        public DateTime? DeliveredTo { get; set; }
        public bool IsNotApprovedOnly { get; set; }
    }
}
