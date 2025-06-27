using Microsoft.AspNetCore.Mvc;
using SwaggerProject.Modells;

namespace SwaggerProject.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public ActionResult<List<Product>> Get()
        {
            return _productService.GetProducts();
        }
        [HttpPost]
        public async Task<IActionResult> Add(Product product)
        {
            await _productService.AddAsync(product);
            return CreatedAtAction(nameof(Get), product);
        }
    }
}