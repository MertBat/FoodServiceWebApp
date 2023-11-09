using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YemekSiparis.DAL.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodDiet_Diets_DietID",
                table: "FoodDiet");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodDiet_Foods_FoodID",
                table: "FoodDiet");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Foods_FoodID",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_OrderBags_OrderBagID",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetailBeverage_OrderDetail_OrderDetailID",
                table: "OrderDetailBeverage");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetailExtra_OrderDetail_OrderDetailID",
                table: "OrderDetailExtra");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetail",
                table: "OrderDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FoodDiet",
                table: "FoodDiet");

            migrationBuilder.RenameTable(
                name: "OrderDetail",
                newName: "OrderDetails");

            migrationBuilder.RenameTable(
                name: "FoodDiet",
                newName: "FoodDiets");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetail_OrderBagID",
                table: "OrderDetails",
                newName: "IX_OrderDetails_OrderBagID");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetail_FoodID",
                table: "OrderDetails",
                newName: "IX_OrderDetails_FoodID");

            migrationBuilder.RenameIndex(
                name: "IX_FoodDiet_FoodID",
                table: "FoodDiets",
                newName: "IX_FoodDiets_FoodID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FoodDiets",
                table: "FoodDiets",
                columns: new[] { "DietID", "FoodID" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9ffbe52c-b2a1-43e1-b4ce-733b4ce15383", "ced5120e-6878-49d7-9b67-1636166b639c" });

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 8, 16, 44, 14, 224, DateTimeKind.Local).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 8, 16, 44, 14, 224, DateTimeKind.Local).AddTicks(341));

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 8, 16, 44, 14, 224, DateTimeKind.Local).AddTicks(345));

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 8, 16, 44, 14, 224, DateTimeKind.Local).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 8, 16, 44, 14, 224, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 8, 16, 44, 14, 224, DateTimeKind.Local).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 8, 16, 44, 14, 224, DateTimeKind.Local).AddTicks(644));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 8, 16, 44, 14, 224, DateTimeKind.Local).AddTicks(646));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 8, 16, 44, 14, 224, DateTimeKind.Local).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 8, 16, 44, 14, 224, DateTimeKind.Local).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 8, 16, 44, 14, 224, DateTimeKind.Local).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 8, 16, 44, 14, 224, DateTimeKind.Local).AddTicks(1051));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 8, 16, 44, 14, 224, DateTimeKind.Local).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 8, 16, 44, 14, 224, DateTimeKind.Local).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 8, 16, 44, 14, 224, DateTimeKind.Local).AddTicks(1237));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 8, 16, 44, 14, 224, DateTimeKind.Local).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 8, 16, 44, 14, 224, DateTimeKind.Local).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 8, 16, 44, 14, 224, DateTimeKind.Local).AddTicks(8028));

            migrationBuilder.UpdateData(
                table: "OrderBags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 11, 8, 16, 44, 14, 224, DateTimeKind.Local).AddTicks(8178), new DateTime(2023, 11, 8, 16, 44, 14, 224, DateTimeKind.Local).AddTicks(8180) });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 8, 16, 44, 14, 225, DateTimeKind.Local).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 8, 16, 44, 14, 225, DateTimeKind.Local).AddTicks(1196));

            migrationBuilder.AddForeignKey(
                name: "FK_FoodDiets_Diets_DietID",
                table: "FoodDiets",
                column: "DietID",
                principalTable: "Diets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodDiets_Foods_FoodID",
                table: "FoodDiets",
                column: "FoodID",
                principalTable: "Foods",
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
                name: "FK_OrderDetailExtra_OrderDetails_OrderDetailID",
                table: "OrderDetailExtra",
                column: "OrderDetailID",
                principalTable: "OrderDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Foods_FoodID",
                table: "OrderDetails",
                column: "FoodID",
                principalTable: "Foods",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_OrderBags_OrderBagID",
                table: "OrderDetails",
                column: "OrderBagID",
                principalTable: "OrderBags",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodDiets_Diets_DietID",
                table: "FoodDiets");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodDiets_Foods_FoodID",
                table: "FoodDiets");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetailBeverage_OrderDetails_OrderDetailID",
                table: "OrderDetailBeverage");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetailExtra_OrderDetails_OrderDetailID",
                table: "OrderDetailExtra");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Foods_FoodID",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_OrderBags_OrderBagID",
                table: "OrderDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FoodDiets",
                table: "FoodDiets");

            migrationBuilder.RenameTable(
                name: "OrderDetails",
                newName: "OrderDetail");

            migrationBuilder.RenameTable(
                name: "FoodDiets",
                newName: "FoodDiet");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_OrderBagID",
                table: "OrderDetail",
                newName: "IX_OrderDetail_OrderBagID");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_FoodID",
                table: "OrderDetail",
                newName: "IX_OrderDetail_FoodID");

            migrationBuilder.RenameIndex(
                name: "IX_FoodDiets_FoodID",
                table: "FoodDiet",
                newName: "IX_FoodDiet_FoodID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetail",
                table: "OrderDetail",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FoodDiet",
                table: "FoodDiet",
                columns: new[] { "DietID", "FoodID" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ffef5d79-be3d-4a53-9b41-9de16e171f1b", "526661c0-2615-4532-bb9d-f32fa79dbc16" });

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 11, 22, 53, 132, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 11, 22, 53, 132, DateTimeKind.Local).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 11, 22, 53, 132, DateTimeKind.Local).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 11, 22, 53, 132, DateTimeKind.Local).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 11, 22, 53, 132, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 11, 22, 53, 132, DateTimeKind.Local).AddTicks(4777));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 11, 22, 53, 132, DateTimeKind.Local).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 11, 22, 53, 132, DateTimeKind.Local).AddTicks(4782));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 11, 22, 53, 132, DateTimeKind.Local).AddTicks(4932));

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 11, 22, 53, 132, DateTimeKind.Local).AddTicks(5064));

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 11, 22, 53, 132, DateTimeKind.Local).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 11, 22, 53, 132, DateTimeKind.Local).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 11, 22, 53, 132, DateTimeKind.Local).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 11, 22, 53, 132, DateTimeKind.Local).AddTicks(5406));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 11, 22, 53, 132, DateTimeKind.Local).AddTicks(5414));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 11, 22, 53, 132, DateTimeKind.Local).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 11, 22, 53, 132, DateTimeKind.Local).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 11, 22, 53, 132, DateTimeKind.Local).AddTicks(7851));

            migrationBuilder.UpdateData(
                table: "OrderBags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 11, 7, 11, 22, 53, 132, DateTimeKind.Local).AddTicks(7988), new DateTime(2023, 11, 7, 11, 22, 53, 132, DateTimeKind.Local).AddTicks(7989) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 11, 22, 53, 133, DateTimeKind.Local).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 11, 22, 53, 133, DateTimeKind.Local).AddTicks(1073));

            migrationBuilder.AddForeignKey(
                name: "FK_FoodDiet_Diets_DietID",
                table: "FoodDiet",
                column: "DietID",
                principalTable: "Diets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodDiet_Foods_FoodID",
                table: "FoodDiet",
                column: "FoodID",
                principalTable: "Foods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Foods_FoodID",
                table: "OrderDetail",
                column: "FoodID",
                principalTable: "Foods",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_OrderBags_OrderBagID",
                table: "OrderDetail",
                column: "OrderBagID",
                principalTable: "OrderBags",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetailBeverage_OrderDetail_OrderDetailID",
                table: "OrderDetailBeverage",
                column: "OrderDetailID",
                principalTable: "OrderDetail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetailExtra_OrderDetail_OrderDetailID",
                table: "OrderDetailExtra",
                column: "OrderDetailID",
                principalTable: "OrderDetail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
