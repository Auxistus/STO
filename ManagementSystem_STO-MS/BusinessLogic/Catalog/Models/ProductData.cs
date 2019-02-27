namespace ManagementSystem.BusinessLogic.Catalog
{
    public class ProductData
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public short Scale { get; set; }

        public string ScaleString
        {
            get
            {
                return string.Concat("1:", Scale);
            }
        }
    }
}
