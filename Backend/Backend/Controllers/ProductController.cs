using ProductModel = Backend.Models.Product.Product;
using Backend.Services.Product;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> CreatedPorduct(ProductModel product)
        {
            await _service.CreatedProduct(product);
            return CreatedAtAction(nameof(GetById), new { id = product.Id });
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _service.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) 
        { 
            var product = await _service.GetById(id);
            if (product == null)
                return NotFound(new { message = "Product not found" });

            return Ok(product);
        }
    }
}
