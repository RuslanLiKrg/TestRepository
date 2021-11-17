using System;
using System.Collections.Generic;

namespace SumApp
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> products = new List<Product>() { new Product() { Id = 1, Name = "Kayak", Price = 1200},
                                                            new Product(){ Id = 2, Name = "Book", Price = 4500},
                                                            new Product() { Id = 3, Name = "Table", Price = 6500}
            };

            GetSum(products);
            Console.ReadKey();
        }
        public static int GetSum(List<Product> products)
        {
            int price = 0;
            foreach (var product in products)
            {
                price += product.Price;
            }

            return price;
        }
    }
}
