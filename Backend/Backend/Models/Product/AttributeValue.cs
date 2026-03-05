namespace Backend.Models.Product
{
    public class AttributeValue
    {
        public int Id { get; set; }
        public Attribute Attribute { get; set; }
        public string Value { get; set; } = string.Empty;
    }
}
