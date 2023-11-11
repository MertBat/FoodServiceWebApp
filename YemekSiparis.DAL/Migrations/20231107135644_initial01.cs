using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YemekSiparis.DAL.Migrations
{
    public partial class initial01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "Customers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthdate",
                table: "Customers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Customers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4420caa1-bc64-4fdb-abec-882c8299c765", "2133651d-4079-4f1a-80eb-0ac3e1cd970f" });

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 16, 56, 43, 979, DateTimeKind.Local).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 16, 56, 43, 979, DateTimeKind.Local).AddTicks(1892));

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 16, 56, 43, 979, DateTimeKind.Local).AddTicks(1895));

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 16, 56, 43, 979, DateTimeKind.Local).AddTicks(1897));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 16, 56, 43, 979, DateTimeKind.Local).AddTicks(1972));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 16, 56, 43, 979, DateTimeKind.Local).AddTicks(1976));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 16, 56, 43, 979, DateTimeKind.Local).AddTicks(1978));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 16, 56, 43, 979, DateTimeKind.Local).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 16, 56, 43, 979, DateTimeKind.Local).AddTicks(2069));

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 16, 56, 43, 979, DateTimeKind.Local).AddTicks(2153));

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 16, 56, 43, 979, DateTimeKind.Local).AddTicks(2156));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 16, 56, 43, 979, DateTimeKind.Local).AddTicks(2214));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 16, 56, 43, 979, DateTimeKind.Local).AddTicks(2218));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 16, 56, 43, 979, DateTimeKind.Local).AddTicks(2298));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 16, 56, 43, 979, DateTimeKind.Local).AddTicks(2302));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 16, 56, 43, 979, DateTimeKind.Local).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 16, 56, 43, 979, DateTimeKind.Local).AddTicks(3488));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 16, 56, 43, 979, DateTimeKind.Local).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "OrderBags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 11, 7, 16, 56, 43, 979, DateTimeKind.Local).AddTicks(3553), new DateTime(2023, 11, 7, 16, 56, 43, 979, DateTimeKind.Local).AddTicks(3554) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 16, 56, 43, 979, DateTimeKind.Local).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 16, 56, 43, 979, DateTimeKind.Local).AddTicks(4832));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthdate",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5d018d52-1058-445c-acb4-bcf98fd4c48b", "234b89fd-4c1f-4deb-9d71-01ab645b6d1e" });

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 11, 29, 46, 890, DateTimeKind.Local).AddTicks(5622));

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 11, 29, 46, 890, DateTimeKind.Local).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 11, 29, 46, 890, DateTimeKind.Local).AddTicks(5638));

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 11, 29, 46, 890, DateTimeKind.Local).AddTicks(5642));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 11, 29, 46, 890, DateTimeKind.Local).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 11, 29, 46, 890, DateTimeKind.Local).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 11, 29, 46, 890, DateTimeKind.Local).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 11, 29, 46, 890, DateTimeKind.Local).AddTicks(5745));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 11, 29, 46, 890, DateTimeKind.Local).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 11, 29, 46, 890, DateTimeKind.Local).AddTicks(5929));

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 11, 29, 46, 890, DateTimeKind.Local).AddTicks(5935));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 11, 29, 46, 890, DateTimeKind.Local).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 11, 29, 46, 890, DateTimeKind.Local).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 11, 29, 46, 890, DateTimeKind.Local).AddTicks(6075));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 11, 29, 46, 890, DateTimeKind.Local).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 11, 29, 46, 890, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 11, 29, 46, 890, DateTimeKind.Local).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 11, 29, 46, 890, DateTimeKind.Local).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "OrderBags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 11, 7, 11, 29, 46, 890, DateTimeKind.Local).AddTicks(7576), new DateTime(2023, 11, 7, 11, 29, 46, 890, DateTimeKind.Local).AddTicks(7576) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 11, 29, 46, 890, DateTimeKind.Local).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 11, 29, 46, 890, DateTimeKind.Local).AddTicks(9048));
        }
    }
}
