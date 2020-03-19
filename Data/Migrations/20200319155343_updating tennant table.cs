using Microsoft.EntityFrameworkCore.Migrations;

namespace Property_Management.Data.Migrations
{
    public partial class updatingtennanttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Tennant",
                columns: table => new
                {
                    TennantID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentityUserId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tennant", x => x.TennantID);
                    table.ForeignKey(
                        name: "FK_Tennant_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Tennant_IdentityUserId",
                table: "Tennant",
                column: "IdentityUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tennant");

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
    }
}
