using System;
using System.Net;
using Microsoft.OData.Client;
using ProductsApp.DennisOdataDemoes;
using ProductsApp.DennisOdataDemoes.Models;
using System.Linq;

namespace ProductsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string serviceUri = "http://localhost:62253/";
            var container = new Default.Container(new Uri(serviceUri));
            //IRepository<Product> productRepository = new DbContextRepository<Product>(container);
            var pr = container.Products.Select(p => p).Where(p => p.Id == 1).FirstOrDefault();
            var product = new Product()
            {
                Id = 1,
                Name = "Yo-yo update 1",
                Category = "Toys",
                Price = 4.95M
            };

            //pr.Name = "updated p name";
            container.DeleteObject(pr);

            try
            {
                new Func<DataServiceResponse>(() => container.SaveChanges()).SafeSaveChange(HttpStatusCode.Created);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
            Console.WriteLine(product.Name);
        }
    }
}
