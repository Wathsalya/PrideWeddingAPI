using Microsoft.EntityFrameworkCore.Migrations;

namespace PrideWeddingAPI.Migrations
{
    public partial class renamedecVendorclass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Decorators",
                table: "Decorators");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "9195c546-ec82-4e32-81e9-f225e35d8eb9");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "9b5ad23b-b591-46ff-b29c-709d1ac1625d");

            migrationBuilder.DropColumn(
                name: "EmployeeID",
                table: "Decorators");

            migrationBuilder.RenameColumn(
                name: "Occupation",
                table: "Decorators",
                newName: "LocatedProvince");

            migrationBuilder.RenameColumn(
                name: "Located_province",
                table: "Decorators",
                newName: "LocatedDistrict");

            migrationBuilder.RenameColumn(
                name: "Located_distric",
                table: "Decorators",
                newName: "CompanyName");

            migrationBuilder.RenameColumn(
                name: "EmployeeName",
                table: "Decorators",
                newName: "CompanyCategory");

            migrationBuilder.AddColumn<int>(
                name: "CompanyID",
                table: "Decorators",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Decorators",
                table: "Decorators",
                column: "CompanyID");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "98832d24-3582-47e2-9a73-2b1cc72191c5", "89f2d28b-f621-48b8-87ab-69ca673cc71c", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c34a00c9-3aa9-436f-ab89-6b1b36e7f98a", "9e54734f-275f-476f-8e58-dfa936c01961", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Decorators",
                table: "Decorators");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "98832d24-3582-47e2-9a73-2b1cc72191c5");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c34a00c9-3aa9-436f-ab89-6b1b36e7f98a");

            migrationBuilder.DropColumn(
                name: "CompanyID",
                table: "Decorators");

            migrationBuilder.RenameColumn(
                name: "LocatedProvince",
                table: "Decorators",
                newName: "Occupation");

            migrationBuilder.RenameColumn(
                name: "LocatedDistrict",
                table: "Decorators",
                newName: "Located_province");

            migrationBuilder.RenameColumn(
                name: "CompanyName",
                table: "Decorators",
                newName: "Located_distric");

            migrationBuilder.RenameColumn(
                name: "CompanyCategory",
                table: "Decorators",
                newName: "EmployeeName");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeID",
                table: "Decorators",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Decorators",
                table: "Decorators",
                column: "EmployeeID");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9b5ad23b-b591-46ff-b29c-709d1ac1625d", "c16f5209-53f8-4a46-8b62-0bc6a7d2b688", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9195c546-ec82-4e32-81e9-f225e35d8eb9", "224bef62-79a5-454c-9055-3cd902b24212", "Administrator", "ADMINISTRATOR" });
        }
    }
}
