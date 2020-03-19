using Microsoft.EntityFrameworkCore.Migrations;

namespace Property_Management.Data.Migrations
{
    public partial class seedingdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "58206b39-c1be-45d0-9386-6a9dfd9655cd", "5d007f9f-c312-4b65-9178-7b6eff322f02", "LandLord", "LANDLORD" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b5dc6cc6-23e6-4817-86a2-10e1b6c2e7dc", "4a9e0b24-8b04-4014-886f-b4a285bdbcac", "Contractor", "CONTRACTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "68182bb2-290e-41e3-ac54-466d6b2bdd24", "77ff58b8-9393-4484-9b11-944a282df1cc", "Tennant", "TENNANT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "58206b39-c1be-45d0-9386-6a9dfd9655cd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68182bb2-290e-41e3-ac54-466d6b2bdd24");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b5dc6cc6-23e6-4817-86a2-10e1b6c2e7dc");
        }
    }
}
