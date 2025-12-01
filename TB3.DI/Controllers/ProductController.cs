using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TB3.DI.Services.Product;

namespace TB3.DI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductResponseModel>> GetProduct(int id)
        {
            var product = await _productService.GetProductAsync(id);
            if (product is null)
            {
                return NotFound();
            }
            
            return Ok(product);
        }
    }
}
