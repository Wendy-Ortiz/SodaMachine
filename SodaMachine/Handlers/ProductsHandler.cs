using SodaMachine.Models;
using System.Data;

namespace SodaMachine.Handlers
{
    public class ProductsHandler
    {
        
        public ProductsHandler()
        {
            var builder = WebApplication.CreateBuilder();
        }

        List<ProductModel> products = new List<ProductModel>();

        public List<ProductModel> GetListOfProducts()
        {
            products.Add(new ProductModel { ProductId = 1, ProductName = "Coca Cola", Price = 500, Quantity = 10, ProductImage = "images/coca.jpg" });
            products.Add(new ProductModel { ProductId = 2, ProductName = "Pepsi", Price = 600, Quantity = 8, ProductImage = "images/pepsi.jpg" });
            products.Add(new ProductModel { ProductId = 3, ProductName = "Fanta", Price = 550, Quantity = 10, ProductImage = "images/fanta.jpg" });
            products.Add(new ProductModel { ProductId = 4, ProductName = "Sprite", Price = 725, Quantity = 15, ProductImage = "images/sprite.jpg" });
            return products;
        }

        public List<ProductModel> InsertProducts(string productToInsert)
        {
            foreach (var item in products)
            {
                if (productToInsert == item.ProductName)
                {
                    item.Quantity += 1;
                    break;
                }
            }
            return products;
        }

        public List<ProductModel> DeleteProduct(string productToDelete)
        {
            foreach (var item in products)
            {
                if (productToDelete == item.ProductName)
                {
                    item.Quantity -= 1;
                    break;
                }
            }
            return products;
        }
        List<string> temporalProducts = new List<string>();
        public List<string> SelectProduct(string productSelect)
        {
            temporalProducts.Add(productSelect);
            return temporalProducts;
        }

        public int GetQuantityAvailable(string productToSearch)
        {
            int result = 0;
            foreach (var item in products)
            {
                result = 0;
                if (productToSearch == item.ProductName)
                {
                    result = item.Quantity;
                    break;
                }
            }
            return result;
        }
        public List<ProductModel> GetActualListOfProducts()
        {
            return products;
        }

        public List<string> GetTemporalProducts()
        {
            return temporalProducts;
        }
    }
}
