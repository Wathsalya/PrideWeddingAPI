using Microsoft.EntityFrameworkCore.Migrations;

namespace PrideWeddingAPI.Migrations
{
    public partial class modifyaddingcart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "8c163dd1-ae9d-4c6a-bdab-4b9c255c1d21");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "95165abe-a76c-4e47-b0bf-57370a836fd2");

            migrationBuilder.DropColumn(
                name: "Max_package",
                table: "CartItems");

            migrationBuilder.RenameColumn(
                name: "Min_package",
                table: "CartItems",
                newName: "Discount_package");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e42805a3-b40c-4723-9c2f-8833264b7131", "5e0850c3-0525-48dd-ba1f-f00a9e980a29", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0bd4d27c-3cd4-4b23-8585-a6c8908eb3be", "16707a45-f0ff-46a5-abc9-a298907cd69c", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "0bd4d27c-3cd4-4b23-8585-a6c8908eb3be");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "e42805a3-b40c-4723-9c2f-8833264b7131");

            migrationBuilder.RenameColumn(
                name: "Discount_package",
                table: "CartItems",
                newName: "Min_package");

            migrationBuilder.AddColumn<string>(
                name: "Max_package",
                table: "CartItems",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8c163dd1-ae9d-4c6a-bdab-4b9c255c1d21", "75d02a77-9f28-4634-a154-1a6445507628", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "95165abe-a76c-4e47-b0bf-57370a836fd2", "298434c1-6345-4c95-ba3d-ff13494145a6", "Administrator", "ADMINISTRATOR" });
        }
    }
}
