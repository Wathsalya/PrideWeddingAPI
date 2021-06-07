using Microsoft.EntityFrameworkCore.Migrations;

namespace PrideWeddingAPI.Migrations
{
    public partial class ModifyNewsteller : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_NewstellerSubscribers",
                table: "NewstellerSubscribers");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "5eb97031-657c-4571-a1b9-c68c17e90064");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f62b196a-63f2-4450-b592-5f4f04b11b14");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "NewstellerSubscribers");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "NewstellerSubscribers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "SubscriberID",
                table: "NewstellerSubscribers",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NewstellerSubscribers",
                table: "NewstellerSubscribers",
                column: "SubscriberID");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "52a71aa8-c990-4105-9965-c92f2ab3d62a", "c9aa9140-dfa0-48c7-bf34-f30102436dca", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f290ae63-ae8e-47ed-9f14-a65a65b7fc55", "2ef16ce9-5e33-4de0-b4ce-e1edd40cd7e2", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_NewstellerSubscribers",
                table: "NewstellerSubscribers");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "52a71aa8-c990-4105-9965-c92f2ab3d62a");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f290ae63-ae8e-47ed-9f14-a65a65b7fc55");

            migrationBuilder.DropColumn(
                name: "SubscriberID",
                table: "NewstellerSubscribers");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "NewstellerSubscribers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "NewstellerSubscribers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NewstellerSubscribers",
                table: "NewstellerSubscribers",
                column: "ID");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5eb97031-657c-4571-a1b9-c68c17e90064", "226397fe-0dec-43ed-882b-db053ef3411c", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f62b196a-63f2-4450-b592-5f4f04b11b14", "2b162bd1-273c-4098-be1f-7044a40c7159", "Administrator", "ADMINISTRATOR" });
        }
    }
}
