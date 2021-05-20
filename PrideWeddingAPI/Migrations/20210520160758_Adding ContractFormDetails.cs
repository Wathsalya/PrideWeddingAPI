using Microsoft.EntityFrameworkCore.Migrations;

namespace PrideWeddingAPI.Migrations
{
    public partial class AddingContractFormDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "a247516f-90b2-4368-8a89-7503a56bee14");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "db78e288-b4a6-4dde-984f-ce7bc29e0605");

            migrationBuilder.CreateTable(
                name: "ContactUS",
                columns: table => new
                {
                    Email = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUS", x => x.Email);
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f0877d5b-4cf8-4225-9358-9b64b08deb08", "19ae07ce-b5a9-43e3-b2cf-d7ee9ee86f46", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9e2e6a92-fde3-4349-a786-ce6796d9765e", "f452e3c0-e609-469e-8190-29467ad4719c", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactUS");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "9e2e6a92-fde3-4349-a786-ce6796d9765e");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f0877d5b-4cf8-4225-9358-9b64b08deb08");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "db78e288-b4a6-4dde-984f-ce7bc29e0605", "67276abd-facc-447f-84fa-8a60f0404058", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a247516f-90b2-4368-8a89-7503a56bee14", "e198ca51-4c88-403c-8799-c5ef2303a45f", "Administrator", "ADMINISTRATOR" });
        }
    }
}
