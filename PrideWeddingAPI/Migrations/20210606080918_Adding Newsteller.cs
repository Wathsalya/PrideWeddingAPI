using Microsoft.EntityFrameworkCore.Migrations;

namespace PrideWeddingAPI.Migrations
{
    public partial class AddingNewsteller : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "0bd4d27c-3cd4-4b23-8585-a6c8908eb3be");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "e42805a3-b40c-4723-9c2f-8833264b7131");

            migrationBuilder.CreateTable(
                name: "NewstellerSubscribers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewstellerSubscribers", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5eb97031-657c-4571-a1b9-c68c17e90064", "226397fe-0dec-43ed-882b-db053ef3411c", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f62b196a-63f2-4450-b592-5f4f04b11b14", "2b162bd1-273c-4098-be1f-7044a40c7159", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NewstellerSubscribers");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "5eb97031-657c-4571-a1b9-c68c17e90064");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f62b196a-63f2-4450-b592-5f4f04b11b14");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e42805a3-b40c-4723-9c2f-8833264b7131", "5e0850c3-0525-48dd-ba1f-f00a9e980a29", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0bd4d27c-3cd4-4b23-8585-a6c8908eb3be", "16707a45-f0ff-46a5-abc9-a298907cd69c", "Administrator", "ADMINISTRATOR" });
        }
    }
}
