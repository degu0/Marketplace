namespace Backend.DTOs
{
    public class ResponseProductVariantDto
    {
        public string Sku { get; set; }
        public Dictionary<string, string> Attributes { get; set; } = new();
    }
}
