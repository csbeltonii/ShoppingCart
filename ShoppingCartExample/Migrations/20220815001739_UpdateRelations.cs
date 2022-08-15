using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoppingCartExample.Migrations
{
    public partial class UpdateRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Total",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "UniqueIdentifier",
                table: "Products",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UniqueIdentifier",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId1",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "UniqueIdentifier",
                table: "OrderLineItem",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UniqueIdentifier",
                table: "Customers",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Products_UniqueIdentifier",
                table: "Products",
                column: "UniqueIdentifier");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Orders_UniqueIdentifier",
                table: "Orders",
                column: "UniqueIdentifier");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_OrderLineItem_UniqueIdentifier",
                table: "OrderLineItem",
                column: "UniqueIdentifier");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Customers_UniqueIdentifier",
                table: "Customers",
                column: "UniqueIdentifier");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "LastPurchased", "Name", "Price", "TimeCreated", "TimeModified", "UniqueIdentifier" },
                values: new object[] { 1, "IBANEZ RG655CBM (COBALT BLUE METALLIC)", new DateTime(2016, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Persephone", 1599.99m, new DateTime(2022, 8, 14, 20, 17, 39, 423, DateTimeKind.Local).AddTicks(857), new DateTime(2022, 8, 14, 20, 17, 39, 423, DateTimeKind.Local).AddTicks(924), "a6ae32d5-1c9e-4e85-b1e0-6ef380ae3a9a" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "LastPurchased", "Name", "Price", "TimeCreated", "TimeModified", "UniqueIdentifier" },
                values: new object[] { 2, "FENDER STRATOCASTER STANDARD (ARCTIC WHITE)", new DateTime(2010, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aphrodite", 549.99m, new DateTime(2022, 8, 14, 20, 17, 39, 423, DateTimeKind.Local).AddTicks(979), new DateTime(2022, 8, 14, 20, 17, 39, 423, DateTimeKind.Local).AddTicks(986), "72dcf6cc-0999-4939-a13e-ea8265408e8b" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "LastPurchased", "Name", "Price", "TimeCreated", "TimeModified", "UniqueIdentifier" },
                values: new object[] { 3, "IBANEZ S1070PBZ (CERULEAN BLUE BURST)", new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ceres", 1866.99m, new DateTime(2022, 8, 14, 20, 17, 39, 423, DateTimeKind.Local).AddTicks(1017), new DateTime(2022, 8, 14, 20, 17, 39, 423, DateTimeKind.Local).AddTicks(1023), "63b1a019-07c2-4fc3-adb2-1713d5296fe0" });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId1",
                table: "Orders",
                column: "CustomerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerId1",
                table: "Orders",
                column: "CustomerId1",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerId1",
                table: "Orders");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Products_UniqueIdentifier",
                table: "Products");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Orders_UniqueIdentifier",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CustomerId1",
                table: "Orders");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_OrderLineItem_UniqueIdentifier",
                table: "OrderLineItem");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Customers_UniqueIdentifier",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CustomerId1",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "UniqueIdentifier",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "UniqueIdentifier",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<string>(
                name: "UniqueIdentifier",
                table: "OrderLineItem",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "UniqueIdentifier",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TimeCreated", "TimeModified", "UniqueIdentifier" },
                values: new object[] { new DateTime(2022, 8, 14, 15, 19, 32, 842, DateTimeKind.Local).AddTicks(9819), new DateTime(2022, 8, 14, 15, 19, 32, 842, DateTimeKind.Local).AddTicks(9883), "c1d7f3c0-7fe1-4011-bf19-a4720d34b51a" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TimeCreated", "TimeModified", "UniqueIdentifier" },
                values: new object[] { new DateTime(2022, 8, 14, 15, 19, 32, 842, DateTimeKind.Local).AddTicks(9927), new DateTime(2022, 8, 14, 15, 19, 32, 842, DateTimeKind.Local).AddTicks(9931), "e7f0ad02-5082-4e84-85c1-4774128e1f6c" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "TimeCreated", "TimeModified", "UniqueIdentifier" },
                values: new object[] { new DateTime(2022, 8, 14, 15, 19, 32, 842, DateTimeKind.Local).AddTicks(9952), new DateTime(2022, 8, 14, 15, 19, 32, 842, DateTimeKind.Local).AddTicks(9956), "40a62f55-b3d5-4105-860b-61015f443f16" });
        }
    }
}
