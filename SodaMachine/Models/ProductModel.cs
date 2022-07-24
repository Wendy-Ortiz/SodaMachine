using System;

namespace SodaMachine.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; } = 0;

        public string ProductName { get; set; } = string.Empty;

        public double Price { get; set; } = 0.0;

        public int Quantity { get; set; } = 0;

        public string? ProductImage { get; set; }

    }
}
