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

            //var product = container.Products.Select(p => p).Where(p => p.Id == 2002).FirstOrDefault();


            //container.DeleteObject(product);

            //product.Name = "updated 2002 name";
            //container.UpdateObject(product);


            var product = new Product()
            {
                Name = "Yo-yo update 1",
                Category = "Toys",
                Price = 4.95M
            };
            container.AddToProducts(product);





            try
            {
                new Func<DataServiceResponse>(() => container.SaveChanges()).SafeSaveChange(HttpStatusCode.Created, product.GetType());
                Console.WriteLine($"the operation of entity is {product.Id}.");
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
