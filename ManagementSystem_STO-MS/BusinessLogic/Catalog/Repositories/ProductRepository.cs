using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
//using Equin.ApplicationFramework;
using ManagementSystem.Common;
using ManagementSystem.Database;

namespace ManagementSystem.BusinessLogic.Catalog
{
    public class ProductRepository : Repository
    {
        public Product GetProduct(int id)
        {
            return Context.Products
                .FirstOrDefault(x => x.ID == id);
        }

        //public BindingListView<ProductData> GetProducts(ProductFilter filter)
        public BindingList<ProductData> GetProducts(ProductFilter filter)
        {
            var query = Context.Products.AsQueryable();

            if (filter.ID.HasValue)
            {
                query = query.Where(x => x.ID == filter.ID);
            }
            if (filter.Name.IsNotNullOrEmpty())
            {
                query = query.Where(x => x.Name.Contains(filter.Name));
            }
            if (filter.Scale.HasValue)
            {
                query = query.Where(x => x.Scale == filter.Scale);
            }

            var list = query.Select(x => new ProductData
            {
                ID = x.ID,
                Name = x.Name,
                Scale = x.Scale
            })
            .OrderBy(x => x.ID)
            .ToList();

            //return new BindingListView<ProductData>(list);
            return new BindingList<ProductData>(list);
        }

        //public BindingListView<ComponentData> GetComponents(int productID)
        public BindingList<ComponentData> GetComponents(int productID)
        {
            var list = Context.Product_Component
                .Where(x => x.ProductID == productID)
                .Select(x => new ComponentData
                {
                    ID = x.Component.ID,
                    ComponentTypeName = x.Component.ComponentType.Name,
                    Name = x.Component.Name,
                    Quantity = x.Component.Quantity
                })
                .OrderBy(x => x.ComponentTypeName)
                .ToList();

            return new BindingList<ComponentData>(list);
        }

        public BindingList<ComponentData> GetComponentsForPopup(int productID, ComponentFilter filter)
        {
            var query = Context.Components
                .Where(x => !x.Product_Component.Any(y => y.ProductID == productID));

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
            if (filter.IsNotAssignedOnly)
            {
                query = query.Where(x => !x.Product_Component.Any(y => y.ComponentID == x.ID));
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

        public List<KeyValuePair<int, string>> GetProductsForDropDown()
        {
            return Context.Products
                .OrderBy(x => x.ID)
                .ToList()
                .Select(x => new KeyValuePair<int, string>(x.ID, x.ID + " - " + x.Name))
                .ToList();
        }

        public List<KeyValuePair<int, string>> GetProductsForDropDown(int excludedProductID)
        {
            return Context.Products
                .Where(x => x.ID != excludedProductID)
                .OrderBy(x => x.ID)
                .ToList()
                .Select(x => new KeyValuePair<int, string>(x.ID, x.ID + " - " + x.Name))
                .ToList();
        }

        public void AddComponents(int productID, IEnumerable<int> componentIDs)
        {
            foreach (var componentID in componentIDs)
            {
                Context.Product_Component.Add(new Product_Component
                {
                    ProductID = productID,
                    ComponentID = componentID,
                    Quantity = 1
                });
            }
        }

        public void RemoveComponents(int productID, IEnumerable<int> componentIDs)
        {
            foreach (var componentID in componentIDs)
            {
                Context.DeleteProduct_Component(productID, componentID);
            }
        }

        public void InsertProduct(Product product)
        {
            Context.Products.Add(product);
        }

        public void UpdateProduct(Product product)
        {
        }
    }
}
