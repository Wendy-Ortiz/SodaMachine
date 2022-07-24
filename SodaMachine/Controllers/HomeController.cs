using Microsoft.AspNetCore.Mvc;
using SodaMachine.Models;
using System.Diagnostics;

namespace SodaMachine.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var products = GetListOfProducts();
            ViewBag.MainTitle = "MÁQUINA EXPENDEDORA DE REFRESCOS";
            return View(products);
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

        public List<ProductModel> GetListOfProducts()
        {
            List<ProductModel> products = new List<ProductModel>();
            products.Add(new ProductModel { ProductId = 1, ProductName = "Coca Cola", Price = 500, Quantity = 10, ProductImage = "images/coca.jpg" });
            products.Add(new ProductModel { ProductId = 2, ProductName = "Pepsi", Price = 600, Quantity = 8, ProductImage = "images/pepsi.jpg" });
            products.Add(new ProductModel { ProductId = 3, ProductName = "Fanta", Price = 550, Quantity = 10, ProductImage = "images/fanta.jpg" });
            products.Add(new ProductModel { ProductId = 1, ProductName = "Sprite", Price = 725, Quantity = 15, ProductImage = "images/sprite.jpg" });
            return products;
        }
    }
}