using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ManualCRUD.Models
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext():base("StudentConStr")
        {
            Database.SetInitializer<StudentDbContext>(null);
        }
        public DbSet<Student> Students { get; set; }
    }
}