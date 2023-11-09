using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YemekSiparis.DAL.Migrations
{
    public partial class initialMakarna : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e9b45b23-9322-4232-930c-c359cf7fb68c", "63047598-d5d9-4b94-8523-a731d43a12a4" });

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 23, 23, 48, 304, DateTimeKind.Local).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 23, 23, 48, 304, DateTimeKind.Local).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 23, 23, 48, 304, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 23, 23, 48, 304, DateTimeKind.Local).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 23, 23, 48, 304, DateTimeKind.Local).AddTicks(5268));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 23, 23, 48, 304, DateTimeKind.Local).AddTicks(5272));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 23, 23, 48, 304, DateTimeKind.Local).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 23, 23, 48, 304, DateTimeKind.Local).AddTicks(5276));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 23, 23, 48, 304, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 23, 23, 48, 304, DateTimeKind.Local).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 23, 23, 48, 304, DateTimeKind.Local).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 23, 23, 48, 304, DateTimeKind.Local).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 23, 23, 48, 304, DateTimeKind.Local).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 23, 23, 48, 304, DateTimeKind.Local).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 23, 23, 48, 304, DateTimeKind.Local).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 23, 23, 48, 304, DateTimeKind.Local).AddTicks(5566));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 23, 23, 48, 304, DateTimeKind.Local).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PrepTime" },
                values: new object[] { new DateTime(2023, 11, 7, 23, 23, 48, 304, DateTimeKind.Local).AddTicks(6614), 24 });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "CategoryID", "ClickCount", "CreatedDate", "DeletedDate", "Description", "Discount", "Image", "ModifiedDate", "Name", "PrepTime", "Price", "Rating", "Status", "Stock" },
                values: new object[] { 3, 3, 0, new DateTime(2023, 11, 7, 23, 23, 48, 304, DateTimeKind.Local).AddTicks(6616), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Penne Sosu, Krema", 0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Penne Soslu Makarna", 30, 125m, null, 1, 45 });

            migrationBuilder.UpdateData(
                table: "OrderBags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 11, 7, 23, 23, 48, 304, DateTimeKind.Local).AddTicks(6711), new DateTime(2023, 11, 7, 23, 23, 48, 304, DateTimeKind.Local).AddTicks(6712) });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 23, 23, 48, 304, DateTimeKind.Local).AddTicks(7988));

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 23, 23, 48, 304, DateTimeKind.Local).AddTicks(8013));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a63060b4-78c7-4c85-9c92-4c6ba4f74f1a", "73993397-0ca2-44d0-93c4-ad9513f361ce" });

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 16, 46, 40, 100, DateTimeKind.Local).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 16, 46, 40, 100, DateTimeKind.Local).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 16, 46, 40, 100, DateTimeKind.Local).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 16, 46, 40, 100, DateTimeKind.Local).AddTicks(2318));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 16, 46, 40, 100, DateTimeKind.Local).AddTicks(2450));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 16, 46, 40, 100, DateTimeKind.Local).AddTicks(2454));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 16, 46, 40, 100, DateTimeKind.Local).AddTicks(2457));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 16, 46, 40, 100, DateTimeKind.Local).AddTicks(2459));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 16, 46, 40, 100, DateTimeKind.Local).AddTicks(2531));

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 16, 46, 40, 100, DateTimeKind.Local).AddTicks(2639));

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 16, 46, 40, 100, DateTimeKind.Local).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 16, 46, 40, 100, DateTimeKind.Local).AddTicks(2709));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 16, 46, 40, 100, DateTimeKind.Local).AddTicks(2714));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 16, 46, 40, 100, DateTimeKind.Local).AddTicks(2785));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 16, 46, 40, 100, DateTimeKind.Local).AddTicks(2789));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 16, 46, 40, 100, DateTimeKind.Local).AddTicks(2791));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 16, 46, 40, 100, DateTimeKind.Local).AddTicks(3932));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PrepTime" },
                values: new object[] { new DateTime(2023, 11, 7, 16, 46, 40, 100, DateTimeKind.Local).AddTicks(3936), 20 });

            migrationBuilder.UpdateData(
                table: "OrderBags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 11, 7, 16, 46, 40, 100, DateTimeKind.Local).AddTicks(3995), new DateTime(2023, 11, 7, 16, 46, 40, 100, DateTimeKind.Local).AddTicks(3996) });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 16, 46, 40, 100, DateTimeKind.Local).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 16, 46, 40, 100, DateTimeKind.Local).AddTicks(5212));
        }
    }
}
