using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YemekSiparis.DAL.Migrations
{
    public partial class AddManyToManytable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetailBeverage_Beverages_BeverageID",
                table: "OrderDetailBeverage");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetailBeverage_OrderDetails_OrderDetailID",
                table: "OrderDetailBeverage");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetailExtra_Extras_ExtraID",
                table: "OrderDetailExtra");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetailExtra_OrderDetails_OrderDetailID",
                table: "OrderDetailExtra");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetailExtra",
                table: "OrderDetailExtra");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetailBeverage",
                table: "OrderDetailBeverage");

            migrationBuilder.RenameTable(
                name: "OrderDetailExtra",
                newName: "OrderDetailExtras");

            migrationBuilder.RenameTable(
                name: "OrderDetailBeverage",
                newName: "OrderDetailBeverages");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetailExtra_ExtraID",
                table: "OrderDetailExtras",
                newName: "IX_OrderDetailExtras_ExtraID");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetailBeverage_OrderDetailID",
                table: "OrderDetailBeverages",
                newName: "IX_OrderDetailBeverages_OrderDetailID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetailExtras",
                table: "OrderDetailExtras",
                columns: new[] { "OrderDetailID", "ExtraID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetailBeverages",
                table: "OrderDetailBeverages",
                columns: new[] { "BeverageID", "OrderDetailID" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7bdf1159-ba0a-43b6-8c79-1303e61c3058", "8abad0e0-7c90-4834-9e41-53064ad6f6cc" });

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 20, 56, 30, 363, DateTimeKind.Local).AddTicks(8388));

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 20, 56, 30, 363, DateTimeKind.Local).AddTicks(8401));

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 20, 56, 30, 363, DateTimeKind.Local).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 20, 56, 30, 363, DateTimeKind.Local).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 20, 56, 30, 363, DateTimeKind.Local).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 20, 56, 30, 363, DateTimeKind.Local).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 20, 56, 30, 363, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 20, 56, 30, 363, DateTimeKind.Local).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 20, 56, 30, 363, DateTimeKind.Local).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 20, 56, 30, 363, DateTimeKind.Local).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 20, 56, 30, 363, DateTimeKind.Local).AddTicks(8647));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 20, 56, 30, 363, DateTimeKind.Local).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 20, 56, 30, 363, DateTimeKind.Local).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 20, 56, 30, 363, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 20, 56, 30, 363, DateTimeKind.Local).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 20, 56, 30, 363, DateTimeKind.Local).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 20, 56, 30, 364, DateTimeKind.Local).AddTicks(65));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 20, 56, 30, 364, DateTimeKind.Local).AddTicks(71));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 20, 56, 30, 364, DateTimeKind.Local).AddTicks(74));

            migrationBuilder.UpdateData(
                table: "OrderBags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 11, 9, 20, 56, 30, 364, DateTimeKind.Local).AddTicks(135), new DateTime(2023, 11, 9, 20, 56, 30, 364, DateTimeKind.Local).AddTicks(136) });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 20, 56, 30, 364, DateTimeKind.Local).AddTicks(1328));

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 20, 56, 30, 364, DateTimeKind.Local).AddTicks(1334));

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetailBeverages_Beverages_BeverageID",
                table: "OrderDetailBeverages",
                column: "BeverageID",
                principalTable: "Beverages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetailBeverages_OrderDetails_OrderDetailID",
                table: "OrderDetailBeverages",
                column: "OrderDetailID",
                principalTable: "OrderDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetailExtras_Extras_ExtraID",
                table: "OrderDetailExtras",
                column: "ExtraID",
                principalTable: "Extras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetailExtras_OrderDetails_OrderDetailID",
                table: "OrderDetailExtras",
                column: "OrderDetailID",
                principalTable: "OrderDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetailBeverages_Beverages_BeverageID",
                table: "OrderDetailBeverages");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetailBeverages_OrderDetails_OrderDetailID",
                table: "OrderDetailBeverages");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetailExtras_Extras_ExtraID",
                table: "OrderDetailExtras");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetailExtras_OrderDetails_OrderDetailID",
                table: "OrderDetailExtras");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetailExtras",
                table: "OrderDetailExtras");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetailBeverages",
                table: "OrderDetailBeverages");

            migrationBuilder.RenameTable(
                name: "OrderDetailExtras",
                newName: "OrderDetailExtra");

            migrationBuilder.RenameTable(
                name: "OrderDetailBeverages",
                newName: "OrderDetailBeverage");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetailExtras_ExtraID",
                table: "OrderDetailExtra",
                newName: "IX_OrderDetailExtra_ExtraID");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetailBeverages_OrderDetailID",
                table: "OrderDetailBeverage",
                newName: "IX_OrderDetailBeverage_OrderDetailID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetailExtra",
                table: "OrderDetailExtra",
                columns: new[] { "OrderDetailID", "ExtraID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetailBeverage",
                table: "OrderDetailBeverage",
                columns: new[] { "BeverageID", "OrderDetailID" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1cedeb31-c8e9-4a5c-a534-2b426ccb25bf", "4ba2ee31-cd59-4de2-9d90-04952a43c19c" });

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 10, 37, 18, 411, DateTimeKind.Local).AddTicks(2957));

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 10, 37, 18, 411, DateTimeKind.Local).AddTicks(2967));

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 10, 37, 18, 411, DateTimeKind.Local).AddTicks(2970));

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 10, 37, 18, 411, DateTimeKind.Local).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 10, 37, 18, 411, DateTimeKind.Local).AddTicks(3109));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 10, 37, 18, 411, DateTimeKind.Local).AddTicks(3113));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 10, 37, 18, 411, DateTimeKind.Local).AddTicks(3137));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 10, 37, 18, 411, DateTimeKind.Local).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 10, 37, 18, 411, DateTimeKind.Local).AddTicks(3215));

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 10, 37, 18, 411, DateTimeKind.Local).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 10, 37, 18, 411, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 10, 37, 18, 411, DateTimeKind.Local).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 10, 37, 18, 411, DateTimeKind.Local).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 10, 37, 18, 411, DateTimeKind.Local).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 10, 37, 18, 411, DateTimeKind.Local).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 10, 37, 18, 411, DateTimeKind.Local).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 10, 37, 18, 411, DateTimeKind.Local).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 10, 37, 18, 411, DateTimeKind.Local).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 10, 37, 18, 411, DateTimeKind.Local).AddTicks(4524));

            migrationBuilder.UpdateData(
                table: "OrderBags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 37, 18, 411, DateTimeKind.Local).AddTicks(4605), new DateTime(2023, 11, 9, 10, 37, 18, 411, DateTimeKind.Local).AddTicks(4606) });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 10, 37, 18, 411, DateTimeKind.Local).AddTicks(5904));

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 10, 37, 18, 411, DateTimeKind.Local).AddTicks(5909));

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetailBeverage_Beverages_BeverageID",
                table: "OrderDetailBeverage",
                column: "BeverageID",
                principalTable: "Beverages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetailBeverage_OrderDetails_OrderDetailID",
                table: "OrderDetailBeverage",
                column: "OrderDetailID",
                principalTable: "OrderDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetailExtra_Extras_ExtraID",
                table: "OrderDetailExtra",
                column: "ExtraID",
                principalTable: "Extras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetailExtra_OrderDetails_OrderDetailID",
                table: "OrderDetailExtra",
                column: "OrderDetailID",
                principalTable: "OrderDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
