﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Component> Components { get; set; }
        public virtual DbSet<ComponentType> ComponentTypes { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Product_Component> Product_Component { get; set; }
        public virtual DbSet<Supply> Supplies { get; set; }
        public virtual DbSet<SupplyItem> SupplyItems { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<InventoryItem> InventoryItems { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<SaleItem> SaleItems { get; set; }
    
        public virtual int DeleteProduct_Component(Nullable<int> productID, Nullable<int> componentID)
        {
            var productIDParameter = productID.HasValue ?
                new ObjectParameter("ProductID", productID) :
                new ObjectParameter("ProductID", typeof(int));
    
            var componentIDParameter = componentID.HasValue ?
                new ObjectParameter("ComponentID", componentID) :
                new ObjectParameter("ComponentID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteProduct_Component", productIDParameter, componentIDParameter);
        }
    
        public virtual ObjectResult<InsertComponent_Result> InsertComponent(Nullable<byte> componentTypeID, string name, Nullable<int> quantity)
        {
            var componentTypeIDParameter = componentTypeID.HasValue ?
                new ObjectParameter("ComponentTypeID", componentTypeID) :
                new ObjectParameter("ComponentTypeID", typeof(byte));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("Quantity", quantity) :
                new ObjectParameter("Quantity", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<InsertComponent_Result>("InsertComponent", componentTypeIDParameter, nameParameter, quantityParameter);
        }
    
        public virtual ObjectResult<Nullable<System.DateTime>> InsertProduct(Nullable<int> iD, string name, Nullable<short> scale)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var scaleParameter = scale.HasValue ?
                new ObjectParameter("Scale", scale) :
                new ObjectParameter("Scale", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<System.DateTime>>("InsertProduct", iDParameter, nameParameter, scaleParameter);
        }
    
        public virtual ObjectResult<Nullable<System.DateTime>> InsertProduct_Component(Nullable<int> productID, Nullable<int> componentID, Nullable<short> quantity)
        {
            var productIDParameter = productID.HasValue ?
                new ObjectParameter("ProductID", productID) :
                new ObjectParameter("ProductID", typeof(int));
    
            var componentIDParameter = componentID.HasValue ?
                new ObjectParameter("ComponentID", componentID) :
                new ObjectParameter("ComponentID", typeof(int));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("Quantity", quantity) :
                new ObjectParameter("Quantity", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<System.DateTime>>("InsertProduct_Component", productIDParameter, componentIDParameter, quantityParameter);
        }
    
        public virtual ObjectResult<Nullable<System.DateTime>> UpdateComponent(Nullable<int> iD, Nullable<byte> componentTypeID, string name, Nullable<int> quantity)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var componentTypeIDParameter = componentTypeID.HasValue ?
                new ObjectParameter("ComponentTypeID", componentTypeID) :
                new ObjectParameter("ComponentTypeID", typeof(byte));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("Quantity", quantity) :
                new ObjectParameter("Quantity", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<System.DateTime>>("UpdateComponent", iDParameter, componentTypeIDParameter, nameParameter, quantityParameter);
        }
    
        public virtual ObjectResult<Nullable<System.DateTime>> UpdateProduct(Nullable<int> iD, string name, Nullable<short> scale)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var scaleParameter = scale.HasValue ?
                new ObjectParameter("Scale", scale) :
                new ObjectParameter("Scale", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<System.DateTime>>("UpdateProduct", iDParameter, nameParameter, scaleParameter);
        }
    
        public virtual int DeleteComponentType(Nullable<byte> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteComponentType", iDParameter);
        }
    
        public virtual ObjectResult<InsertComponentType_Result> InsertComponentType(string name, Nullable<bool> isVisible)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var isVisibleParameter = isVisible.HasValue ?
                new ObjectParameter("IsVisible", isVisible) :
                new ObjectParameter("IsVisible", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<InsertComponentType_Result>("InsertComponentType", nameParameter, isVisibleParameter);
        }
    
        public virtual ObjectResult<Nullable<System.DateTime>> UpdateComponentType(Nullable<byte> iD, string name, Nullable<bool> isVisible)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(byte));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var isVisibleParameter = isVisible.HasValue ?
                new ObjectParameter("IsVisible", isVisible) :
                new ObjectParameter("IsVisible", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<System.DateTime>>("UpdateComponentType", iDParameter, nameParameter, isVisibleParameter);
        }
    
        public virtual ObjectResult<InsertSupply_Result> InsertSupply(Nullable<System.DateTime> delivered, string supplierName, string description, Nullable<bool> isApproved)
        {
            var deliveredParameter = delivered.HasValue ?
                new ObjectParameter("Delivered", delivered) :
                new ObjectParameter("Delivered", typeof(System.DateTime));
    
            var supplierNameParameter = supplierName != null ?
                new ObjectParameter("SupplierName", supplierName) :
                new ObjectParameter("SupplierName", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var isApprovedParameter = isApproved.HasValue ?
                new ObjectParameter("IsApproved", isApproved) :
                new ObjectParameter("IsApproved", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<InsertSupply_Result>("InsertSupply", deliveredParameter, supplierNameParameter, descriptionParameter, isApprovedParameter);
        }
    
        public virtual ObjectResult<Nullable<System.DateTime>> InsertSupplyItem(Nullable<int> supplyID, Nullable<int> componentID, Nullable<int> quantity)
        {
            var supplyIDParameter = supplyID.HasValue ?
                new ObjectParameter("SupplyID", supplyID) :
                new ObjectParameter("SupplyID", typeof(int));
    
            var componentIDParameter = componentID.HasValue ?
                new ObjectParameter("ComponentID", componentID) :
                new ObjectParameter("ComponentID", typeof(int));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("Quantity", quantity) :
                new ObjectParameter("Quantity", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<System.DateTime>>("InsertSupplyItem", supplyIDParameter, componentIDParameter, quantityParameter);
        }
    
        public virtual ObjectResult<Nullable<System.DateTime>> UpdateSupply(Nullable<int> iD, Nullable<System.DateTime> delivered, string supplierName, string description, Nullable<bool> isApproved)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var deliveredParameter = delivered.HasValue ?
                new ObjectParameter("Delivered", delivered) :
                new ObjectParameter("Delivered", typeof(System.DateTime));
    
            var supplierNameParameter = supplierName != null ?
                new ObjectParameter("SupplierName", supplierName) :
                new ObjectParameter("SupplierName", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var isApprovedParameter = isApproved.HasValue ?
                new ObjectParameter("IsApproved", isApproved) :
                new ObjectParameter("IsApproved", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<System.DateTime>>("UpdateSupply", iDParameter, deliveredParameter, supplierNameParameter, descriptionParameter, isApprovedParameter);
        }
    
        public virtual ObjectResult<Nullable<System.DateTime>> UpdateSupplyItem(Nullable<int> supplyID, Nullable<short> order, Nullable<int> componentID, Nullable<int> quantity)
        {
            var supplyIDParameter = supplyID.HasValue ?
                new ObjectParameter("SupplyID", supplyID) :
                new ObjectParameter("SupplyID", typeof(int));
    
            var orderParameter = order.HasValue ?
                new ObjectParameter("Order", order) :
                new ObjectParameter("Order", typeof(short));
    
            var componentIDParameter = componentID.HasValue ?
                new ObjectParameter("ComponentID", componentID) :
                new ObjectParameter("ComponentID", typeof(int));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("Quantity", quantity) :
                new ObjectParameter("Quantity", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<System.DateTime>>("UpdateSupplyItem", supplyIDParameter, orderParameter, componentIDParameter, quantityParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> GetNextSupplyIDForApp()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("GetNextSupplyIDForApp");
        }
    
        public virtual int DeleteSupplyItem(Nullable<int> supplyID, Nullable<short> order)
        {
            var supplyIDParameter = supplyID.HasValue ?
                new ObjectParameter("SupplyID", supplyID) :
                new ObjectParameter("SupplyID", typeof(int));
    
            var orderParameter = order.HasValue ?
                new ObjectParameter("Order", order) :
                new ObjectParameter("Order", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteSupplyItem", supplyIDParameter, orderParameter);
        }
    
        public virtual int DeleteInventoryItem(Nullable<int> inventoryID, Nullable<short> order)
        {
            var inventoryIDParameter = inventoryID.HasValue ?
                new ObjectParameter("InventoryID", inventoryID) :
                new ObjectParameter("InventoryID", typeof(int));
    
            var orderParameter = order.HasValue ?
                new ObjectParameter("Order", order) :
                new ObjectParameter("Order", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteInventoryItem", inventoryIDParameter, orderParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> GetNextInventoryIDForApp()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("GetNextInventoryIDForApp");
        }
    
        public virtual ObjectResult<InsertInventory_Result> InsertInventory(Nullable<System.DateTime> entered, Nullable<bool> isApproved)
        {
            var enteredParameter = entered.HasValue ?
                new ObjectParameter("Entered", entered) :
                new ObjectParameter("Entered", typeof(System.DateTime));
    
            var isApprovedParameter = isApproved.HasValue ?
                new ObjectParameter("IsApproved", isApproved) :
                new ObjectParameter("IsApproved", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<InsertInventory_Result>("InsertInventory", enteredParameter, isApprovedParameter);
        }
    
        public virtual ObjectResult<InsertInventoryItem_Result> InsertInventoryItem(Nullable<int> inventoryID, Nullable<int> componentID, Nullable<int> stockQuantity, Nullable<int> actualkQuantity, Nullable<int> totalDifference)
        {
            var inventoryIDParameter = inventoryID.HasValue ?
                new ObjectParameter("InventoryID", inventoryID) :
                new ObjectParameter("InventoryID", typeof(int));
    
            var componentIDParameter = componentID.HasValue ?
                new ObjectParameter("ComponentID", componentID) :
                new ObjectParameter("ComponentID", typeof(int));
    
            var stockQuantityParameter = stockQuantity.HasValue ?
                new ObjectParameter("StockQuantity", stockQuantity) :
                new ObjectParameter("StockQuantity", typeof(int));
    
            var actualkQuantityParameter = actualkQuantity.HasValue ?
                new ObjectParameter("ActualkQuantity", actualkQuantity) :
                new ObjectParameter("ActualkQuantity", typeof(int));
    
            var totalDifferenceParameter = totalDifference.HasValue ?
                new ObjectParameter("TotalDifference", totalDifference) :
                new ObjectParameter("TotalDifference", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<InsertInventoryItem_Result>("InsertInventoryItem", inventoryIDParameter, componentIDParameter, stockQuantityParameter, actualkQuantityParameter, totalDifferenceParameter);
        }
    
        public virtual ObjectResult<Nullable<System.DateTime>> UpdateInventory(Nullable<int> iD, Nullable<System.DateTime> entered, Nullable<bool> isApproved)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var enteredParameter = entered.HasValue ?
                new ObjectParameter("Entered", entered) :
                new ObjectParameter("Entered", typeof(System.DateTime));
    
            var isApprovedParameter = isApproved.HasValue ?
                new ObjectParameter("IsApproved", isApproved) :
                new ObjectParameter("IsApproved", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<System.DateTime>>("UpdateInventory", iDParameter, enteredParameter, isApprovedParameter);
        }
    
        public virtual ObjectResult<Nullable<System.DateTime>> UpdateInventoryItem(Nullable<int> inventoryID, Nullable<short> order, Nullable<int> componentID, Nullable<int> stockQuantity, Nullable<int> actualkQuantity, Nullable<int> totalDifference)
        {
            var inventoryIDParameter = inventoryID.HasValue ?
                new ObjectParameter("InventoryID", inventoryID) :
                new ObjectParameter("InventoryID", typeof(int));
    
            var orderParameter = order.HasValue ?
                new ObjectParameter("Order", order) :
                new ObjectParameter("Order", typeof(short));
    
            var componentIDParameter = componentID.HasValue ?
                new ObjectParameter("ComponentID", componentID) :
                new ObjectParameter("ComponentID", typeof(int));
    
            var stockQuantityParameter = stockQuantity.HasValue ?
                new ObjectParameter("StockQuantity", stockQuantity) :
                new ObjectParameter("StockQuantity", typeof(int));
    
            var actualkQuantityParameter = actualkQuantity.HasValue ?
                new ObjectParameter("ActualkQuantity", actualkQuantity) :
                new ObjectParameter("ActualkQuantity", typeof(int));
    
            var totalDifferenceParameter = totalDifference.HasValue ?
                new ObjectParameter("TotalDifference", totalDifference) :
                new ObjectParameter("TotalDifference", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<System.DateTime>>("UpdateInventoryItem", inventoryIDParameter, orderParameter, componentIDParameter, stockQuantityParameter, actualkQuantityParameter, totalDifferenceParameter);
        }
    
        public virtual int CalculateComponentStockByInventory(Nullable<int> inventoryID)
        {
            var inventoryIDParameter = inventoryID.HasValue ?
                new ObjectParameter("InventoryID", inventoryID) :
                new ObjectParameter("InventoryID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CalculateComponentStockByInventory", inventoryIDParameter);
        }
    
        public virtual int CalculateComponentStockBySupply(Nullable<int> supplyID)
        {
            var supplyIDParameter = supplyID.HasValue ?
                new ObjectParameter("SupplyID", supplyID) :
                new ObjectParameter("SupplyID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CalculateComponentStockBySupply", supplyIDParameter);
        }
    
        public virtual int CalculateComponentStockBySale(Nullable<int> saleID)
        {
            var saleIDParameter = saleID.HasValue ?
                new ObjectParameter("SaleID", saleID) :
                new ObjectParameter("SaleID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CalculateComponentStockBySale", saleIDParameter);
        }
    
        public virtual int DeleteSaleItem(Nullable<int> saleID, Nullable<short> order)
        {
            var saleIDParameter = saleID.HasValue ?
                new ObjectParameter("SaleID", saleID) :
                new ObjectParameter("SaleID", typeof(int));
    
            var orderParameter = order.HasValue ?
                new ObjectParameter("Order", order) :
                new ObjectParameter("Order", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteSaleItem", saleIDParameter, orderParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> GetNextSaleIDForApp()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("GetNextSaleIDForApp");
        }
    
        public virtual ObjectResult<InsertSale_Result> InsertSale(Nullable<System.DateTime> sold, string customerName, Nullable<bool> isApproved)
        {
            var soldParameter = sold.HasValue ?
                new ObjectParameter("Sold", sold) :
                new ObjectParameter("Sold", typeof(System.DateTime));
    
            var customerNameParameter = customerName != null ?
                new ObjectParameter("CustomerName", customerName) :
                new ObjectParameter("CustomerName", typeof(string));
    
            var isApprovedParameter = isApproved.HasValue ?
                new ObjectParameter("IsApproved", isApproved) :
                new ObjectParameter("IsApproved", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<InsertSale_Result>("InsertSale", soldParameter, customerNameParameter, isApprovedParameter);
        }
    
        public virtual ObjectResult<InsertSaleItem_Result> InsertSaleItem(Nullable<int> saleID, Nullable<int> productID, Nullable<int> quantity)
        {
            var saleIDParameter = saleID.HasValue ?
                new ObjectParameter("SaleID", saleID) :
                new ObjectParameter("SaleID", typeof(int));
    
            var productIDParameter = productID.HasValue ?
                new ObjectParameter("ProductID", productID) :
                new ObjectParameter("ProductID", typeof(int));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("Quantity", quantity) :
                new ObjectParameter("Quantity", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<InsertSaleItem_Result>("InsertSaleItem", saleIDParameter, productIDParameter, quantityParameter);
        }
    
        public virtual ObjectResult<Nullable<System.DateTime>> UpdateSale(Nullable<int> iD, Nullable<System.DateTime> sold, string customerName, Nullable<bool> isApproved)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var soldParameter = sold.HasValue ?
                new ObjectParameter("Sold", sold) :
                new ObjectParameter("Sold", typeof(System.DateTime));
    
            var customerNameParameter = customerName != null ?
                new ObjectParameter("CustomerName", customerName) :
                new ObjectParameter("CustomerName", typeof(string));
    
            var isApprovedParameter = isApproved.HasValue ?
                new ObjectParameter("IsApproved", isApproved) :
                new ObjectParameter("IsApproved", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<System.DateTime>>("UpdateSale", iDParameter, soldParameter, customerNameParameter, isApprovedParameter);
        }
    
        public virtual ObjectResult<Nullable<System.DateTime>> UpdateSaleItem(Nullable<int> saleID, Nullable<short> order, Nullable<int> productID, Nullable<int> quantity)
        {
            var saleIDParameter = saleID.HasValue ?
                new ObjectParameter("SaleID", saleID) :
                new ObjectParameter("SaleID", typeof(int));
    
            var orderParameter = order.HasValue ?
                new ObjectParameter("Order", order) :
                new ObjectParameter("Order", typeof(short));
    
            var productIDParameter = productID.HasValue ?
                new ObjectParameter("ProductID", productID) :
                new ObjectParameter("ProductID", typeof(int));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("Quantity", quantity) :
                new ObjectParameter("Quantity", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<System.DateTime>>("UpdateSaleItem", saleIDParameter, orderParameter, productIDParameter, quantityParameter);
        }
    }
}
