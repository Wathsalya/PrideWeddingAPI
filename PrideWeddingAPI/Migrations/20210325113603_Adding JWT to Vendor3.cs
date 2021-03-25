using Microsoft.EntityFrameworkCore.Migrations;

namespace PrideWeddingAPI.Migrations
{
    public partial class AddingJWTtoVendor3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "9b5ad23b-b591-46ff-b29c-709d1ac1625d", "c16f5209-53f8-4a46-8b62-0bc6a7d2b688", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9195c546-ec82-4e32-81e9-f225e35d8eb9", "224bef62-79a5-454c-9055-3cd902b24212", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "9195c546-ec82-4e32-81e9-f225e35d8eb9");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "9b5ad23b-b591-46ff-b29c-709d1ac1625d");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d26234b9-8161-4fde-8376-a49fe1b238e1", "47e54426-1f62-4b0c-9a43-9bcab55a2545", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e21afc75-1559-4d77-b194-1c64c36cd4e0", "5b18dba7-cbc5-4a93-91d6-f105a9ad5db6", "Administrator", "ADMINISTRATOR" });
        }
    }
}
