﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PrideWeddingAPI.Data;
using PrideWeddingAPI.Models;

namespace PrideWeddingAPI.Migrations
{
    [DbContext(typeof(WeddingDBContext))]
    [Migration("20210325090807_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PrideWeddingAPI.Models.DecorationVendor", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyWebsite")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("EmployeeName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Located_distric")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Located_province")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Max_package")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Min_package")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Occupation")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TelephoneNumber")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("EmployeeID");

                    b.ToTable("Decorators");
                });

            modelBuilder.Entity("PrideWeddingAPI.Models.EntertainmentVendor", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyWebsite")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("EmployeeName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Located_distric")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Located_province")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Max_package")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Min_package")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Occupation")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TelephoneNumber")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("EmployeeID");

                    b.ToTable("Entertainers");
                });

            modelBuilder.Entity("PrideWeddingAPI.Models.HotelVendor", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyWebsite")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("EmployeeName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Located_distric")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Located_province")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Max_package")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Min_package")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Occupation")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TelephoneNumber")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("EmployeeID");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("PrideWeddingAPI.Models.JwelVendor", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyWebsite")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("EmployeeName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Located_distric")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Located_province")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Max_package")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Min_package")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Occupation")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TelephoneNumber")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("EmployeeID");

                    b.ToTable("Jwellers");
                });

            modelBuilder.Entity("PrideWeddingAPI.Models.Payment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CVV")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardholderName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpDate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("PrideWeddingAPI.Models.PhotographyVendor", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyWebsite")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("EmployeeName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Located_distric")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Located_province")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Max_package")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Min_package")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Occupation")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TelephoneNumber")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("EmployeeID");

                    b.ToTable("Photographers");
                });

            modelBuilder.Entity("PrideWeddingAPI.Models.SaloonVendor", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyWebsite")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("EmployeeName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Located_distric")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Located_province")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Max_package")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Min_package")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Occupation")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TelephoneNumber")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("EmployeeID");

                    b.ToTable("Saloons");
                });
#pragma warning restore 612, 618
        }
    }
}