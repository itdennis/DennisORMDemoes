using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo_ModelFirstdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Model1Container())
            {
                var flight = new Flight(){FlightId = 1003, FlightName = "rrrr", FlightOwner = "v-yanywu", FlightPara1 = "rrrdd"};
                db.Flights.Add(flight);
                db.SaveChanges();
            }
        }
    }
}
