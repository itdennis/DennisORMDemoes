using System.Data.Entity;
using DennisOdataDemoes.Models;

namespace DennisOdataDemoes
{
    public class ProductsContext : DbContext
    {
        public ProductsContext()
                : base("name=ProductsContext")
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}