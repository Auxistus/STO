using System;

namespace ManagementSystem.BusinessLogic.Stock
{
    public class SaleFilter
    {
        public int? ID { get; set; }
        public string CustomerName { get; set; }
        public int? ProductID { get; set; }
        public DateTime? SoldFrom { get; set; }
        public DateTime? SoldTo { get; set; }
        public bool IsNotApprovedOnly { get; set; }
    }
}
