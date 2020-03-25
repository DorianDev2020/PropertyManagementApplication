using Microsoft.EntityFrameworkCore.Migrations;

namespace Property_Management.Data.Migrations
{
    public partial class AddedMaintenanceModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e3fbd56-f016-4a3a-8ec1-1f770f6fe9f4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7148648-5e34-4d77-b790-18643f6dc271");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea7bb4ca-d043-4187-b6d5-fc52a73e9990");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "216747a5-3ead-4ca3-a500-7e5688dfdac2", "05bf7020-6591-4f3a-996f-11954b5b2532", "LandLord", "LANDLORD" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4d6fc895-13b1-4cc1-abaf-94d311125498", "421834ff-81ed-4407-a422-253cb2f7b6fa", "Contractor", "CONTRACTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "87b7e0f9-95ac-4640-8925-81a867063033", "0468ccf8-a234-47af-a055-b8f82870d60f", "Tennant", "TENNANT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "216747a5-3ead-4ca3-a500-7e5688dfdac2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d6fc895-13b1-4cc1-abaf-94d311125498");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87b7e0f9-95ac-4640-8925-81a867063033");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c7148648-5e34-4d77-b790-18643f6dc271", "a7228903-0486-4ef3-9e9b-9b1b1096a7b8", "LandLord", "LANDLORD" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5e3fbd56-f016-4a3a-8ec1-1f770f6fe9f4", "c184231b-7ef7-4bff-a797-9c2defe54254", "Contractor", "CONTRACTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ea7bb4ca-d043-4187-b6d5-fc52a73e9990", "b0a76369-9b79-4a44-9adb-5392b5ed07b6", "Tennant", "TENNANT" });
        }
    }
}
