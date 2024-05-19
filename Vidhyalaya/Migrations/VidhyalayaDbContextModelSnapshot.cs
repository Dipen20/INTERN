﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Vidhyala.Migrations
{
    [DbContext(typeof(VidhyalayaDbContext))]
    partial class VidhyalayaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("Grade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClassTeacher")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Label")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Medium")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Session")
                        .HasColumnType("TEXT");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("Guardian", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("StudentId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.ToTable("Guardians");
                });

            modelBuilder.Entity("Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("GradeId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Photo")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("GradeId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Guardian", b =>
                {
                    b.HasOne("Student", "Student")
                        .WithOne("Guardian")
                        .HasForeignKey("Guardian", "StudentId");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Student", b =>
                {
                    b.HasOne("Grade", "Grade")
                        .WithMany()
                        .HasForeignKey("GradeId");

                    b.Navigation("Grade");
                });

            modelBuilder.Entity("Student", b =>
                {
                    b.Navigation("Guardian");
                });
#pragma warning restore 612, 618
        }
    }
}