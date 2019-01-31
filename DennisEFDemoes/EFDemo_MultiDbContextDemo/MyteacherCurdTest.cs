using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDemo_MultiDbContextDemo.Contexts;
using EFDemo_MultiDbContextDemo.Models;

namespace EFDemo_MultiDbContextDemo
{
    class MyteacherCurdTest
    {
        public static void RunTest()
        {
            using (var context = new MyTeacherContext())
            {

                //// Create and save a new Teachers
                Console.WriteLine("Adding new teachers");

                var student = new Teacher
                {
                    FirstMidName = "Alain",
                    LastName = "Bomer",
                    HireDate = DateTime.Parse(DateTime.Today.ToString())
                    //Age = 24
                };

                context.Teachers.Add(student);

                var student1 = new Teacher
                {
                    FirstMidName = "Mark",
                    LastName = "Upston",
                    HireDate = DateTime.Parse(DateTime.Today.ToString())
                    //Age = 30
                };

                context.Teachers.Add(student1);
                context.SaveChanges();

                // Display all Teachers from the database
                var teachers = (from t in context.Teachers
                    orderby t.FirstMidName
                    select t).ToList<Teacher>();

                Console.WriteLine("Retrieve all teachers from the database:");

                foreach (var teacher in teachers)
                {
                    string name = teacher.FirstMidName + " " + teacher.LastName;
                    Console.WriteLine("ID: {0}, Name: {1}", teacher.Id, name);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
