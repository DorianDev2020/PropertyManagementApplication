using Microsoft.EntityFrameworkCore.Migrations;

namespace Property_Management.Data.Migrations
{
    public partial class AddedmantenanceTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "7a2b1d0a-6ce7-4438-95eb-de79e56c0a99", "fab620f1-58b4-4b63-b808-9215f486a569", "LandLord", "LANDLORD" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "357f94e9-cead-46ef-a418-5e08e984d536", "a430095e-edf0-4b9e-94ad-89a82b752e85", "Contractor", "CONTRACTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "95ace3d1-737f-4190-a753-28b5c2e539e8", "ecdc3801-2ffc-4b71-bfe5-a83bbd443de6", "Tennant", "TENNANT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "357f94e9-cead-46ef-a418-5e08e984d536");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a2b1d0a-6ce7-4438-95eb-de79e56c0a99");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "95ace3d1-737f-4190-a753-28b5c2e539e8");

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
    }
}
