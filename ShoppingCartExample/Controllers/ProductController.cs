using Microsoft.AspNetCore.Mvc;
using ShoppingCartExample.Services;

namespace ShoppingCartExample.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _productService.GetAllProducts();

            return View(products);
        }
    }
}
