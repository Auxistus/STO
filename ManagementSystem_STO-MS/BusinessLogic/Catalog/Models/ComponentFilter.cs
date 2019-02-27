namespace ManagementSystem.BusinessLogic.Catalog
{
    public class ComponentFilter
    {
        public byte? ComponentTypeID { get; set; }
        public string Name { get; set; }
        public int? ProductID { get; set; }
        public bool IsNotAssignedOnly { get; set; }
    }
}
