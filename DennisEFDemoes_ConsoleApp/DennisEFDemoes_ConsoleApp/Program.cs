using System;
using System.Linq;
using System.Text;
using DennisEFDemoes_ConsoleApp.CodeFirstDemo.DBContext;
using DennisEFDemoes_ConsoleApp.CodeFirstDemo.DBModels;

namespace DennisEFDemoes_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            RunExample();
            Console.ReadKey();

        }

        static void RunExample()
        {
            using (var context = new Ef6RecipesContext())
            {
                var louvre = new PictureCategory { Name = "Louvre" };
                var child = new PictureCategory { Name = "Egyptian ANTIQUITéS" };
                louvre.Subcategories.Add(child);
                child = new PictureCategory { Name = "Sculptures" };
                louvre.Subcategories.Add(child);
                child = new PictureCategory { Name = "Paintings" };
                louvre.Subcategories.Add(child);
                var paris = new PictureCategory { Name = "Paris" };
                paris.Subcategories.Add(louvre);
                var vacation = new PictureCategory { Name = "Summer Vacation" };
                vacation.Subcategories.Add(paris);
                context.PictureCategories.Add(paris);
                context.SaveChanges();
            }
            using (var context = new Ef6RecipesContext())
            {
                var roots = context.PictureCategories.Where(c => c.ParentCategory == null);
                roots.ToList().ForEach(root => Print(root, 0));
            }
        }
        static void Print(PictureCategory cat, int level)
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("{0}{1}", sb.Append(' ', level).ToString(), cat.Name);
            cat.Subcategories.ForEach(child => Print(child, level + 1));
        }
    }
}
