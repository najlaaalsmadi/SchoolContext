using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SchoolContext.Models
{
   
public class SchoolContext : DbContext
    {
        public SchoolContext() : base("name=SchoolContext")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }

}
