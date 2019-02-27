using System.Linq;
using System.Collections.Generic;
using ManagementSystem.Database;
using System.ComponentModel;

namespace ManagementSystem.BusinessLogic.Catalog
{
    public class ComponentTypeRepository : Repository
    {
        public List<KeyValuePair<byte, string>> GetComponentTypeForDropDown()
        {
            return Context.ComponentTypes
                .Where(x => x.IsVisible == true)
                .OrderBy(x => x.Name)
                .ToList()
                .Select(x => new KeyValuePair<byte, string>(x.ID, x.Name))
                .ToList();
        }

        public BindingList<ComponentTypeData> GetComponentTypes()
        {
            var list = Context.ComponentTypes
                .Select(x => new ComponentTypeData
                {
                    ID = x.ID,
                    Name = x.Name,
                    IsVisible = x.IsVisible
                })
                .OrderBy(x => x.Name)
                .ToList();

            return new BindingList<ComponentTypeData>(list);
        }

        public void InsertComponentType(ComponentType componentType)
        {
            Context.ComponentTypes.Add(componentType);
        }
    }
}