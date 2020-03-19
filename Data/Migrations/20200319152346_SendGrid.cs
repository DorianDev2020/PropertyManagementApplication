using Microsoft.EntityFrameworkCore.Migrations;

namespace Property_Management.Data.Migrations
{
    public partial class SendGrid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c8c58a0d-c4d8-4235-a0b8-1327eecf9d87", "0ab69b71-813c-43b9-a89a-22b647f68e30", "LandLord", "LANDLORD" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0e98d261-e1b4-464e-992e-4286e93b3458", "3b06605d-73e0-4f00-8169-81c275b0ac3a", "Contractor", "CONTRACTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f17cf6f2-a473-4cd8-b528-7024ffac2297", "553e51d5-22e9-4ec3-a0d0-b81426b3535f", "Tennant", "TENNANT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e98d261-e1b4-464e-992e-4286e93b3458");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8c58a0d-c4d8-4235-a0b8-1327eecf9d87");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f17cf6f2-a473-4cd8-b528-7024ffac2297");

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
    }
}
