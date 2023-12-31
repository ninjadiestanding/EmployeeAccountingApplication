﻿// <auto-generated />
using System;
using EmployeeAccountingApplication.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeeAccountingApplication.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("EmployeeAccountingApplication.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("DirectorId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MainDepartmentId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("RecordStatus")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("DirectorId");

                    b.HasIndex("MainDepartmentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("EmployeeAccountingApplication.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DateOfDismissal")
                        .HasColumnType("DATETIME");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EmploymentDate")
                        .HasColumnType("DATETIME");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PersonnelNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("RecordStatus")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EmployeeAccountingApplication.Models.Department", b =>
                {
                    b.HasOne("EmployeeAccountingApplication.Models.Employee", "Director")
                        .WithMany()
                        .HasForeignKey("DirectorId");

                    b.HasOne("EmployeeAccountingApplication.Models.Department", "MainDepartment")
                        .WithMany()
                        .HasForeignKey("MainDepartmentId");

                    b.Navigation("Director");

                    b.Navigation("MainDepartment");
                });

            modelBuilder.Entity("EmployeeAccountingApplication.Models.Employee", b =>
                {
                    b.HasOne("EmployeeAccountingApplication.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId");

                    b.Navigation("Department");
                });
#pragma warning restore 612, 618
        }
    }
}
