using Microsoft.EntityFrameworkCore.Migrations;

namespace PrideWeddingAPI.Migrations
{
    public partial class renameclasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Saloons",
                table: "Saloons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Photographers",
                table: "Photographers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Jwellers",
                table: "Jwellers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hotels",
                table: "Hotels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Entertainers",
                table: "Entertainers");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "98832d24-3582-47e2-9a73-2b1cc72191c5");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c34a00c9-3aa9-436f-ab89-6b1b36e7f98a");

            migrationBuilder.DropColumn(
                name: "EmployeeID",
                table: "Saloons");

            migrationBuilder.DropColumn(
                name: "EmployeeID",
                table: "Photographers");

            migrationBuilder.DropColumn(
                name: "EmployeeID",
                table: "Jwellers");

            migrationBuilder.DropColumn(
                name: "EmployeeID",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "EmployeeID",
                table: "Entertainers");

            migrationBuilder.RenameColumn(
                name: "Occupation",
                table: "Saloons",
                newName: "LocatedProvince");

            migrationBuilder.RenameColumn(
                name: "Located_province",
                table: "Saloons",
                newName: "LocatedDistrict");

            migrationBuilder.RenameColumn(
                name: "Located_distric",
                table: "Saloons",
                newName: "CompanyName");

            migrationBuilder.RenameColumn(
                name: "EmployeeName",
                table: "Saloons",
                newName: "CompanyCategory");

            migrationBuilder.RenameColumn(
                name: "Occupation",
                table: "Photographers",
                newName: "LocatedProvince");

            migrationBuilder.RenameColumn(
                name: "Located_province",
                table: "Photographers",
                newName: "LocatedDistrict");

            migrationBuilder.RenameColumn(
                name: "Located_distric",
                table: "Photographers",
                newName: "CompanyName");

            migrationBuilder.RenameColumn(
                name: "EmployeeName",
                table: "Photographers",
                newName: "CompanyCategory");

            migrationBuilder.RenameColumn(
                name: "Occupation",
                table: "Jwellers",
                newName: "LocatedProvince");

            migrationBuilder.RenameColumn(
                name: "Located_province",
                table: "Jwellers",
                newName: "LocatedDistrict");

            migrationBuilder.RenameColumn(
                name: "Located_distric",
                table: "Jwellers",
                newName: "CompanyName");

            migrationBuilder.RenameColumn(
                name: "EmployeeName",
                table: "Jwellers",
                newName: "CompanyCategory");

            migrationBuilder.RenameColumn(
                name: "Occupation",
                table: "Hotels",
                newName: "LocatedProvince");

            migrationBuilder.RenameColumn(
                name: "Located_province",
                table: "Hotels",
                newName: "LocatedDistrict");

            migrationBuilder.RenameColumn(
                name: "Located_distric",
                table: "Hotels",
                newName: "CompanyName");

            migrationBuilder.RenameColumn(
                name: "EmployeeName",
                table: "Hotels",
                newName: "CompanyCategory");

            migrationBuilder.RenameColumn(
                name: "Occupation",
                table: "Entertainers",
                newName: "LocatedProvince");

            migrationBuilder.RenameColumn(
                name: "Located_province",
                table: "Entertainers",
                newName: "LocatedDistrict");

            migrationBuilder.RenameColumn(
                name: "Located_distric",
                table: "Entertainers",
                newName: "CompanyName");

            migrationBuilder.RenameColumn(
                name: "EmployeeName",
                table: "Entertainers",
                newName: "CompanyCategory");

            migrationBuilder.AddColumn<int>(
                name: "CompanyID",
                table: "Saloons",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CompanyID",
                table: "Photographers",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CompanyID",
                table: "Jwellers",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CompanyID",
                table: "Hotels",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CompanyID",
                table: "Entertainers",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Saloons",
                table: "Saloons",
                column: "CompanyID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Photographers",
                table: "Photographers",
                column: "CompanyID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Jwellers",
                table: "Jwellers",
                column: "CompanyID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hotels",
                table: "Hotels",
                column: "CompanyID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Entertainers",
                table: "Entertainers",
                column: "CompanyID");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5dca5dad-3c9b-4cc6-bfd8-8fba0248d59b", "7c8f5492-a4c9-42a6-9053-e323ff288878", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "10627f2a-bb39-4314-9f96-c1b00de7c7a1", "2aabf904-ec99-43a5-93db-f0414a7266c2", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Saloons",
                table: "Saloons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Photographers",
                table: "Photographers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Jwellers",
                table: "Jwellers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hotels",
                table: "Hotels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Entertainers",
                table: "Entertainers");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "10627f2a-bb39-4314-9f96-c1b00de7c7a1");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "5dca5dad-3c9b-4cc6-bfd8-8fba0248d59b");

            migrationBuilder.DropColumn(
                name: "CompanyID",
                table: "Saloons");

            migrationBuilder.DropColumn(
                name: "CompanyID",
                table: "Photographers");

            migrationBuilder.DropColumn(
                name: "CompanyID",
                table: "Jwellers");

            migrationBuilder.DropColumn(
                name: "CompanyID",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "CompanyID",
                table: "Entertainers");

            migrationBuilder.RenameColumn(
                name: "LocatedProvince",
                table: "Saloons",
                newName: "Occupation");

            migrationBuilder.RenameColumn(
                name: "LocatedDistrict",
                table: "Saloons",
                newName: "Located_province");

            migrationBuilder.RenameColumn(
                name: "CompanyName",
                table: "Saloons",
                newName: "Located_distric");

            migrationBuilder.RenameColumn(
                name: "CompanyCategory",
                table: "Saloons",
                newName: "EmployeeName");

            migrationBuilder.RenameColumn(
                name: "LocatedProvince",
                table: "Photographers",
                newName: "Occupation");

            migrationBuilder.RenameColumn(
                name: "LocatedDistrict",
                table: "Photographers",
                newName: "Located_province");

            migrationBuilder.RenameColumn(
                name: "CompanyName",
                table: "Photographers",
                newName: "Located_distric");

            migrationBuilder.RenameColumn(
                name: "CompanyCategory",
                table: "Photographers",
                newName: "EmployeeName");

            migrationBuilder.RenameColumn(
                name: "LocatedProvince",
                table: "Jwellers",
                newName: "Occupation");

            migrationBuilder.RenameColumn(
                name: "LocatedDistrict",
                table: "Jwellers",
                newName: "Located_province");

            migrationBuilder.RenameColumn(
                name: "CompanyName",
                table: "Jwellers",
                newName: "Located_distric");

            migrationBuilder.RenameColumn(
                name: "CompanyCategory",
                table: "Jwellers",
                newName: "EmployeeName");

            migrationBuilder.RenameColumn(
                name: "LocatedProvince",
                table: "Hotels",
                newName: "Occupation");

            migrationBuilder.RenameColumn(
                name: "LocatedDistrict",
                table: "Hotels",
                newName: "Located_province");

            migrationBuilder.RenameColumn(
                name: "CompanyName",
                table: "Hotels",
                newName: "Located_distric");

            migrationBuilder.RenameColumn(
                name: "CompanyCategory",
                table: "Hotels",
                newName: "EmployeeName");

            migrationBuilder.RenameColumn(
                name: "LocatedProvince",
                table: "Entertainers",
                newName: "Occupation");

            migrationBuilder.RenameColumn(
                name: "LocatedDistrict",
                table: "Entertainers",
                newName: "Located_province");

            migrationBuilder.RenameColumn(
                name: "CompanyName",
                table: "Entertainers",
                newName: "Located_distric");

            migrationBuilder.RenameColumn(
                name: "CompanyCategory",
                table: "Entertainers",
                newName: "EmployeeName");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeID",
                table: "Saloons",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeID",
                table: "Photographers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeID",
                table: "Jwellers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeID",
                table: "Hotels",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeID",
                table: "Entertainers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Saloons",
                table: "Saloons",
                column: "EmployeeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Photographers",
                table: "Photographers",
                column: "EmployeeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Jwellers",
                table: "Jwellers",
                column: "EmployeeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hotels",
                table: "Hotels",
                column: "EmployeeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Entertainers",
                table: "Entertainers",
                column: "EmployeeID");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "98832d24-3582-47e2-9a73-2b1cc72191c5", "89f2d28b-f621-48b8-87ab-69ca673cc71c", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c34a00c9-3aa9-436f-ab89-6b1b36e7f98a", "9e54734f-275f-476f-8e58-dfa936c01961", "Administrator", "ADMINISTRATOR" });
        }
    }
}
