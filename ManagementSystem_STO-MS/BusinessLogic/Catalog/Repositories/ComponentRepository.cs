using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using ManagementSystem.Common;
using ManagementSystem.Database;

namespace ManagementSystem.BusinessLogic.Catalog
{
    public class ComponentRepository : Repository
    {
        public Database.Component GetComponent(int id)
        {
            return Context.Components
                .FirstOrDefault(x => x.ID == id);
        }

        public BindingList<ComponentData> GetComponents(ComponentFilter filter)
        {
            var query = Context.Components.AsQueryable();

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

        public BindingList<ProductData> GetProducts(int componentID)
        {
            var list = Context.Product_Component
                .Where(x => x.ComponentID == componentID)
                .Select(x => new ProductData
                {
                    ID = x.ProductID,
                    Name = x.Product.Name,
                    Scale = x.Product.Scale
                })
                .OrderBy(x => x.ID)
                .ToList();

            return new BindingList<ProductData>(list);
        }

        public List<KeyValuePair<int, string>> GetComponentsForDropDown()
        {
            return Context.Components
                .Include(x => x.ComponentType)
                .OrderBy(x => x.Name)
                .ToList()
                .Select(x => new KeyValuePair<int, string>(x.ID, "{0} ({1})".FormatWith(x.Name, x.ComponentType.Name)))
                .ToList();
        }

        public void InsertComponent(Database.Component component)
        {
            component.Quantity = 0;

            Context.Components.Add(component);
        }

        public void UpdateComponent(Database.Component component)
        {
        }
    }
}
