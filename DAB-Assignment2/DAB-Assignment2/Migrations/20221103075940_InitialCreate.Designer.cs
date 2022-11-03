﻿// <auto-generated />
using DAB_Assignment2;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAB_Assignment2.Migrations
{
    [DbContext(typeof(FacilitysContext))]
    [Migration("20221103075940_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("DAB_Assignment2.Facilitys", b =>
                {
                    b.Property<string>("FcName")
                        .HasColumnType("TEXT");

                    b.Property<string>("CanBeBookedBy")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ClosetAdress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FacilityDecrtiption")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FcType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("FcName");

                    b.ToTable("Facilitys");
                });

            modelBuilder.Entity("DAB_Assignment2.User", b =>
                {
                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.Property<string>("CVR")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserName");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}