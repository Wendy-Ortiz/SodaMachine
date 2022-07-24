using Microsoft.AspNetCore.Mvc;
using SodaMachine.Models;
using SodaMachine.Handlers;
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
            ProductsHandler productsHandler = new ProductsHandler();
            var products = productsHandler.GetListOfProducts();
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
        
        public IActionResult DeleteProduct(string name)
        {
            ActionResult view;
            try
            {
                var productHandler = new ProductsHandler();
                var actualProducts = productHandler.GetActualListOfProducts();
                var product = actualProducts.Find(model => model.ProductName == name);
                if (product == null)
                {
                    //TODO: error view
                    view = RedirectToAction("Index");
                }
                else
                {
                    actualProducts = productHandler.DeleteProduct(name);
                    view = View(actualProducts);
                }
            }
            catch
            {
                //TODO: error view
                view = RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult GetQuantityAvailable(string name)
        {
            ActionResult view;
            try
            {
                var productHandler = new ProductsHandler();
                var actualProducts = productHandler.GetActualListOfProducts();
                var product = actualProducts.Find(model => model.ProductName == name);
                if (product == null)
                {
                    //TODO: error view
                    view = RedirectToAction("Index");
                }
                else
                {
                    int quantity = productHandler.GetQuantityAvailable(name);
                    view = View(quantity);
                }
            }
            catch
            {
                //TODO: error view
                view = RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult SelectProduct(string name)
        {

            var productHandler = new ProductsHandler();
            var selectedProducts = productHandler.SelectProduct(name);
            var product = productHandler.GetQuantityAvailable(name);
            if (product < selectedProducts.Count())
            {
                ViewBag.ErroMessage = "Cantidad inválida";
            }
            else
            {
                ViewBag.Quantity += 1;
            }
           
            return View();
        }
    }
}