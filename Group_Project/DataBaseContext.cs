using Desktop_App.Model;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Project
{
    public class DataBaseContext : DbContext
    {
        private readonly string relpath = "Datafile.db";
        private readonly string path;
        protected override void OnConfiguring(DbContextOptionsBuilder
            optionsBuilder) => optionsBuilder.UseSqlite($"Data Source={path}");

        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Module> Modules { get; set; }





        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasOne(s => s.User)
                .WithMany(u => u.Students)
                .HasForeignKey(s => s.UserId);


            modelBuilder.Entity<Course>()
               .HasOne(s => s.User)
               .WithMany(u => u.Courses)
               .HasForeignKey(s => s.UserId);


            modelBuilder.Entity<Student>()
           .HasOne(s => s.Course)
           .WithMany(c => c.Students)
           .HasForeignKey(s => s.CourseId);

            modelBuilder.Entity<Module>()
       .HasOne(s => s.Course)
       .WithMany(c => c.Modules)
       .HasForeignKey(s => s.CourseId);



        }
        public DataBaseContext()
        {
            path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relpath);
        }


      

    }
}
