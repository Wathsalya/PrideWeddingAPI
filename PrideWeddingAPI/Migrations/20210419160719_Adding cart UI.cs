using Microsoft.EntityFrameworkCore.Migrations;

namespace PrideWeddingAPI.Migrations
{
    public partial class AddingcartUI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1ab66a65-4d48-43fa-97b0-c52b3181b939");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "fc4790ab-8d3c-421e-b601-cd2fb4b2ec7a");

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    CompanyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    CompanyCategory = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    LocatedDistrict = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    LocatedProvince = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Min_package = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Max_package = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    TelephoneNumber = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    CompanyWebsite = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.CompanyID);
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "db78e288-b4a6-4dde-984f-ce7bc29e0605", "67276abd-facc-447f-84fa-8a60f0404058", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a247516f-90b2-4368-8a89-7503a56bee14", "e198ca51-4c88-403c-8799-c5ef2303a45f", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "a247516f-90b2-4368-8a89-7503a56bee14");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "db78e288-b4a6-4dde-984f-ce7bc29e0605");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fc4790ab-8d3c-421e-b601-cd2fb4b2ec7a", "aa5056d9-03b3-490b-aff3-285442ac2d80", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1ab66a65-4d48-43fa-97b0-c52b3181b939", "55dfe398-6ab2-4a53-8ea2-df10de8256e4", "Administrator", "ADMINISTRATOR" });
        }
    }
}
