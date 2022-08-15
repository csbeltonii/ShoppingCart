using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoppingCartExample.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UniqueIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UniqueIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UniqueIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastPurchased = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "LastPurchased", "Name", "OrderId", "TimeCreated", "TimeModified", "UniqueIdentifier" },
                values: new object[] { 1, "IBANEZ RG655CBM (COBALT BLUE METALLIC)", new DateTime(2016, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Persephone", null, new DateTime(2022, 8, 14, 9, 8, 7, 393, DateTimeKind.Local).AddTicks(3555), new DateTime(2022, 8, 14, 9, 8, 7, 393, DateTimeKind.Local).AddTicks(3597), "55cc467d-0961-4dd5-9314-361067bf0a53" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "LastPurchased", "Name", "OrderId", "TimeCreated", "TimeModified", "UniqueIdentifier" },
                values: new object[] { 2, "FENDER STRATOCASTER STANDARD (ARCTIC WHITE)", new DateTime(2010, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aphrodite", null, new DateTime(2022, 8, 14, 9, 8, 7, 393, DateTimeKind.Local).AddTicks(3622), new DateTime(2022, 8, 14, 9, 8, 7, 393, DateTimeKind.Local).AddTicks(3624), "ac567375-69a4-4b19-a03e-5059b5619c65" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "LastPurchased", "Name", "OrderId", "TimeCreated", "TimeModified", "UniqueIdentifier" },
                values: new object[] { 3, "IBANEZ S1070PBZ (CERULEAN BLUE BURST)", new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ceres", null, new DateTime(2022, 8, 14, 9, 8, 7, 393, DateTimeKind.Local).AddTicks(3635), new DateTime(2022, 8, 14, 9, 8, 7, 393, DateTimeKind.Local).AddTicks(3637), "46a8f352-5754-4acf-ba59-9024ba086139" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_OrderId",
                table: "Products",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
