using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDemo_Many2ManyDemo.DBModels;

namespace EFDemo_Many2ManyDemo.DBContext
{
    public class Context : DbContext
    {
        //public Context() : base("DefaultConnection")
        //{
        //}

        public DbSet<Ranker> Rankers { get; set; }
        public DbSet<Slot> Slots { get; set; }
        public DbSet<Model> Models { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
