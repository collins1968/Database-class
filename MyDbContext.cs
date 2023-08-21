using Database_class.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Database_class
{
    public class MyDbContext : DbContext
    {

        //private readonly IConfiguration _configuration;
        //public DbSet<UsersDTO> Users { get; set; }

        public DbSet<CoursesDTO> Courses { get; set; }

        public DbSet<TutorsDTO> Tutors { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    string connectionString = ConfigurationManager.ConnectionStrings["MyDbContext"].ConnectionString;


        //    optionsBuilder.UseSqlServer(connectionString);
        //}
        //public MyDbContext(IConfiguration configuration)
        //{
        //    _configuration = configuration;
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string connectionString = _configuration.GetConnectionString("MyDbContext");
            optionsBuilder.UseSqlServer("Server=COLLO;Database=Cohort;Trusted_Connection=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoursesDTO>().HasData(

                new CoursesDTO { Id = 1, CourseName = "C#", CourseDescription = "C# is a programming language" });
            var coursesList = new CoursesDTO[]
            {
                   new CoursesDTO { Id = 2, CourseName = "Java", CourseDescription = "Java is a programming language" },
                   new CoursesDTO { Id = 3, CourseName = "Python", CourseDescription = "Python is a programming language" },
                   new CoursesDTO { Id = 4, CourseName = "C++", CourseDescription = "C++ is a programming language" },
                   new CoursesDTO { Id = 5, CourseName = "JavaScript", CourseDescription = "JavaScript is a programming language" },
                   new CoursesDTO { Id = 6, CourseName = "PHP", CourseDescription = "PHP is a programming language" },
            };
            modelBuilder.Entity<CoursesDTO>().HasData(coursesList);
        }
       
    }
    }

