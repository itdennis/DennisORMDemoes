using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDemo_MultiDbContextDemo.Contexts;
using EFDemo_MultiDbContextDemo.Models;

namespace EFDemo_MultiDbContextDemo
{
    class MyStudentCurdTest
    {
        public static void RunTest()
        {
            using (var context = new MyStudentContext())
            {

                //// Create and save a new Students
                //Console.WriteLine("Adding new students");

                //var student = new Student
                //{
                //    FirstMidName = "Alain",
                //    LastName = "Bomer",
                //    EnrollmentDate = DateTime.Parse(DateTime.Today.ToString(CultureInfo.InvariantCulture))
                //    //Age = 24
                //};

                //context.Students.Add(student);

                //var student1 = new Student
                //{
                //    FirstMidName = "Mark",
                //    LastName = "Upston",
                //    EnrollmentDate = DateTime.Parse(DateTime.Today.ToString())
                //    //Age = 30
                //};

                //context.Students.Add(student1);
                //context.SaveChanges();

                // Display all Students from the database
                var students = (from s in context.Students
                    orderby s.FirstMidName
                    select s).ToList<Student>();

                Console.WriteLine("Retrieve all Students from the database:");

                foreach (var stdnt in students)
                {
                    string name = stdnt.FirstMidName + " " + stdnt.LastName;
                    Console.WriteLine("ID: {0}, Name: {1}", stdnt.Id, name);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
