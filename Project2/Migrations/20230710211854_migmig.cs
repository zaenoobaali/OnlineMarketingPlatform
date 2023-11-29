using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project2.Migrations
{
    public partial class migmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MarketerId",
                table: "CustPosts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductOrderId",
                table: "CustPosts",
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

            migrationBuilder.CreateIndex(
                name: "IX_CustPosts_MarketerId",
                table: "CustPosts",
                column: "MarketerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustPosts_ProductOrderId",
                table: "CustPosts",
                column: "ProductOrderId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Customers_MarketerId",
            //    table: "Customers",
            //    column: "MarketerId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustPosts_Marketers_MarketerId",
                table: "CustPosts",
                column: "MarketerId",
                principalTable: "Marketers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CustPosts_ProductOrders_ProductOrderId",
                table: "CustPosts",
                column: "ProductOrderId",
                principalTable: "ProductOrders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustPosts_Marketers_MarketerId",
                table: "CustPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_CustPosts_ProductOrders_ProductOrderId",
                table: "CustPosts");

            migrationBuilder.DropIndex(
                name: "IX_CustPosts_MarketerId",
                table: "CustPosts");

            migrationBuilder.DropIndex(
                name: "IX_CustPosts_ProductOrderId",
                table: "CustPosts");

            migrationBuilder.DropIndex(
                name: "IX_Customers_MarketerId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "MarketerId",
                table: "CustPosts");

            migrationBuilder.DropColumn(
                name: "ProductOrderId",
                table: "CustPosts");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 23, 45, 0, 454, DateTimeKind.Local).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 23, 45, 0, 454, DateTimeKind.Local).AddTicks(8946));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 23, 45, 0, 454, DateTimeKind.Local).AddTicks(8972));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 23, 45, 0, 454, DateTimeKind.Local).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 23, 45, 0, 454, DateTimeKind.Local).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 23, 45, 0, 454, DateTimeKind.Local).AddTicks(9469));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 23, 45, 0, 454, DateTimeKind.Local).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 23, 45, 0, 454, DateTimeKind.Local).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 23, 45, 0, 454, DateTimeKind.Local).AddTicks(9587));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 23, 45, 0, 454, DateTimeKind.Local).AddTicks(9677));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 23, 45, 0, 454, DateTimeKind.Local).AddTicks(9724));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 23, 45, 0, 454, DateTimeKind.Local).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 23, 45, 0, 454, DateTimeKind.Local).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 23, 45, 0, 454, DateTimeKind.Local).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 23, 45, 0, 454, DateTimeKind.Local).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 23, 45, 0, 454, DateTimeKind.Local).AddTicks(9944));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 23, 45, 0, 455, DateTimeKind.Local).AddTicks(283));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 23, 45, 0, 455, DateTimeKind.Local).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 23, 45, 0, 455, DateTimeKind.Local).AddTicks(166));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 23, 45, 0, 455, DateTimeKind.Local).AddTicks(189));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 23, 45, 0, 455, DateTimeKind.Local).AddTicks(201));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 23, 45, 0, 455, DateTimeKind.Local).AddTicks(213));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 23, 45, 0, 455, DateTimeKind.Local).AddTicks(225));
        }
    }
}
