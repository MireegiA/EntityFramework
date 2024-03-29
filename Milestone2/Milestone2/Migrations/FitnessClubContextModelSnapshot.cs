﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Milestone2.Data;

namespace Milestone2.Migrations
{
    [DbContext(typeof(FitnessClubContext))]
    partial class FitnessClubContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("Milestone2.Models.Coach", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Coaches");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Email = "tony@gmail.com",
                            Name = "Tony"
                        },
                        new
                        {
                            Id = 2L,
                            Email = "mike@gmail.com",
                            Name = "Mike"
                        });
                });

            modelBuilder.Entity("Milestone2.Models.Course", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("CoachId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(20);

                    b.Property<long>("RoomId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CoachId")
                        .IsUnique();

                    b.HasIndex("RoomId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CoachId = 2L,
                            Name = "Yoga",
                            RoomId = 2L
                        },
                        new
                        {
                            Id = 2L,
                            CoachId = 1L,
                            Name = "Upper Body Workout",
                            RoomId = 1L
                        });
                });

            modelBuilder.Entity("Milestone2.Models.CourseMember", b =>
                {
                    b.Property<long>("CourseId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("MemberId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Day")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CourseId", "MemberId");

                    b.HasIndex("MemberId");

                    b.ToTable("CourseMembers");

                    b.HasData(
                        new
                        {
                            CourseId = 2L,
                            MemberId = 1L,
                            Day = "Monday"
                        },
                        new
                        {
                            CourseId = 1L,
                            MemberId = 2L,
                            Day = "Tuesday"
                        });
                });

            modelBuilder.Entity("Milestone2.Models.Equipment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(20);

                    b.Property<int>("Price")
                        .HasColumnType("INTEGER");

                    b.Property<long>("RoomId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("Equipments");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Name = "Yoga ball",
                            Price = 2000,
                            RoomId = 2L
                        },
                        new
                        {
                            Id = 2L,
                            Name = "Dumbell",
                            Price = 5000,
                            RoomId = 1L
                        });
                });

            modelBuilder.Entity("Milestone2.Models.Member", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Members");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Email = "yedil@gmail.com",
                            Name = "Yedil"
                        },
                        new
                        {
                            Id = 2L,
                            Email = "lisa@gmail.com",
                            Name = "Lisa"
                        });
                });

            modelBuilder.Entity("Milestone2.Models.MembershipCard", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<long>("MemberId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("MemberId")
                        .IsUnique();

                    b.ToTable("MembershipCards");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2019, 11, 16, 1, 52, 10, 687, DateTimeKind.Local).AddTicks(5500),
                            MemberId = 1L
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(2019, 11, 16, 1, 52, 10, 698, DateTimeKind.Local).AddTicks(6240),
                            MemberId = 2L
                        });
                });

            modelBuilder.Entity("Milestone2.Models.Room", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Capcity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Capcity = 20
                        },
                        new
                        {
                            Id = 2L,
                            Capcity = 30
                        });
                });

            modelBuilder.Entity("Milestone2.Models.Course", b =>
                {
                    b.HasOne("Milestone2.Models.Coach", "Coach")
                        .WithOne("Course")
                        .HasForeignKey("Milestone2.Models.Course", "CoachId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Milestone2.Models.Room", "Room")
                        .WithMany("Courses")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Milestone2.Models.CourseMember", b =>
                {
                    b.HasOne("Milestone2.Models.Course", "Course")
                        .WithMany("CourseMembers")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Milestone2.Models.Member", "Member")
                        .WithMany("CourseMembers")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Milestone2.Models.Equipment", b =>
                {
                    b.HasOne("Milestone2.Models.Room", "Room")
                        .WithMany("Equipments")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Milestone2.Models.MembershipCard", b =>
                {
                    b.HasOne("Milestone2.Models.Member", "Member")
                        .WithOne("MembershipCard")
                        .HasForeignKey("Milestone2.Models.MembershipCard", "MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
