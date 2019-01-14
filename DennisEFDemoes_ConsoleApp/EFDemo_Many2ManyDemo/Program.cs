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
            //LoadData();
            ReadData();

            Console.ReadKey();
        }

        static void LoadData()
        {
            using (var db = new Context())
            {
                var s1 = new Slot() { SlotId = 1001, SlotName = "slotName1001" };
                var s2 = new Slot() { SlotId = 1002, SlotName = "slotName1002" };
                var s3 = new Slot() { SlotId = 1003, SlotName = "slotName1003" };
                var s4 = new Slot() { SlotId = 1004, SlotName = "slotName1004" };
                db.Slots.Add(s1);
                db.Slots.Add(s2);
                db.Slots.Add(s3);
                db.Slots.Add(s4);
                db.SaveChanges();
            }
        }

        static void ReadData()
        {
            using (var db = new Context())
            {
                var sqlCommand = "select count(*) as SlotCount from Slots";
                var res = db.Database.SqlQuery<SlotResult>(sqlCommand).ToList();
                if (res != null)
                {

                }
            }
        }
    }

    class SlotResult
    {
        public int SlotCount { get; set; }
    }
}
