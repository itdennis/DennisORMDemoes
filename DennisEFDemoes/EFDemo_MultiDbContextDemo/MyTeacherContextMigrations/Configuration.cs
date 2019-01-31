namespace EFDemo_MultiDbContextDemo.MyTeacherContextMigrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EFDemo_MultiDbContextDemo.Contexts.MyTeacherContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"MyTeacherContextMigrations";
        }

        protected override void Seed(EFDemo_MultiDbContextDemo.Contexts.MyTeacherContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
