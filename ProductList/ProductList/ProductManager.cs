using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductList
{
    internal class ProductManager
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Product added successfully!");
            Console.ResetColor();
        }

        public void ShowProducts()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("No products have been added.");
                return;
            }

            // Find the longest category and product name
            int categoryWidth = Math.Max(
                "Category".Length,
                products.Max(p => p.Category.Length)
            ) + 2;

            int nameWidth = Math.Max(
                "Product Name".Length,
                products.Max(p => p.Name.Length)
            ) + 2;

            int priceWidth = 15;

            // Total table width
            int totalWidth = categoryWidth + nameWidth + priceWidth;

            // Center the title
            string title = "===== PRODUCT LIST =====";
            int leftPadding = (totalWidth - title.Length) / 2;

            Console.WriteLine();
            Console.WriteLine(new string(' ', Math.Max(0, leftPadding)) + title);

            // Header
            Console.WriteLine(
                "Category".PadRight(categoryWidth) +
                "Product Name".PadRight(nameWidth) +
                "Price".PadLeft(priceWidth)
            );

            // Separator
            Console.WriteLine(new string('-', totalWidth));

            // Sort products from lowest to highest price
            var sortedProducts = products.OrderBy(p => p.Price);

            foreach (var product in sortedProducts)
            {
                Console.WriteLine(
                    product.Category.PadRight(categoryWidth) +
                    product.Name.PadRight(nameWidth) +
                    $"{product.Price} kr".PadLeft(priceWidth)
                );
            }
        }

        public decimal CalculateTotal()
        {
            return products.Sum(p => p.Price);
        }

        public int GetTableWidth()
        {
            if (products.Count == 0)
            {
                return 0;
            }

            int categoryWidth = Math.Max(
                "Category".Length,
                products.Max(p => p.Category.Length)
            ) + 2;

            int nameWidth = Math.Max(
                "Product Name".Length,
                products.Max(p => p.Name.Length)
            ) + 2;

            int priceWidth = 15;

            return categoryWidth + nameWidth + priceWidth;
        }
    }
}
