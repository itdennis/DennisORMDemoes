using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EFdemo_LoadMechanism.DBModels;

namespace EFdemo_LoadMechanism
{
    /// <summary>
    /// load mechanism:
    /// 1. lazy load (default)
    /// 2. eager load
    /// 3. explicit load
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var asyncTask = LoadData();
            foreach (var c in BusyChars())
            {
                if (asyncTask.IsCompleted)
                {
                    break;
                }
                Console.Write(c);
                Console.CursorLeft = 0;
                Thread.Sleep(100);
            }
            Console.WriteLine("\nPress <enter> to continue...");
            Console.ReadLine();
        }

        private static IEnumerable<char> BusyChars()
        {
            while (true)
            {
                yield return '\\';
                yield return '|';
                yield return '/';
                yield return '-';
            }
        }
        private static async Task LoadData()
        {
            using (var context = new EF6RecipesEntities())
            {
                Console.WriteLine("Add testing data");
                Console.WriteLine("===============");
                var customer1Type = new CustomerType() { CustomerTypeId = 0, Description = "0000" };
                var customer1Emails = new CustomerEmail() {CustomerEmailId = 001, Email = "dennis008@163.com"};
                var customer1 = new Customer()
                {
                    CustomerTypeId = "1",
                    Name = "Dennis",
                    CustomerType = customer1Type,
                };
                customer1.CustomerEmails.Add(customer1Emails);
                
                context.Customers.Add(customer1);
                await context.SaveChangesAsync();
                await Task.Delay(500);
            }
        }
    }
}
