﻿// <auto-generated />
using System;
using CarDealer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarDealer.Migrations
{
    [DbContext(typeof(CarDealerContext))]
    partial class CarDealerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CarDealer.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Make");

                    b.Property<string>("Model");

                    b.Property<long>("TravelledDistance");

                    b.HasKey("Id");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("CarDealer.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate");

                    b.Property<bool>("IsYoungDriver");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("CarDealer.Models.Part", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<int>("Quantity");

                    b.Property<int>("SupplierId");

                    b.HasKey("Id");

                    b.HasIndex("SupplierId");

                    b.ToTable("Parts");
                });

            modelBuilder.Entity("CarDealer.Models.PartCar", b =>
                {
                    b.Property<int>("CarId");

                    b.Property<int>("PartId");

                    b.HasKey("CarId", "PartId");

                    b.HasIndex("PartId");

                    b.ToTable("PartCars");
                });

            modelBuilder.Entity("CarDealer.Models.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarId");

                    b.Property<int>("CustomerId");

                    b.Property<decimal>("Discount");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("CarDealer.Models.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsImporter");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("CarDealer.Models.Part", b =>
                {
                    b.HasOne("CarDealer.Models.Supplier", "Supplier")
                        .WithMany("Parts")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CarDealer.Models.PartCar", b =>
                {
                    b.HasOne("CarDealer.Models.Car", "Car")
                        .WithMany("PartCars")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CarDealer.Models.Part", "Part")
                        .WithMany("PartCars")
                        .HasForeignKey("PartId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CarDealer.Models.Sale", b =>
                {
                    b.HasOne("CarDealer.Models.Car", "Car")
                        .WithMany("Sales")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CarDealer.Models.Customer", "Customer")
                        .WithMany("Sales")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
