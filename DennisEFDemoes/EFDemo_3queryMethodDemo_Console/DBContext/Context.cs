using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDemo_3queryMethodDemo_Console.Models;

namespace EFDemo_3queryMethodDemo_Console.DBContext
{
    public class Context : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Chapter3.Customers");
            base.OnModelCreating(modelBuilder);
        }
    }
}
