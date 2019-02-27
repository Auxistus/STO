using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using ManagementSystem.BusinessLogic.Catalog;
using ManagementSystem.Common;
using ManagementSystem.Database;

namespace ManagementSystem.BusinessLogic.Stock
{
    public class SupplyRepository : Repository
    {
        public Supply GetSupply(int id)
        {
            return Context.Supplies
                .FirstOrDefault(x => x.ID == id);
        }

        public SupplyItem GetSupplyItem(int supplyID, short order)
        {
            return Context.SupplyItems
                .FirstOrDefault(x => x.SupplyID == supplyID && x.Order == order);
        }

        public BindingList<SupplyData> GetSupplies(SupplyFilter filter)
        {
            var query = Context.Supplies.AsQueryable();

            if (filter.ID.HasValue)
            {
                query = query.Where(x => x.ID == filter.ID);
            }
            if (filter.SupplierName.IsNotNullOrEmpty())
            {
                query = query.Where(x => x.SupplierName.Contains(filter.SupplierName));
            }
            if (filter.ComponentID.HasValue)
            {
                query = query.Where(x => x.SupplyItems.Any(y => y.ComponentID == filter.ComponentID));
            }
            if (filter.DeliveredFrom.HasValue)
            {
                query = query.Where(x => x.Delivered >= filter.DeliveredFrom);
            }
            if (filter.DeliveredTo.HasValue)
            {
                query = query.Where(x => x.Delivered <= filter.DeliveredTo);
            }
            if (filter.IsNotApprovedOnly)
            {
                query = query.Where(x => x.IsApproved == false);
            }

            var list = query.Select(x => new SupplyData
            {
                ID = x.ID,
                Delivered = x.Delivered,
                SupplierName = x.SupplierName,
                Description = x.Description,
                IsApproved = x.IsApproved
            })
            .OrderBy(x => x.ID)
            .ToList();

            return new BindingList<SupplyData>(list);
        }

        public BindingList<SupplyItemData> GetSupplyItems(int supplyID)
        {
            var list = Context.SupplyItems
                .Where(x => x.SupplyID == supplyID)
                .Select(x => new SupplyItemData
                {
                    SupplyID = x.SupplyID,
                    Order = x.Order,
                    ComponentTypeName = x.Component.ComponentType.Name,
                    ComponentName = x.Component.Name,
                    Quantity = x.Quantity
                })
                .OrderBy(x => x.Order)
                .ToList();

            return new BindingList<SupplyItemData>(list);
        }

        public BindingList<ComponentData> GetComponentsForPopup(int supplyID, ComponentFilter filter)
        {
            var query = Context.Components
                .Where(x => !x.SupplyItems.Any(y => y.SupplyID == supplyID));

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

        public void AddSupplyItems(int supplyID, IEnumerable<int> componentIDs)
        {
            foreach (var componentID in componentIDs)
            {
                Context.SupplyItems.Add(new SupplyItem
                {
                    SupplyID = supplyID,
                    ComponentID = componentID,
                    Quantity = 0
                });
            }
        }

        public void UpdateSupplyItem(SupplyItem supplyItem)
        {
        }

        public void RemoveSupplyItems(int supplyID, IEnumerable<short> supplyItemOrders)
        {
            foreach (var supplyItemOrder in supplyItemOrders)
            {
                Context.DeleteSupplyItem(supplyID, supplyItemOrder);
            }
        }

        public void InsertSupply(Supply supply)
        {
            supply.IsApproved = false;

            Context.Supplies.Add(supply);
        }

        public void UpdateSupply(Supply supply)
        {
        }

        public void ApproveSupply(int id)
        {
            var supply = GetSupply(id);

            supply.IsApproved = true;
        }

        public void CalculateComponentStockQuantity(int supplyID)
        {
            Context.CalculateComponentStockBySupply(supplyID);
        }

        public int GetNextSupplyID()
        {
            return Context.GetNextSupplyIDForApp().FirstOrDefault() ?? 0;
        }
    }
}
