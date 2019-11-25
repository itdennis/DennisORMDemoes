using System;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using DennisEFDemoes_ConsoleApp.CodeFirstDemo.DBModels;

namespace DennisEFDemoes_ConsoleApp.CodeFirstDemo.DBContext
{
    public class Ef6RecipesContext : DbContext
    {
        private static string connectionStr = GetConnectionString();
        public DbSet<PictureCategory> PictureCategories { get; set; }
        public DbSet<SystemInfo> SystemInfos { get; set; }
        public Ef6RecipesContext()
            : base(connectionStr)
        {
        }
        /// <summary>
        /// 在EF6RecipesContext中重写方法OnModelCreating配置双向关联(ParentCategory 和 SubCategories）
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PictureCategory>().HasMany(t => t.Subcategories).WithOptional(t => t.ParentCategory);
            modelBuilder.Entity<SystemInfo>().Property(p => p.RowVersion).IsConcurrencyToken();
        }

        private static string GetConnectionString()
        {
            string serverName = @"stcav-235\stcav235";
            string databaseName = "EF6Recipes";
            SqlConnectionStringBuilder sqlBuilder =
                new SqlConnectionStringBuilder();

            sqlBuilder.DataSource = serverName;
            sqlBuilder.InitialCatalog = databaseName;
            sqlBuilder.IntegratedSecurity = true;
            sqlBuilder.UserID = "sa";
            sqlBuilder.Password = "1qaz2wsxE";

            return sqlBuilder.ToString();
        }

    }
}
