namespace Backend.Models.Product
{
    public class VariantAttribute
    {
        public int Id { get; set; }
        public ProductVariant Variant { get; set; }
        public AttributeValue AttributeValue { get; set; }
    }
}
