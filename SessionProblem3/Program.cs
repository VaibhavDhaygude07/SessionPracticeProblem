using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SessionProblem3
{
    class Product
    {
        public int productId { get; set; }
        public string name { get; set; }
        public string category { get; set; }
        public int price { get; set; }
        public int stockQuantity { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //)You have a list of products with ProductID, Name, Category, Price, and StockQuantity.
            //Write a LINQ query to filter out products with stock less than 10.
            //Use Lambda expressions to calculate the total value of products in a specific category.
            //Find the cheapest product in each category.

            List<Product> products = new List<Product>
            {
                new Product{productId=1, name="Mobile", category="Electronic", price=20000, stockQuantity=38},
                new Product{productId=2, name="Chair", category="Furniture", price=12000, stockQuantity=60},
                new Product{productId=3, name="Laptop", category="Electronic", price=48000, stockQuantity=10},
                new Product{productId=4, name="Desk",   category="Furniture", price=10000, stockQuantity=2},
                new Product{productId=5, name="Moniter", category="Electronic", price=65000, stockQuantity=8},
                new Product{productId=6, name="Shirt", category="Accessory", price=200, stockQuantity=100},
                new Product{productId=7, name="Oil", category="Grocery", price=2000, stockQuantity=5},
        
            };
            //Write a LINQ query to filter out products with stock less than 10.
            var productStock = from product in products
                               where product.stockQuantity < 10
                               select product;
            foreach (var product in productStock)
            {
                Console.WriteLine($"Name: {product.name}, Category: {product.category}, Price: {product.price}, Stock quantity: {product.stockQuantity}");
            }

            //Use Lambda expressions to calculate the total value of products in a specific category.
            var totalValue = from product in products
                             group product by product.category into categoryGroup
                             select new
                             {
                                 category = categoryGroup.Key,
                                 total = categoryGroup.Sum(c => c.stockQuantity)
                             };

            foreach (var category in totalValue)
            {
                Console.WriteLine($"Department: {category.category}, TOtal count: {category.total}");
            }

            //Find the cheapest product in each category.
            var cheapestProduct = from product in products
                                  group product by product.category into categoryGroup
                                  select new
                                  {
                                      Category = categoryGroup.Key, 
                                      CheapestProduct = categoryGroup.OrderBy(c => c.price).First() 
                                  };

            foreach (var category in cheapestProduct)
            {
                Console.WriteLine($"Category: {category.Category}, Cheapest Product: {category.CheapestProduct.name}, Price: {category.CheapestProduct.price}");
            }


        }
    }
}
