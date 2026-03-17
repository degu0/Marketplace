namespace Backend.DTOs
{
    public class ProductResponseDto
    {
        public string Product { get; set; } = null!;
        public List<ResponseProductVariantDto> Variants { get; set; } = null!;
    }
}
