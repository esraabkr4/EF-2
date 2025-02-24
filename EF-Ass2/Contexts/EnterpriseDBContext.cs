﻿

using EF_Ass2.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using EF_Ass2.Configurations;
namespace EF_Demo.Contexts
{
    internal class EnterpriseDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data source=.;Initial Catalog=FirstEF;UserId=myname;Password=123");
            optionsBuilder.UseSqlServer("Server=.;Database=ITIdatabase;Trusted_Connection=true;TrustServerCertificate=true");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Stud_Course>(new Stud_CourseConfigurations());
            modelBuilder.ApplyConfiguration<Course_Inst>(new Course_InstConfigurations());

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Course_Inst> Course_Insts { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
    }
}
