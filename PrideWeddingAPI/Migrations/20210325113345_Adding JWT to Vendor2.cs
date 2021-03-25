using Microsoft.EntityFrameworkCore.Migrations;

namespace PrideWeddingAPI.Migrations
{
    public partial class AddingJWTtoVendor2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "42af3ab9-b0d1-483c-9602-4c2759c52243");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "4c4fc096-3fec-43dd-8814-178c096f83b4");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d26234b9-8161-4fde-8376-a49fe1b238e1", "47e54426-1f62-4b0c-9a43-9bcab55a2545", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e21afc75-1559-4d77-b194-1c64c36cd4e0", "5b18dba7-cbc5-4a93-91d6-f105a9ad5db6", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d26234b9-8161-4fde-8376-a49fe1b238e1");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "e21afc75-1559-4d77-b194-1c64c36cd4e0");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "42af3ab9-b0d1-483c-9602-4c2759c52243", "f5418d4e-c2fb-4ffd-b976-e7320c42cfa5", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4c4fc096-3fec-43dd-8814-178c096f83b4", "97de82c5-ed7d-4893-9cd5-bb047c602796", "Administrator", "ADMINISTRATOR" });
        }
    }
}
