﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PrideWeddingAPI.Data;

namespace PrideWeddingAPI.Migrations
{
    [DbContext(typeof(WeddingDBContext))]
    [Migration("20210605094742_modify addingcart")]
    partial class modifyaddingcart
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("IdentityRole");

                    b.HasData(
                        new
                        {
                            Id = "e42805a3-b40c-4723-9c2f-8833264b7131",
                            ConcurrencyStamp = "5e0850c3-0525-48dd-ba1f-f00a9e980a29",
                            Name = "Visitor",
                            NormalizedName = "VISITOR"
                        },
                        new
                        {
                            Id = "0bd4d27c-3cd4-4b23-8585-a6c8908eb3be",
                            ConcurrencyStamp = "16707a45-f0ff-46a5-abc9-a298907cd69c",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("IdentityUserRole<string>");
                });

            modelBuilder.Entity("PrideWeddingAPI.Models.AddingCart", b =>
                {
                    b.Property<int>("CompanyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyCategory")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CompanyWebsite")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Discount_package")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LocatedDistrict")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LocatedProvince")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TelephoneNumber")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CompanyID");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("PrideWeddingAPI.Models.Client", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientNIC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("MobileNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("PrideWeddingAPI.Models.ContactFormDetails", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("ContactUS");
                });

            modelBuilder.Entity("PrideWeddingAPI.Models.DecorationVendor", b =>
                {
                    b.Property<int>("CompanyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyCategory")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CompanyWebsite")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LocatedDistrict")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LocatedProvince")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Max_package")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Min_package")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TelephoneNumber")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CompanyID");

                    b.ToTable("Decorators");
                });

            modelBuilder.Entity("PrideWeddingAPI.Models.EntertainmentVendor", b =>
                {
                    b.Property<int>("CompanyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyCategory")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CompanyWebsite")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LocatedDistrict")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LocatedProvince")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Max_package")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Min_package")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TelephoneNumber")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CompanyID");

                    b.ToTable("Entertainers");
                });

            modelBuilder.Entity("PrideWeddingAPI.Models.HotelVendor", b =>
                {
                    b.Property<int>("CompanyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyCategory")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CompanyWebsite")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LocatedDistrict")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LocatedProvince")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Max_package")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Min_package")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TelephoneNumber")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CompanyID");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("PrideWeddingAPI.Models.JwelVendor", b =>
                {
                    b.Property<int>("CompanyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyCategory")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CompanyWebsite")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LocatedDistrict")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LocatedProvince")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Max_package")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Min_package")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TelephoneNumber")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CompanyID");

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
                    b.Property<int>("CompanyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyCategory")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CompanyWebsite")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LocatedDistrict")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LocatedProvince")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Max_package")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Min_package")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TelephoneNumber")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CompanyID");

                    b.ToTable("Photographers");
                });

            modelBuilder.Entity("PrideWeddingAPI.Models.SaloonVendor", b =>
                {
                    b.Property<int>("CompanyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyCategory")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CompanyWebsite")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LocatedDistrict")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LocatedProvince")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Max_package")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Min_package")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TelephoneNumber")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CompanyID");

                    b.ToTable("Saloons");
                });

            modelBuilder.Entity("PrideWeddingAPI.Models.Vendor", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelephoneNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vendors");
                });
#pragma warning restore 612, 618
        }
    }
}
