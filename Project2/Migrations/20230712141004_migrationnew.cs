using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project2.Migrations
{
    public partial class migrationnew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderBags_Orders_OrderId",
                table: "OrderBags");

            migrationBuilder.DropColumn(
                name: "IdOrder",
                table: "OrderBags");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "OrderBags",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 17, 10, 2, 597, DateTimeKind.Local).AddTicks(637));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 17, 10, 2, 597, DateTimeKind.Local).AddTicks(733));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 17, 10, 2, 597, DateTimeKind.Local).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 17, 10, 2, 597, DateTimeKind.Local).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 17, 10, 2, 597, DateTimeKind.Local).AddTicks(895));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 17, 10, 2, 597, DateTimeKind.Local).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 17, 10, 2, 597, DateTimeKind.Local).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 17, 10, 2, 597, DateTimeKind.Local).AddTicks(1012));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 17, 10, 2, 597, DateTimeKind.Local).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 17, 10, 2, 597, DateTimeKind.Local).AddTicks(1114));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 17, 10, 2, 597, DateTimeKind.Local).AddTicks(1151));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 17, 10, 2, 597, DateTimeKind.Local).AddTicks(1178));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 17, 10, 2, 597, DateTimeKind.Local).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 17, 10, 2, 597, DateTimeKind.Local).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 17, 10, 2, 597, DateTimeKind.Local).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 17, 10, 2, 597, DateTimeKind.Local).AddTicks(1364));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 17, 10, 2, 597, DateTimeKind.Local).AddTicks(1625));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 17, 10, 2, 597, DateTimeKind.Local).AddTicks(1637));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 17, 10, 2, 597, DateTimeKind.Local).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 17, 10, 2, 597, DateTimeKind.Local).AddTicks(1529));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 17, 10, 2, 597, DateTimeKind.Local).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 17, 10, 2, 597, DateTimeKind.Local).AddTicks(1554));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 17, 10, 2, 597, DateTimeKind.Local).AddTicks(1566));

            migrationBuilder.AddForeignKey(
                name: "FK_OrderBags_Orders_OrderId",
                table: "OrderBags",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderBags_Orders_OrderId",
                table: "OrderBags");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "OrderBags",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "IdOrder",
                table: "OrderBags",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 0, 18, 52, 705, DateTimeKind.Local).AddTicks(6575));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 0, 18, 52, 705, DateTimeKind.Local).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 0, 18, 52, 705, DateTimeKind.Local).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 0, 18, 52, 705, DateTimeKind.Local).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 0, 18, 52, 705, DateTimeKind.Local).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 0, 18, 52, 705, DateTimeKind.Local).AddTicks(7095));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 0, 18, 52, 705, DateTimeKind.Local).AddTicks(7133));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 0, 18, 52, 705, DateTimeKind.Local).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 0, 18, 52, 705, DateTimeKind.Local).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 0, 18, 52, 705, DateTimeKind.Local).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 0, 18, 52, 705, DateTimeKind.Local).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 0, 18, 52, 705, DateTimeKind.Local).AddTicks(7296));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 0, 18, 52, 705, DateTimeKind.Local).AddTicks(7321));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 0, 18, 52, 705, DateTimeKind.Local).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 0, 18, 52, 705, DateTimeKind.Local).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 0, 18, 52, 705, DateTimeKind.Local).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 0, 18, 52, 705, DateTimeKind.Local).AddTicks(7656));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 0, 18, 52, 705, DateTimeKind.Local).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 0, 18, 52, 705, DateTimeKind.Local).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 0, 18, 52, 705, DateTimeKind.Local).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 0, 18, 52, 705, DateTimeKind.Local).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 0, 18, 52, 705, DateTimeKind.Local).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 0, 18, 52, 705, DateTimeKind.Local).AddTicks(7606));

            migrationBuilder.AddForeignKey(
                name: "FK_OrderBags_Orders_OrderId",
                table: "OrderBags",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");
        }
    }
}
