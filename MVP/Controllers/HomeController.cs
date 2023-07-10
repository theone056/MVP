using Microsoft.AspNetCore.Mvc;
using MVP.Models;
using MVP.Services.API.Product.Interface;
using System.Diagnostics;

namespace MVP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductAPIService _productService;

        public HomeController(ILogger<HomeController> logger, IProductAPIService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult ProductList()
        {
            var products = _productService.GetProduts().Result;
            return View(products);
        }
    }
}