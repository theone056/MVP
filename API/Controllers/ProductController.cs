using Data.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static IProduct _product;
        public ProductController(IProduct product)
        {
            _product = product;
        }

        [HttpGet]
        public IActionResult GetProduct()
        {
            return Ok(_product.Products());
        }
    }
}
