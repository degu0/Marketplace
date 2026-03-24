namespace Backend.DTOs.Product
{
    public class ResponseProductVariantDto
    {
        public string Sku { get; set; } = null!;
        public Dictionary<string, string> Attributes { get; set; } = new();
    }
}
