using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo_Just4Test
{
    class Program
    {
        static void Main(string[] args)
        {

            TestGetData();
            Console.ReadLine();
        }

        private static void TestGetData()
        {
            using (var _container = new waspEntities())
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                var result = _container.JobInfoes.Select(a => a).Take(1000).ToArray();
                stopWatch.Stop();
                Console.WriteLine(stopWatch.Elapsed.TotalSeconds);
                result = _container.JobInfoes.Select(a => a).Take(1000).ToArray();
                stopWatch.Restart();
                stopWatch.Stop();
                Console.WriteLine(stopWatch.Elapsed.TotalSeconds);
            }
        }
    }
}
