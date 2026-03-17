namespace Backend.Models.Product
{
    public class VariantAttribute
    {
        public int Id { get; set; }
        public ProductVariant Variant { get; set; } = null!;
        public AttributeValue AttributeValue { get; set; } = null!;
    }
}
