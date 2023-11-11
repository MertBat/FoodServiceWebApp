using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YemekSiparis.DAL.Migrations
{
    public partial class orderStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderStatus",
                table: "Foods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "084eca70-3bd4-434c-9b97-06cf29a3264f", "0150cada-6666-4825-a375-0b1fa5456045" });

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 8, 0, 4, 56, 582, DateTimeKind.Local).AddTicks(3217));

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 8, 0, 4, 56, 582, DateTimeKind.Local).AddTicks(3223));

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 8, 0, 4, 56, 582, DateTimeKind.Local).AddTicks(3225));

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 8, 0, 4, 56, 582, DateTimeKind.Local).AddTicks(3228));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 8, 0, 4, 56, 582, DateTimeKind.Local).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 8, 0, 4, 56, 582, DateTimeKind.Local).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 8, 0, 4, 56, 582, DateTimeKind.Local).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 8, 0, 4, 56, 582, DateTimeKind.Local).AddTicks(3403));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 8, 0, 4, 56, 582, DateTimeKind.Local).AddTicks(3478));

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 8, 0, 4, 56, 582, DateTimeKind.Local).AddTicks(3538));

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 8, 0, 4, 56, 582, DateTimeKind.Local).AddTicks(3542));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 8, 0, 4, 56, 582, DateTimeKind.Local).AddTicks(3601));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 8, 0, 4, 56, 582, DateTimeKind.Local).AddTicks(3605));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 8, 0, 4, 56, 582, DateTimeKind.Local).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 8, 0, 4, 56, 582, DateTimeKind.Local).AddTicks(3664));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 8, 0, 4, 56, 582, DateTimeKind.Local).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 8, 0, 4, 56, 582, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 8, 0, 4, 56, 582, DateTimeKind.Local).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 8, 0, 4, 56, 582, DateTimeKind.Local).AddTicks(4776));

            migrationBuilder.UpdateData(
                table: "OrderBags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 11, 8, 0, 4, 56, 582, DateTimeKind.Local).AddTicks(4838), new DateTime(2023, 11, 8, 0, 4, 56, 582, DateTimeKind.Local).AddTicks(4839) });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 8, 0, 4, 56, 582, DateTimeKind.Local).AddTicks(6068));

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 8, 0, 4, 56, 582, DateTimeKind.Local).AddTicks(6072));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderStatus",
                table: "Foods");

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
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 23, 23, 48, 304, DateTimeKind.Local).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 23, 23, 48, 304, DateTimeKind.Local).AddTicks(6616));

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
    }
}
