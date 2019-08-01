using System;
using ProductsApp.DennisOdataDemoes;
using ProductsApp.DennisOdataDemoes.Models;

namespace ProductsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string serviceUri = "http://localhost:62253/";
            var container = new Default.Container(new Uri(serviceUri));
            //IRepository<Product> productRepository = new DbContextRepository<Product>(container);
            var product = new Product()
            {
                Name = "Yo-yo 4",
                Category = "Toys",
                Price = 4.95M
            };
            container.AddToProducts(product);
            var res = container.SaveChanges();
            Console.WriteLine(product.Name);
        }
    }
}
