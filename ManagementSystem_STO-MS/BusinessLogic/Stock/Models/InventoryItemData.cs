namespace ManagementSystem.BusinessLogic.Stock
{
    public class InventoryItemData
    {
        public int InventoryID { get; set; }
        public short Order { get; set; }
        public string ComponentTypeName { get; set; }
        public string ComponentName { get; set; }
        public int StockQuantity { get; set; }
        public int ActualQuantity { get; set; }
        public int TotalDifference { get; set; }
    }
}
