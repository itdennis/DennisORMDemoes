using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using webapi_dennis2.Models;

namespace webapi_dennis2.DBContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("webapi_dennis2")
        {

        }
        public DbSet<SystemInfo> SystemInfos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<SystemInfo>().Property(p => p.RowVersion).IsConcurrencyToken();
        }

    }
}