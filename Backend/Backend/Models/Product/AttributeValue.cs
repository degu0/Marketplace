namespace Backend.Models.Product
{
    public class AttributeValue
    {
        public int Id { get; set; }
        public int AttributeId { get; set; }
        public Attribute Attribute { get; set; } = null!;
        public string Value { get; set; } = string.Empty;
    }
}
