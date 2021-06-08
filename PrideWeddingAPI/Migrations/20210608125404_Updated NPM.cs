using Microsoft.EntityFrameworkCore.Migrations;

namespace PrideWeddingAPI.Migrations
{
    public partial class UpdatedNPM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "5e5d4c0d-e193-4e32-a212-d8743ab4613c");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "cdfef57b-e170-42b5-a99a-635b6c5768c5");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "eeab730d-9f7c-4a33-97fe-d65a762355d8");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8ef2ac3e-f30c-4f87-98ef-77523e66ab15", "53199dd0-b999-4902-97d0-88e2182768ef", "Client", "CLIENT" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "676947cc-db0f-42da-9d68-6417c6f1abde", "8a91feab-6f6b-4860-a335-f5cd103cb975", "Vendor", "VENDOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b6bc46b3-ea28-4a4a-a484-aca83ff3a1e7", "b032eb7c-6f42-4dde-83e1-7110a7e1daa0", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "676947cc-db0f-42da-9d68-6417c6f1abde");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "8ef2ac3e-f30c-4f87-98ef-77523e66ab15");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "b6bc46b3-ea28-4a4a-a484-aca83ff3a1e7");

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
    }
}
