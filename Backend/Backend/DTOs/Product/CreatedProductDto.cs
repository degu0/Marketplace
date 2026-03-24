namespace Backend.DTOs.Product
{
    public class CreatedProductDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public List<VariantDto> Variants { get; set; }
        public bool IsActive { get; set; }
    }
}
