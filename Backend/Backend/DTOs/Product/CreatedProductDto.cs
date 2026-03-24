namespace Backend.DTOs.Product
{
    public class CreatedProductDto
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int CategoryId { get; set; }
        public List<VariantDto> Variants { get; set; } = null!;
        public bool IsActive { get; set; }
    }
}
