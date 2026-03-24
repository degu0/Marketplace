namespace Backend.DTOs.Product
{
    public class VariantDto
    {
        public string Sku { get; set; } = null!;
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public List<AttributeDto> Attributes { get; set; } = null!;
    }
}
