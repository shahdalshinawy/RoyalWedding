﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WeddingPlanner;

#nullable disable

namespace WeddingPlanner.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WeddingPlanner.B_Dishes", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("BookingDataID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("BookingDataID");

                    b.ToTable("Dishes");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Meat",
                            Price = 90,
                            Quantity = 0
                        },
                        new
                        {
                            ID = 2,
                            Name = "Fish",
                            Price = 100,
                            Quantity = 0
                        },
                        new
                        {
                            ID = 3,
                            Name = "Chicken",
                            Price = 80,
                            Quantity = 0
                        });
                });

            modelBuilder.Entity("WeddingPlanner.B_Drinks", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("BookingDataID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("BookingDataID");

                    b.ToTable("Drinks");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Soda",
                            Price = 20,
                            Quantity = 0
                        },
                        new
                        {
                            ID = 2,
                            Name = "Water",
                            Price = 10,
                            Quantity = 0
                        },
                        new
                        {
                            ID = 3,
                            Name = "Juice",
                            Price = 15,
                            Quantity = 0
                        });
                });

            modelBuilder.Entity("WeddingPlanner.BookingData", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("B_Advance")
                        .HasColumnType("int");

                    b.Property<int>("B_Balance")
                        .HasColumnType("int");

                    b.Property<DateTime>("B_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("B_GrdTotal")
                        .HasColumnType("int");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<int>("HallId")
                        .HasColumnType("int");

                    b.Property<double>("Profit")
                        .HasColumnType("float");

                    b.Property<int?>("StaffBookingID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("HallId");

                    b.HasIndex("StaffBookingID");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("WeddingPlanner.CustomerData", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Customer_Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customer_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customer_Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Customer_Address = "Egypt-Cairo-Giza",
                            Customer_Name = "Fareed",
                            Customer_Phone = "01234567896"
                        },
                        new
                        {
                            ID = 2,
                            Customer_Address = "Egypt-Cairo-Giza",
                            Customer_Name = "Fareed",
                            Customer_Phone = "01234567896"
                        });
                });

            modelBuilder.Entity("WeddingPlanner.Hall", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumOfPeople")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Halls");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Royal I",
                            NumOfPeople = 100,
                            Price = 19000
                        },
                        new
                        {
                            Id = 2,
                            Name = "Royal II",
                            NumOfPeople = 150,
                            Price = 25000
                        },
                        new
                        {
                            Id = 3,
                            Name = "Royal III",
                            NumOfPeople = 200,
                            Price = 40000
                        },
                        new
                        {
                            Id = 4,
                            Name = "Royal IV",
                            NumOfPeople = 300,
                            Price = 50000
                        });
                });

            modelBuilder.Entity("WeddingPlanner.StaffData", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<bool>("IsManager")
                        .HasColumnType("bit");

                    b.Property<string>("S_Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("S_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("S_Passward")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("S_Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Staffs");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            IsManager = true,
                            S_Gender = "Female",
                            S_Name = "Nour",
                            S_Passward = "1234567",
                            S_Phone = "01234567891"
                        },
                        new
                        {
                            ID = 2,
                            IsManager = true,
                            S_Gender = "Female",
                            S_Name = "Nada",
                            S_Passward = "1234567",
                            S_Phone = "01019658193"
                        });
                });

            modelBuilder.Entity("WeddingPlanner.B_Dishes", b =>
                {
                    b.HasOne("WeddingPlanner.BookingData", null)
                        .WithMany("Dishes")
                        .HasForeignKey("BookingDataID");
                });

            modelBuilder.Entity("WeddingPlanner.B_Drinks", b =>
                {
                    b.HasOne("WeddingPlanner.BookingData", null)
                        .WithMany("Drinks")
                        .HasForeignKey("BookingDataID");
                });

            modelBuilder.Entity("WeddingPlanner.BookingData", b =>
                {
                    b.HasOne("WeddingPlanner.CustomerData", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WeddingPlanner.Hall", "Hall")
                        .WithMany()
                        .HasForeignKey("HallId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WeddingPlanner.StaffData", "StaffBooking")
                        .WithMany()
                        .HasForeignKey("StaffBookingID");

                    b.Navigation("Customer");

                    b.Navigation("Hall");

                    b.Navigation("StaffBooking");
                });

            modelBuilder.Entity("WeddingPlanner.BookingData", b =>
                {
                    b.Navigation("Dishes");

                    b.Navigation("Drinks");
                });
#pragma warning restore 612, 618
        }
    }
}