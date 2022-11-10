﻿// <auto-generated />
using System;
using DAB_Assignment2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAB_Assignment2.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DAB_Assignment2.Model.Bookings", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingId"), 1L, 1);

                    b.Property<DateTime>("BookedFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("BookedTo")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CityHallPersonelEmpId")
                        .HasColumnType("int");

                    b.Property<int>("FacilitysFcId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("BookingId");

                    b.HasIndex("CityHallPersonelEmpId");

                    b.HasIndex("FacilitysFcId");

                    b.HasIndex("UserName");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("DAB_Assignment2.Model.CityHallPersonel", b =>
                {
                    b.Property<int>("EmpId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmpId"), 1L, 1);

                    b.Property<int>("BookingId")
                        .HasColumnType("int");

                    b.Property<string>("EmpName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmpId");

                    b.ToTable("cityHallPersonels");
                });

            modelBuilder.Entity("DAB_Assignment2.Model.Facilitys", b =>
                {
                    b.Property<int>("FcId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FcId"), 1L, 1);

                    b.Property<string>("CanBeBookedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClosetAdress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FacilityDecrtiption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FcItems")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FcName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FcRule")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FcType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FcId");

                    b.ToTable("Facilitys");
                });

            modelBuilder.Entity("DAB_Assignment2.Model.User", b =>
                {
                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserName");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DAB_Assignment2.Model.Bookings", b =>
                {
                    b.HasOne("DAB_Assignment2.Model.CityHallPersonel", null)
                        .WithMany("bookings")
                        .HasForeignKey("CityHallPersonelEmpId");

                    b.HasOne("DAB_Assignment2.Model.Facilitys", "Facilitys")
                        .WithMany("Bookings")
                        .HasForeignKey("FacilitysFcId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAB_Assignment2.Model.User", "User")
                        .WithMany("Bookings")
                        .HasForeignKey("UserName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Facilitys");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DAB_Assignment2.Model.CityHallPersonel", b =>
                {
                    b.Navigation("bookings");
                });

            modelBuilder.Entity("DAB_Assignment2.Model.Facilitys", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("DAB_Assignment2.Model.User", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}
