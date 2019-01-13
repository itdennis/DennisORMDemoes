using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDemo_Many2ManyDemo.DBContext;
using EFDemo_Many2ManyDemo.DBModels;

namespace EFDemo_Many2ManyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Context())
            {
                
                string sqlCommand = "select distinct s.SlotId, s.SlotName, COUNT(*) as RankerUsage from Slots s " +
                                    "join SlotRankers sr on sr.Slot_SlotId = s.SlotId" +
                                    "join Rankers r on r.RankerId = sr.Ranker_RankerId " +
                                    "group by s.SlotId, s.SlotName";
                string sql1 = "select s.SlotId, s.SlotName from Slots s";
                var rowCount = db.Database.ExecuteSqlCommand(sql1);
                var res = from s in db.Slots
                    from r in db.Rankers
                    where s.Rankers.Any(sr => sr.RankerId == r.RankerId)
                    select s;


            }

            Console.ReadKey();
        }
    }

    class RankerModel
    {
        public int SlotId { get; set; }
        public string SlotName { get; set; }
        public int RankerUsage { get; set; }
    }
}
