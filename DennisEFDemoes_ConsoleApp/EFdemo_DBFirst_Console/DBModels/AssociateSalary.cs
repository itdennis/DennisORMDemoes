using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFdemo_AsyncQuery_Console.DBModels
{
    [Table("AssociateSalary", Schema = "chapter3")]

    public class AssociateSalary
    {
        public int SalaryId { get; set; }
        public int AssociateId { get; set; }
        public decimal Salary { get; set; }
        public DateTime SalaryDate { get; set; }
        public virtual Associate Associate { get; set; }
    }
}
