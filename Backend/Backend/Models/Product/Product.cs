namespace Backend.Models.Product
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Category Category { get; set; }
        public bool IsActive { get; set; }
    }
}
