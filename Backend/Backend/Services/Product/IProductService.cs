using ProductModel = Backend.Models.Product.Product;

namespace Backend.Services.Product
{
    public interface IProductService
    {
        Task<List<ProductModel>> GetAll();
        Task<ProductModel> GetById(int id);
        Task<ProductModel> CreatedProduct(ProductModel product);
    }
}
