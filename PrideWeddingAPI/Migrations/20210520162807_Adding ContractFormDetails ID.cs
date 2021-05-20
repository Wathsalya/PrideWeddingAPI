using Microsoft.EntityFrameworkCore.Migrations;

namespace PrideWeddingAPI.Migrations
{
    public partial class AddingContractFormDetailsID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactUS",
                table: "ContactUS");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "9e2e6a92-fde3-4349-a786-ce6796d9765e");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f0877d5b-4cf8-4225-9358-9b64b08deb08");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "ContactUS",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "ContactUS",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactUS",
                table: "ContactUS",
                column: "ID");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8c163dd1-ae9d-4c6a-bdab-4b9c255c1d21", "75d02a77-9f28-4634-a154-1a6445507628", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "95165abe-a76c-4e47-b0bf-57370a836fd2", "298434c1-6345-4c95-ba3d-ff13494145a6", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactUS",
                table: "ContactUS");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "8c163dd1-ae9d-4c6a-bdab-4b9c255c1d21");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "95165abe-a76c-4e47-b0bf-57370a836fd2");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "ContactUS");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "ContactUS",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactUS",
                table: "ContactUS",
                column: "Email");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f0877d5b-4cf8-4225-9358-9b64b08deb08", "19ae07ce-b5a9-43e3-b2cf-d7ee9ee86f46", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9e2e6a92-fde3-4349-a786-ce6796d9765e", "f452e3c0-e609-469e-8190-29467ad4719c", "Administrator", "ADMINISTRATOR" });
        }
    }
}
