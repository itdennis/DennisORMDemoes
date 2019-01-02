using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo_CodeFirstExistingDatabaseSample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new WaspContext())
            {
                // Create and save a new Blog
                Console.Write("Enter a name for a new Blog: ");
                var name = Console.ReadLine();

                //var blog = new Blog { Name = name };
                //db.Blogs.Add(blog);
                //db.SaveChanges();

                // Display all Blogs from the database
                var query = from b in db.JobInfoes
                    orderby b.CreateDtm
                    select b;

                Console.WriteLine("All blogs in the database:");
                foreach (var item in query)
                {

                    Console.WriteLine(item.Id);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
