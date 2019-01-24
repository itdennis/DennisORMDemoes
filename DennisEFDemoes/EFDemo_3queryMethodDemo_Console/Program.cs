using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDemo_3queryMethodDemo_Console.DBContext;
using EFDemo_3queryMethodDemo_Console.Models;

namespace EFDemo_3queryMethodDemo_Console
{
    class Program
    {
        /// <summary>
        /// 3 ways to query in EF: 1. linq to entity. 2. entity sql. 3. original sql.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            using (var context = new Context())
            {
                // 删除测试数据
                context.Database.ExecuteSqlCommand("delete from chapter3.customer");
                // 添加新的测试数据
                var cus1 = new Customer
                {
                    Name = "Robert Stevens",
                    Email = "rstevens@mymail.com"
                };
                var cus2 = new Customer
                {
                    Name = "Julia Kerns",
                    Email = "julia.kerns@abc.com"
                };
                var cus3 = new Customer
                {
                    Name = "Nancy Whitrock",
                    Email = "nrock@myworld.com"
                };
                context.Customers.Add(cus1);
                context.Customers.Add(cus2);
                context.Customers.Add(cus3);
                context.SaveChanges();
            }

            //使用ObjectContext对象中的 object services
            using (var context = new Context())
            {
                Console.WriteLine("Querying Customers with eSQL Leveraging Object Services...");
                string esql = "select value c from Customers as c";
                // 将DbContext转换为底层的ObjectContext, 因为DbContext没有提供对Entity SQL查询的支持
                var customers = ((IObjectContextAdapter)context).ObjectContext.CreateQuery<Customer>(esql);
                foreach (var customer in customers)
                {
                    Console.WriteLine("{0}'s email is: {1}",
                                       customer.Name, customer.Email);
                }
            }

            Console.WriteLine(System.Environment.NewLine);

            //使用 EntityClient
            using (var conn = new EntityConnection("name=EFRecipesEntities"))
            {
                Console.WriteLine("Customers Customers with eSQL Leveraging Entity Client...");
                var cmd = conn.CreateCommand();
                conn.Open();
                cmd.CommandText = "select value c from EFRecipesEntities.Customers as c";
                using (var reader = cmd.ExecuteReader(CommandBehavior.SequentialAccess))
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("{0}'s email is: {1}",
                                           reader.GetString(1), reader.GetString(2));
                    }
                }
            }

            Console.WriteLine("\nPress <enter> to continue...");
            Console.ReadLine();
        }
    }
    
}
