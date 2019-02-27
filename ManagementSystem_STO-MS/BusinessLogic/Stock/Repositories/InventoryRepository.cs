using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using ManagementSystem.BusinessLogic.Catalog;
using ManagementSystem.Common;
using ManagementSystem.Database;

namespace ManagementSystem.BusinessLogic.Stock
{
    public class InventoryRepository : Repository
    {
        public Inventory GetInventory(int id)
        {
            return Context.Inventories
                .Include(x => x.InventoryItems)
                .FirstOrDefault(x => x.ID == id);
        }

        public InventoryItem GetInventoryItem(int inventoryID, short order)
        {
            return Context.InventoryItems
                .Include(x => x.Component)
                .FirstOrDefault(x => x.InventoryID == inventoryID && x.Order == order);
        }

        public BindingList<InventoryData> GetInventories(InventoryFilter filter)
        {
            var query = Context.Inventories.AsQueryable();

            if (filter.ID.HasValue)
            {
                query = query.Where(x => x.ID == filter.ID);
            }
            if (filter.ComponentID.HasValue)
            {
                query = query.Where(x => x.InventoryItems.Any(y => y.ComponentID == filter.ComponentID));
            }
            if (filter.EnteredFrom.HasValue)
            {
                query = query.Where(x => x.Entered >= filter.EnteredFrom);
            }
            if (filter.EnteredTo.HasValue)
            {
                query = query.Where(x => x.Entered <= filter.EnteredTo);
            }
            if (filter.IsNotApprovedOnly)
            {
                query = query.Where(x => x.IsApproved == false);
            }

            var list = query.Select(x => new InventoryData
            {
                ID = x.ID,
                Entered = x.Entered,
                IsApproved = x.IsApproved
            })
            .OrderBy(x => x.ID)
            .ToList();

            return new BindingList<InventoryData>(list);
        }

        public BindingList<InventoryItemData> GetInventoryItems(int inventoryID)
        {
            var list = Context.InventoryItems
                .Where(x => x.InventoryID == inventoryID)
                .Select(x => new InventoryItemData
                {
                    InventoryID = x.InventoryID,
                    Order = x.Order,
                    ComponentTypeName = x.Component.ComponentType.Name,
                    ComponentName = x.Component.Name,
                    StockQuantity = (x.Inventory.IsApproved) ? x.StockQuantity : x.Component.Quantity,
                    ActualQuantity = x.ActualQuantity,
                    TotalDifference = (x.Inventory.IsApproved) ? x.TotalDifference : x.ActualQuantity - x.Component.Quantity
                })
                .OrderBy(x => x.Order)
                .ToList();

            return new BindingList<InventoryItemData>(list);
        }

        public BindingList<ComponentData> GetComponentsForPopup(int inventoryID, ComponentFilter filter)
        {
            var query = Context.Components
                .Where(x => !x.InventoryItems.Any(y => y.InventoryID == inventoryID));

            if (filter.ComponentTypeID.HasValue)
            {
                query = query.Where(x => x.ComponentTypeID == filter.ComponentTypeID);
            }
            if (filter.Name.IsNotNullOrEmpty())
            {
                query = query.Where(x => x.Name.Contains(filter.Name));
            }
            if (filter.ProductID.HasValue)
            {
                query = query.Where(x => x.Product_Component.Any(y => y.ProductID == filter.ProductID));
            }

            var list = query.Select(x => new ComponentData
            {
                ID = x.ID,
                ComponentTypeName = x.ComponentType.Name,
                Name = x.Name,
                Quantity = x.Quantity
            })
            .OrderBy(x => x.Name)
            .ToList();

            return new BindingList<ComponentData>(list);
        }

        public DateTime GetMinEntered()
        {
            return Context.Inventories
                .Where(x => x.IsApproved == true)
                .Select(x => x.Entered)
                .DefaultIfEmpty(System.Windows.Forms.DateTimePicker.MinimumDateTime)
                .Max();

        }

        public bool CheckNotApprovedSuppies(DateTime date)
        {
            return Context.Supplies
                .Any(x => x.IsApproved == false && x.Delivered <= date);
        }

        public void AddInventoryItems(int inventoryID, IEnumerable<int> componentIDs)
        {
            foreach (var componentID in componentIDs)
            {
                var component = Context.Components
                    .Where(x => x.ID == componentID)
                    .FirstOrDefault();

                Context.InventoryItems.Add(new InventoryItem
                {
                    InventoryID = inventoryID,
                    ComponentID = component.ID,
                    StockQuantity = component.Quantity,
                    ActualQuantity = 0,
                    TotalDifference = -component.Quantity
                });
            }
        }

        public void UpdateInventoryItem(InventoryItem inventoryItem)
        {
            inventoryItem.StockQuantity = inventoryItem.Component.Quantity;
            inventoryItem.TotalDifference = inventoryItem.ActualQuantity - inventoryItem.StockQuantity;
        }

        public void RemoveInventoryItems(int inventoryID, IEnumerable<short> inventoryItemOrders)
        {
            foreach (var inventoryItemOrder in inventoryItemOrders)
            {
                Context.DeleteInventoryItem(inventoryID, inventoryItemOrder);
            }
        }

        public void InsertInventory(Inventory inventory)
        {
            inventory.IsApproved = false;

            Context.Inventories.Add(inventory);
        }

        public void UpdateInventory(Inventory inventory)
        {
        }

        public void ApproveInventory(int id)
        {
            var inventory = GetInventory(id);

            foreach (var inventoryItem in inventory.InventoryItems)
            {
                UpdateInventoryItem(inventoryItem);
            }

            inventory.IsApproved = true;
        }

        public void CalculateComponentStockQuantity(int inventoryID)
        {
            Context.CalculateComponentStockByInventory(inventoryID);
        }

        public int GetNextInventoryID()
        {
            return Context.GetNextInventoryIDForApp().FirstOrDefault() ?? 0;
        }
    }
}
