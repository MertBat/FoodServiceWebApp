using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YemekSiparis.DAL.Migrations
{
    public partial class beverageIsselected : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsChecked",
                table: "Extras",
                newName: "IsSelected");

            migrationBuilder.AddColumn<bool>(
                name: "IsSelected",
                table: "Beverages",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSelected",
                table: "Beverages");

            migrationBuilder.RenameColumn(
                name: "IsSelected",
                table: "Extras",
                newName: "IsChecked");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ef1f2063-a864-498a-bc1d-449a0de905f2", "1c6447fc-a1af-495b-a17d-60219b9a22ea" });

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 10, 27, 10, 873, DateTimeKind.Local).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 10, 27, 10, 873, DateTimeKind.Local).AddTicks(7865));

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 10, 27, 10, 873, DateTimeKind.Local).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 10, 27, 10, 873, DateTimeKind.Local).AddTicks(7870));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 10, 27, 10, 873, DateTimeKind.Local).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 10, 27, 10, 873, DateTimeKind.Local).AddTicks(8009));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 10, 27, 10, 873, DateTimeKind.Local).AddTicks(8012));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 10, 27, 10, 873, DateTimeKind.Local).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 10, 27, 10, 873, DateTimeKind.Local).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 10, 27, 10, 873, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 10, 27, 10, 873, DateTimeKind.Local).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 10, 27, 10, 873, DateTimeKind.Local).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 10, 27, 10, 873, DateTimeKind.Local).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 10, 27, 10, 873, DateTimeKind.Local).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 10, 27, 10, 873, DateTimeKind.Local).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 10, 27, 10, 873, DateTimeKind.Local).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 10, 27, 10, 873, DateTimeKind.Local).AddTicks(9383));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 10, 27, 10, 873, DateTimeKind.Local).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 10, 27, 10, 873, DateTimeKind.Local).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "OrderBags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 27, 10, 873, DateTimeKind.Local).AddTicks(9452), new DateTime(2023, 11, 9, 10, 27, 10, 873, DateTimeKind.Local).AddTicks(9453) });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 10, 27, 10, 874, DateTimeKind.Local).AddTicks(744));

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 10, 27, 10, 874, DateTimeKind.Local).AddTicks(769));
        }
    }
}
