using System;
using ProductsApp.DennisOdataDemoes;
using ProductsApp.DennisOdataDemoes.Models;

namespace ProductsApp
{
    class Program
    {

        //public static void AddProduct(Default.Container container, Product product)
        //{
        //    container.AddToProducts(product);
        //    var serviceResponse = container.SaveChanges();
        //    foreach (var operationResponse in serviceResponse)
        //    {
        //        Console.WriteLine("Response: {0}", operationResponse.StatusCode);
        //    }
        //}

        //public static void ListAllProducts(Default.Container container)
        //{
        //    foreach (var p in container.Products)
        //    {
        //        Console.WriteLine("{0} {1} {2}", p.Name, p.Price, p.Category);
        //    }
        //}


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
            //var e1 = new Employee()
            //{
            //    Name = "dennis",
            //};

            //AddProduct(container, product);
            //ListAllProducts(container);
        }
    }
}
