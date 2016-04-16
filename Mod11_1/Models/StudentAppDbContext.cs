using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mod11_1.Models
{
    public class StudentAppDbContext : DbContext
    {
        public StudentAppDbContext():
            base("StudentConnection")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<ClassRoom> ClassRooms { get; set; }
    }
}