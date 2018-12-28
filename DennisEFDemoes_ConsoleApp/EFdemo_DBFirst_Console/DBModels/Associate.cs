using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFdemo_AsyncQuery_Console.DBModels
{
    [Table("Associate", Schema = "chapter3")]
    public class Associate
    {
        public Associate()
        {
            AssociateSalaries = new HashSet<AssociateSalary>();
        }
        public int AssociateId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<AssociateSalary> AssociateSalaries { get; set; }
    }
}
