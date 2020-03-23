using Microsoft.EntityFrameworkCore.Migrations;

namespace Property_Management.Data.Migrations
{
    public partial class Removedsavedusers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "AdminID",
                table: "Property_Listing",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Available",
                table: "Property_Listing",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Baths",
                table: "Property_Listing",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Beds",
                table: "Property_Listing",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LandLordId",
                table: "Property_Listing",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SquareFeet",
                table: "Property_Listing",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TennantID",
                table: "Property_Listing",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ZipCode",
                table: "Property_Listing",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Contractor",
                columns: table => new
                {
                    ContractorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentityUserId = table.Column<string>(nullable: true),
                    BusinessName = table.Column<string>(nullable: true),
                    TechnicianName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contractor", x => x.ContractorID);
                    table.ForeignKey(
                        name: "FK_Contractor_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LandLord",
                columns: table => new
                {
                    AdminID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentityUserId = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandLord", x => x.AdminID);
                    table.ForeignKey(
                        name: "FK_LandLord_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Property_Listing_LandLordId",
                table: "Property_Listing",
                column: "LandLordId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_Listing_TennantID",
                table: "Property_Listing",
                column: "TennantID");

            migrationBuilder.CreateIndex(
                name: "IX_Contractor_IdentityUserId",
                table: "Contractor",
                column: "IdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_LandLord_IdentityUserId",
                table: "LandLord",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Listing_LandLord_LandLordId",
                table: "Property_Listing",
                column: "LandLordId",
                principalTable: "LandLord",
                principalColumn: "AdminID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Listing_Tennant_TennantID",
                table: "Property_Listing",
                column: "TennantID",
                principalTable: "Tennant",
                principalColumn: "TennantID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Property_Listing_LandLord_LandLordId",
                table: "Property_Listing");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_Listing_Tennant_TennantID",
                table: "Property_Listing");

            migrationBuilder.DropTable(
                name: "Contractor");

            migrationBuilder.DropTable(
                name: "LandLord");

            migrationBuilder.DropIndex(
                name: "IX_Property_Listing_LandLordId",
                table: "Property_Listing");

            migrationBuilder.DropIndex(
                name: "IX_Property_Listing_TennantID",
                table: "Property_Listing");

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

            migrationBuilder.DropColumn(
                name: "AdminID",
                table: "Property_Listing");

            migrationBuilder.DropColumn(
                name: "Available",
                table: "Property_Listing");

            migrationBuilder.DropColumn(
                name: "Baths",
                table: "Property_Listing");

            migrationBuilder.DropColumn(
                name: "Beds",
                table: "Property_Listing");

            migrationBuilder.DropColumn(
                name: "LandLordId",
                table: "Property_Listing");

            migrationBuilder.DropColumn(
                name: "SquareFeet",
                table: "Property_Listing");

            migrationBuilder.DropColumn(
                name: "TennantID",
                table: "Property_Listing");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Property_Listing");

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
    }
}
