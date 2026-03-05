namespace Backend.DTOs
{
    public class ProductResponseDto
    {
        public string Product {  get; set; }
        public List<ResponseProductVariantDto> Variants { get; set; }
    }
}
