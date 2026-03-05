using ProductModel = Backend.Models.Product.Product;

namespace Backend.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Task<ProductModel> CreateAsync(ProductModel product);
        Task<List<ProductModel>> GetAllAsync();
        Task<ProductModel> GetByIdAsync(int id);
    }
}
