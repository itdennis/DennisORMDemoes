using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDemo_MultiDbContextDemo.Models;

namespace EFDemo_MultiDbContextDemo.Contexts
{
    public class MyTeacherContext : DbContext
    {
        public MyTeacherContext() : base("teacherDB") { }
        public virtual DbSet<Teacher> Teachers { get; set; }
    }
}
