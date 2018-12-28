using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDemo_3queryMethodDemo_Console.Models
{
    [Table("EFRecipesEntities3", Schema = "chapter3")]
    public class Customer
    {
        public int CatId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
