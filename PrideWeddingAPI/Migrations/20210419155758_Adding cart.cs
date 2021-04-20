using Microsoft.EntityFrameworkCore.Migrations;

namespace PrideWeddingAPI.Migrations
{
    public partial class Addingcart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "10627f2a-bb39-4314-9f96-c1b00de7c7a1");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "5dca5dad-3c9b-4cc6-bfd8-8fba0248d59b");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fc4790ab-8d3c-421e-b601-cd2fb4b2ec7a", "aa5056d9-03b3-490b-aff3-285442ac2d80", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1ab66a65-4d48-43fa-97b0-c52b3181b939", "55dfe398-6ab2-4a53-8ea2-df10de8256e4", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1ab66a65-4d48-43fa-97b0-c52b3181b939");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "fc4790ab-8d3c-421e-b601-cd2fb4b2ec7a");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5dca5dad-3c9b-4cc6-bfd8-8fba0248d59b", "7c8f5492-a4c9-42a6-9053-e323ff288878", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "10627f2a-bb39-4314-9f96-c1b00de7c7a1", "2aabf904-ec99-43a5-93db-f0414a7266c2", "Administrator", "ADMINISTRATOR" });
        }
    }
}
