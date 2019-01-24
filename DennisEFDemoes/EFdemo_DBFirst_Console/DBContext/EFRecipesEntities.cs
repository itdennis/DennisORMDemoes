using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFdemo_AsyncQuery_Console.DBModels;

namespace EFdemo_AsyncQuery_Console.DBContext
{
    public class EFRecipesEntities : DbContext
    {
        public EFRecipesEntities()
            : base("name=EFAsyncQueryRecipesContext")
        {
        }

        public DbSet<Associate> Associates { get; set; }
        public DbSet<AssociateSalary> AssociateSalaries { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Associate>().ToTable("Chapter3.Associate");
            modelBuilder.Entity<AssociateSalary>().ToTable("Chapter3.AssociateSalary");

            //显示分配实体键为AssociateSalary表的主键，以免实体框架使用默认映射约定
            modelBuilder.Entity<AssociateSalary>().HasKey(x => x.SalaryId);
            base.OnModelCreating(modelBuilder);
        }
    }
}
