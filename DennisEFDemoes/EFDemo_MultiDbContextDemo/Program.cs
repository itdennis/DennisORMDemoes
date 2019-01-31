using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo_MultiDbContextDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStudentCurdTest.RunTest();
            MyteacherCurdTest.RunTest();
            Console.ReadKey();
        }
    }
}
