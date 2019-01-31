namespace EFDemo_MultiDbContextDemo.MyStudentContextMigrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EFDemo_MultiDbContextDemo.Contexts.MyStudentContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"MyStudentContextMigrations";
        }

        protected override void Seed(EFDemo_MultiDbContextDemo.Contexts.MyStudentContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
