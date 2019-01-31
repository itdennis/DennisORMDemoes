using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDemo_MultiDbContextDemo.Models;

namespace EFDemo_MultiDbContextDemo.Contexts
{
    public class MyStudentContext : DbContext
    {
        public MyStudentContext() : base("studentDB") { }
        public virtual DbSet<Student> Students { get; set; }
    }
}
