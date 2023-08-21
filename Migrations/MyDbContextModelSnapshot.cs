﻿// <auto-generated />
using Database_class;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Database_class.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Database_class.Models.CoursesDTO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CourseDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseDescription = "C# is a programming language",
                            CourseName = "C#"
                        },
                        new
                        {
                            Id = 2,
                            CourseDescription = "Java is a programming language",
                            CourseName = "Java"
                        },
                        new
                        {
                            Id = 3,
                            CourseDescription = "Python is a programming language",
                            CourseName = "Python"
                        },
                        new
                        {
                            Id = 4,
                            CourseDescription = "C++ is a programming language",
                            CourseName = "C++"
                        },
                        new
                        {
                            Id = 5,
                            CourseDescription = "JavaScript is a programming language",
                            CourseName = "JavaScript"
                        },
                        new
                        {
                            Id = 6,
                            CourseDescription = "PHP is a programming language",
                            CourseName = "PHP"
                        });
                });

            modelBuilder.Entity("Database_class.Models.TutorsDTO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tutors");
                });
#pragma warning restore 612, 618
        }
    }
}
