using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PrideWeddingAPI.Migrations
{
    public partial class CreatingProject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    CompanyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    CompanyCategory = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    LocatedDistrict = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    LocatedProvince = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Discount_package = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    TelephoneNumber = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    CompanyWebsite = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.CompanyID);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientNIC = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    MobileNo = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ContactUS",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Decorators",
                columns: table => new
                {
                    CompanyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    CompanyCategory = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    LocatedDistrict = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    LocatedProvince = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Min_package = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Max_package = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    TelephoneNumber = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    CompanyWebsite = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Decorators", x => x.CompanyID);
                });

            migrationBuilder.CreateTable(
                name: "Entertainers",
                columns: table => new
                {
                    CompanyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    CompanyCategory = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    LocatedDistrict = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    LocatedProvince = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Min_package = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Max_package = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    TelephoneNumber = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    CompanyWebsite = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entertainers", x => x.CompanyID);
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    CompanyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    CompanyCategory = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    LocatedDistrict = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    LocatedProvince = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Min_package = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Max_package = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    TelephoneNumber = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    CompanyWebsite = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.CompanyID);
                });

            migrationBuilder.CreateTable(
                name: "IdentityRole",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NormalizedName = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IdentityUserRole<string>",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserRole<string>", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "Jwellers",
                columns: table => new
                {
                    CompanyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    CompanyCategory = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    LocatedDistrict = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    LocatedProvince = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Min_package = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Max_package = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    TelephoneNumber = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    CompanyWebsite = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jwellers", x => x.CompanyID);
                });

            migrationBuilder.CreateTable(
                name: "NewstellerSubscribers",
                columns: table => new
                {
                    SubscriberID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewstellerSubscribers", x => x.SubscriberID);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardNo = table.Column<string>(nullable: true),
                    CardholderName = table.Column<string>(nullable: true),
                    ExpDate = table.Column<string>(nullable: true),
                    CVV = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Photographers",
                columns: table => new
                {
                    CompanyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    CompanyCategory = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    LocatedDistrict = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    LocatedProvince = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Min_package = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Max_package = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    TelephoneNumber = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    CompanyWebsite = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photographers", x => x.CompanyID);
                });

            migrationBuilder.CreateTable(
                name: "Saloons",
                columns: table => new
                {
                    CompanyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    CompanyCategory = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    LocatedDistrict = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    LocatedProvince = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Min_package = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Max_package = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    TelephoneNumber = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    CompanyWebsite = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saloons", x => x.CompanyID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    ClientNIC = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    CompanyCategory = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vendors",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(nullable: true),
                    TelephoneNo = table.Column<string>(nullable: true),
                    CompanyCategory = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendors", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "eeab730d-9f7c-4a33-97fe-d65a762355d8", "65a1e546-9946-40ec-983c-22b00cebe749", "Client", "CLIENT" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5e5d4c0d-e193-4e32-a212-d8743ab4613c", "5e236467-3565-4811-904f-3a810a24d7e0", "Vendor", "VENDOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cdfef57b-e170-42b5-a99a-635b6c5768c5", "bbe51b61-d829-4683-97fb-c266555c9872", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "ContactUS");

            migrationBuilder.DropTable(
                name: "Decorators");

            migrationBuilder.DropTable(
                name: "Entertainers");

            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.DropTable(
                name: "IdentityRole");

            migrationBuilder.DropTable(
                name: "IdentityUserRole<string>");

            migrationBuilder.DropTable(
                name: "Jwellers");

            migrationBuilder.DropTable(
                name: "NewstellerSubscribers");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Photographers");

            migrationBuilder.DropTable(
                name: "Saloons");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Vendors");
        }
    }
}
