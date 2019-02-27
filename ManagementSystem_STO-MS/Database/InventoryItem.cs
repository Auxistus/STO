//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ManagementSystem.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class InventoryItem
    {
        public int InventoryID { get; set; }
        public short Order { get; set; }
        public int ComponentID { get; set; }
        public System.DateTime Created { get; set; }
        public Nullable<System.DateTime> Modified { get; set; }
        public int StockQuantity { get; set; }
        public int ActualQuantity { get; set; }
        public int TotalDifference { get; set; }
    
        public virtual Component Component { get; set; }
        public virtual Inventory Inventory { get; set; }
    }
}
