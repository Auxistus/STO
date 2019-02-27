using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using ManagementSystem.BusinessLogic.Catalog;
using ManagementSystem.Common;
using ManagementSystem.Database;

namespace ManagementSystem.BusinessLogic.Stock
{
    public class SaleRepository : Repository
    {
        public Sale GetSale(int id)
        {
            return Context.Sales
                .FirstOrDefault(x => x.ID == id);
        }

        public SaleItem GetSaleItem(int saleID, short order)
        {
            return Context.SaleItems
                .FirstOrDefault(x => x.SaleID == saleID && x.Order == order);
        }

        public BindingList<SaleData> GetSales(SaleFilter filter)
        {
            var query = Context.Sales.AsQueryable();

            if (filter.ID.HasValue)
            {
                query = query.Where(x => x.ID == filter.ID);
            }
            if (filter.CustomerName.IsNotNullOrEmpty())
            {
                query = query.Where(x => x.CustomerName.Contains(filter.CustomerName));
            }
            if (filter.ProductID.HasValue)
            {
                query = query.Where(x => x.SaleItems.Any(y => y.ProductID == filter.ProductID));
            }
            if (filter.SoldFrom.HasValue)
            {
                query = query.Where(x => x.Sold >= filter.SoldFrom);
            }
            if (filter.SoldTo.HasValue)
            {
                query = query.Where(x => x.Sold <= filter.SoldTo);
            }
            if (filter.IsNotApprovedOnly)
            {
                query = query.Where(x => x.IsApproved == false);
            }

            var list = query.Select(x => new SaleData
            {
                ID = x.ID,
                Sold = x.Sold,
                CustomerName = x.CustomerName,
                IsApproved = x.IsApproved
            })
            .OrderBy(x => x.ID)
            .ToList();

            return new BindingList<SaleData>(list);
        }

        public BindingList<SaleItemData> GetSaleItems(int saleID)
        {
            var list = Context.SaleItems
                .Where(x => x.SaleID == saleID)
                .Select(x => new SaleItemData
                {
                    SaleID = x.SaleID,
                    Order = x.Order,
                    ProductID = x.ProductID,
                    ProductName = x.Product.Name,
                    Quantity = x.Quantity
                })
                .OrderBy(x => x.Order)
                .ToList();

            return new BindingList<SaleItemData>(list);
        }

        public BindingList<ProductData> GetProductsForPopup(int saleID, ProductFilter filter)
        {
            var query = Context.Products
                .Where(x => !x.SaleItems.Any(y => y.SaleID == saleID));

            if (filter.ID.HasValue)
            {
                query = query.Where(x => x.ID == filter.ID);
            }
            if (filter.Name.IsNotNullOrEmpty())
            {
                query = query.Where(x => x.Name.Contains(filter.Name));
            }

            var list = query.Select(x => new ProductData
            {
                ID = x.ID,
                Name = x.Name
            })
            .OrderBy(x => x.ID)
            .ToList();

            return new BindingList<ProductData>(list);
        }

        public void AddSaleItems(int saleID, IEnumerable<int> productIDs)
        {
            foreach (var productID in productIDs)
            {
                Context.SaleItems.Add(new SaleItem
                {
                    SaleID = saleID,
                    ProductID = productID,
                    Quantity = 0
                });
            }
        }

        public void UpdateSaleItem(SaleItem saleItem)
        {
        }

        public void RemoveSaleItems(int saleID, IEnumerable<short> saleItemOrders)
        {
            foreach (var saleItemOrder in saleItemOrders)
            {
                Context.DeleteSaleItem(saleID, saleItemOrder);
            }
        }

        public void InsertSale(Sale sale)
        {
            sale.IsApproved = false;

            Context.Sales.Add(sale);
        }

        public void UpdateSale(Sale sale)
        {
        }

        public void ApproveSale(int id)
        {
            var sale = GetSale(id);

            sale.IsApproved = true;
        }

        public void CalculateComponentStockQuantity(int saleID)
        {
            Context.CalculateComponentStockBySale(saleID);
        }

        public int GetNextSaleID()
        {
            return Context.GetNextSaleIDForApp().FirstOrDefault() ?? 0;
        }
    }
}
