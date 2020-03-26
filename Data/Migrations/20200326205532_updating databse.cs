using Microsoft.EntityFrameworkCore.Migrations;

namespace Property_Management.Data.Migrations
{
    public partial class updatingdatabse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "9079babc-d2dc-424b-9ae0-b978b49c6129", "bb24d56c-8682-4ae5-92eb-a77c1ee27d6a", "LandLord", "LANDLORD" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a0fac794-c4e0-4993-949e-0da7091d4d29", "8a611770-0434-4dc2-9b50-51f20e58a1e9", "Contractor", "CONTRACTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "99b9131d-0064-492e-bc73-700eb6b3dd8b", "aee1dd9c-b681-4218-8214-21b8cd9d1e42", "Tennant", "TENNANT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9079babc-d2dc-424b-9ae0-b978b49c6129");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99b9131d-0064-492e-bc73-700eb6b3dd8b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0fac794-c4e0-4993-949e-0da7091d4d29");

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
    }
}
