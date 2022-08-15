using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoppingCartExample.Migrations
{
    public partial class NewModelFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Orders_OrderId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_OrderId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Products");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "IsFulfilled",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "TimeCreated",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "OrderLineItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UniqueIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderLineItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderLineItem_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Price", "TimeCreated", "TimeModified", "UniqueIdentifier" },
                values: new object[] { 1599.99m, new DateTime(2022, 8, 14, 15, 19, 32, 842, DateTimeKind.Local).AddTicks(9819), new DateTime(2022, 8, 14, 15, 19, 32, 842, DateTimeKind.Local).AddTicks(9883), "c1d7f3c0-7fe1-4011-bf19-a4720d34b51a" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Price", "TimeCreated", "TimeModified", "UniqueIdentifier" },
                values: new object[] { 549.99m, new DateTime(2022, 8, 14, 15, 19, 32, 842, DateTimeKind.Local).AddTicks(9927), new DateTime(2022, 8, 14, 15, 19, 32, 842, DateTimeKind.Local).AddTicks(9931), "e7f0ad02-5082-4e84-85c1-4774128e1f6c" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Price", "TimeCreated", "TimeModified", "UniqueIdentifier" },
                values: new object[] { 1866.99m, new DateTime(2022, 8, 14, 15, 19, 32, 842, DateTimeKind.Local).AddTicks(9952), new DateTime(2022, 8, 14, 15, 19, 32, 842, DateTimeKind.Local).AddTicks(9956), "40a62f55-b3d5-4105-860b-61015f443f16" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderLineItem_OrderId",
                table: "OrderLineItem",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderLineItem");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsFulfilled",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "TimeCreated",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TimeCreated", "TimeModified", "UniqueIdentifier" },
                values: new object[] { new DateTime(2022, 8, 14, 9, 8, 7, 393, DateTimeKind.Local).AddTicks(3555), new DateTime(2022, 8, 14, 9, 8, 7, 393, DateTimeKind.Local).AddTicks(3597), "55cc467d-0961-4dd5-9314-361067bf0a53" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TimeCreated", "TimeModified", "UniqueIdentifier" },
                values: new object[] { new DateTime(2022, 8, 14, 9, 8, 7, 393, DateTimeKind.Local).AddTicks(3622), new DateTime(2022, 8, 14, 9, 8, 7, 393, DateTimeKind.Local).AddTicks(3624), "ac567375-69a4-4b19-a03e-5059b5619c65" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "TimeCreated", "TimeModified", "UniqueIdentifier" },
                values: new object[] { new DateTime(2022, 8, 14, 9, 8, 7, 393, DateTimeKind.Local).AddTicks(3635), new DateTime(2022, 8, 14, 9, 8, 7, 393, DateTimeKind.Local).AddTicks(3637), "46a8f352-5754-4acf-ba59-9024ba086139" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_OrderId",
                table: "Products",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Orders_OrderId",
                table: "Products",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");
        }
    }
}
