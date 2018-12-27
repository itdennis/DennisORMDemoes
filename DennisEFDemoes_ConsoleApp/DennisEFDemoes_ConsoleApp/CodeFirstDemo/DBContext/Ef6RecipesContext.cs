using System.Data.Entity;
using DennisEFDemoes_ConsoleApp.CodeFirstDemo.DBModels;

namespace DennisEFDemoes_ConsoleApp.CodeFirstDemo.DBContext
{
    public class Ef6RecipesContext : DbContext
    {
        public DbSet<PictureCategory> PictureCategories { get; set; }
        public Ef6RecipesContext()
            : base("name=EF6CodeFirstRecipesContext")
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
        }
    }
}
