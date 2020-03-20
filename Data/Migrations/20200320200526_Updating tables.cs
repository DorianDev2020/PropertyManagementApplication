using Microsoft.EntityFrameworkCore.Migrations;

namespace Property_Management.Data.Migrations
{
    public partial class Updatingtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e1b1912-4dfd-4c67-b764-6f7de387b641");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8065bab9-893d-4e03-bc91-039369817e37");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a66db34d-682e-4ddd-862c-21990f2a9c74");

            migrationBuilder.AddColumn<int>(
                name: "AddressID",
                table: "Tennant",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Property_Listing",
                columns: table => new
                {
                    ListingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property_Listing", x => x.ListingID);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Property_Listing");

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
                values: new object[] { "a66db34d-682e-4ddd-862c-21990f2a9c74", "b4a40cdb-9d65-4017-85ef-872acd64bd8b", "LandLord", "LANDLORD" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6e1b1912-4dfd-4c67-b764-6f7de387b641", "63bbd569-62fe-4808-80c4-851952e9f3be", "Contractor", "CONTRACTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8065bab9-893d-4e03-bc91-039369817e37", "45af8863-34d3-4f26-b1d1-792689a8a994", "Tennant", "TENNANT" });
        }
    }
}
