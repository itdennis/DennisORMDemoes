using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo_Many2ManyDemo.DBModels
{
    public class Slot
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Key]
        public int SlotId { get; set; }
        public string SlotName { get; set; }

        public virtual ICollection<Ranker> Rankers { get; set; } = new HashSet<Ranker>();
    }
}
