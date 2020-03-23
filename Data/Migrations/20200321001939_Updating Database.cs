using Microsoft.EntityFrameworkCore.Migrations;

namespace Property_Management.Data.Migrations
{
    public partial class UpdatingDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "510cdeda-fc3d-4a5c-acd4-b2d01c0923c1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5975c848-9ca9-4402-9348-89bd237604ad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba983200-7f83-4f46-8957-e99713a368c1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cf0faf4a-c88b-42d7-abfa-d1420dbbbc3b", "a5757598-ec5d-4f3c-9d5d-5556d9be9025", "LandLord", "LANDLORD" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e6332d32-2d6e-4769-a8f9-2099f9232b53", "a9de70f2-cb5e-4b48-9d57-7cb2dbade098", "Contractor", "CONTRACTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c9fa8f84-bd99-4d21-8cd8-4c7db152c2cd", "e5ec9616-039a-4721-afe2-a73d35284ae5", "Tennant", "TENNANT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9fa8f84-bd99-4d21-8cd8-4c7db152c2cd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf0faf4a-c88b-42d7-abfa-d1420dbbbc3b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e6332d32-2d6e-4769-a8f9-2099f9232b53");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ba983200-7f83-4f46-8957-e99713a368c1", "ccd2e2cf-df56-417f-b997-f9c1e70c4a0b", "LandLord", "LANDLORD" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5975c848-9ca9-4402-9348-89bd237604ad", "97e53e64-751c-4b6c-ab7f-d8da9cee945f", "Contractor", "CONTRACTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "510cdeda-fc3d-4a5c-acd4-b2d01c0923c1", "b9ad7e94-fb45-404a-baa9-360698e1309b", "Tennant", "TENNANT" });
        }
    }
}
