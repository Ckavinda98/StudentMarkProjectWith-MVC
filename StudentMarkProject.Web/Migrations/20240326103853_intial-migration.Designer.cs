﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentMarkProject.Web.Models;

#nullable disable

namespace StudentMarkProject.Web.Migrations
{
    [DbContext(typeof(StudentMarkProjectDbContext))]
    [Migration("20240326103853_intial-migration")]
    partial class intialmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StudentMarkProject.Web.Models.Grade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("GradeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("StudentMarkProject.Web.Models.School", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int");

                    b.Property<int?>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Schools");
                });

            modelBuilder.Entity("StudentMarkProject.Web.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StudentMarkId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentMarkId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("StudentMarkProject.Web.Models.StudentEnrollment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GradeId")
                        .HasColumnType("int");

                    b.Property<int>("SchoolId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("StudentEnrollments");
                });

            modelBuilder.Entity("StudentMarkProject.Web.Models.StudentMark", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Marks")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("StudentMarks");
                });

            modelBuilder.Entity("StudentMarkProject.Web.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("StudentMarkId")
                        .HasColumnType("int");

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentMarkId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("StudentMarkProject.Web.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StudentMarkId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentMarkId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("StudentMarkProject.Web.Models.TeacherEnrollment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("SchoolId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TeacherEnrollments");
                });

            modelBuilder.Entity("StudentMarkProject.Web.Models.Grade", b =>
                {
                    b.HasOne("StudentMarkProject.Web.Models.Student", null)
                        .WithMany("Grades")
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("StudentMarkProject.Web.Models.School", b =>
                {
                    b.HasOne("StudentMarkProject.Web.Models.Student", null)
                        .WithMany("Schools")
                        .HasForeignKey("StudentId");

                    b.HasOne("StudentMarkProject.Web.Models.Teacher", null)
                        .WithMany("Schools")
                        .HasForeignKey("TeacherId");
                });

            modelBuilder.Entity("StudentMarkProject.Web.Models.Student", b =>
                {
                    b.HasOne("StudentMarkProject.Web.Models.StudentMark", null)
                        .WithMany("Students")
                        .HasForeignKey("StudentMarkId");
                });

            modelBuilder.Entity("StudentMarkProject.Web.Models.Subject", b =>
                {
                    b.HasOne("StudentMarkProject.Web.Models.StudentMark", null)
                        .WithMany("Subjects")
                        .HasForeignKey("StudentMarkId");

                    b.HasOne("StudentMarkProject.Web.Models.Teacher", null)
                        .WithMany("Subjects")
                        .HasForeignKey("TeacherId");
                });

            modelBuilder.Entity("StudentMarkProject.Web.Models.Teacher", b =>
                {
                    b.HasOne("StudentMarkProject.Web.Models.StudentMark", null)
                        .WithMany("Teachers")
                        .HasForeignKey("StudentMarkId");
                });

            modelBuilder.Entity("StudentMarkProject.Web.Models.Student", b =>
                {
                    b.Navigation("Grades");

                    b.Navigation("Schools");
                });

            modelBuilder.Entity("StudentMarkProject.Web.Models.StudentMark", b =>
                {
                    b.Navigation("Students");

                    b.Navigation("Subjects");

                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("StudentMarkProject.Web.Models.Teacher", b =>
                {
                    b.Navigation("Schools");

                    b.Navigation("Subjects");
                });
#pragma warning restore 612, 618
        }
    }
}
