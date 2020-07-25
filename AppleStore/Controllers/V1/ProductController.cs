using AppleStore.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AppleStore.Controllers.V1
{
    public class ProductController : Controller
    {
        private IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var cart = _productRepository.GetCart();
            return View(cart);
        }
    }
}