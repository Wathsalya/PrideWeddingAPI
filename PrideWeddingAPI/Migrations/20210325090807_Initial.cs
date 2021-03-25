using Microsoft.EntityFrameworkCore.Migrations;

namespace PrideWeddingAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Decorators",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Occupation = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Located_distric = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Located_province = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Min_package = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Max_package = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    TelephoneNumber = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    CompanyWebsite = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Decorators", x => x.EmployeeID);
                });

            migrationBuilder.CreateTable(
                name: "Entertainers",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Occupation = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Located_distric = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Located_province = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Min_package = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Max_package = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    TelephoneNumber = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    CompanyWebsite = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entertainers", x => x.EmployeeID);
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Occupation = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Located_distric = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Located_province = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Min_package = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Max_package = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    TelephoneNumber = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    CompanyWebsite = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.EmployeeID);
                });

            migrationBuilder.CreateTable(
                name: "Jwellers",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Occupation = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Located_distric = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Located_province = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Min_package = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Max_package = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    TelephoneNumber = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    CompanyWebsite = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jwellers", x => x.EmployeeID);
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
                    EmployeeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Occupation = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Located_distric = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Located_province = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Min_package = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Max_package = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    TelephoneNumber = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    CompanyWebsite = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photographers", x => x.EmployeeID);
                });

            migrationBuilder.CreateTable(
                name: "Saloons",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Occupation = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Located_distric = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Located_province = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Min_package = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Max_package = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    TelephoneNumber = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    CompanyWebsite = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saloons", x => x.EmployeeID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Decorators");

            migrationBuilder.DropTable(
                name: "Entertainers");

            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.DropTable(
                name: "Jwellers");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Photographers");

            migrationBuilder.DropTable(
                name: "Saloons");
        }
    }
}
