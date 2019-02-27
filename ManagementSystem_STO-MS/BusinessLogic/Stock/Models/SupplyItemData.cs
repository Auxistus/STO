namespace ManagementSystem.BusinessLogic.Stock
{
    public class SupplyItemData
    {
        public int SupplyID { get; set; }
        public short Order { get; set; }
        public string ComponentTypeName { get; set; }
        public string ComponentName { get; set; }
        public int Quantity { get; set; }
    }
}
