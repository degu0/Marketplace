using ProductModel = Backend.Models.Product.Product;
using Backend.Services.Product;
using Backend.Repositories.Interfaces;

namespace Backend.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository ;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<ProductModel> CreatedProduct(ProductModel product)
        {
            return await _productRepository.CreateAsync(product);
        }

        public async Task<List<ProductModel>> GetAll()
        {
            return await _productRepository.GetAllAsync();
        }

        public async Task<ProductModel> GetById(int id)
        {
            return await _productRepository.GetByIdAsync(id);
        }
    }
}
