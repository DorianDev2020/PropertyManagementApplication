using Microsoft.EntityFrameworkCore.Migrations;

namespace Property_Management.Data.Migrations
{
    public partial class MovedForeignKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "083fbb28-e48b-4a6e-ba8d-cd4bd296080a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4cb52179-eabf-4f7f-903c-9cca6e6c141f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c77585ee-b582-4aa3-8e1a-085feee385e8");

            migrationBuilder.DropColumn(
                name: "AddressID",
                table: "Tennant");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "AddressID",
                table: "Tennant",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c77585ee-b582-4aa3-8e1a-085feee385e8", "303f8ba8-7ee9-4559-902c-22dc110e9a46", "LandLord", "LANDLORD" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4cb52179-eabf-4f7f-903c-9cca6e6c141f", "f71b81f9-9e98-47f6-8609-4dbec59587b7", "Contractor", "CONTRACTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "083fbb28-e48b-4a6e-ba8d-cd4bd296080a", "abfaa7fc-114d-4782-9218-bbece385e822", "Tennant", "TENNANT" });
        }
    }
}
