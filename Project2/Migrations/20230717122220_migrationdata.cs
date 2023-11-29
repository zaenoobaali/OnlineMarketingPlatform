using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project2.Migrations
{
    public partial class migrationdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ResetCode",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ResetPassToken",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "productType",
                table: "ProductOrders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "reactioncounter",
                table: "CustPosts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 17, 15, 22, 18, 769, DateTimeKind.Local).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 17, 15, 22, 18, 769, DateTimeKind.Local).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 17, 15, 22, 18, 769, DateTimeKind.Local).AddTicks(7013));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 17, 15, 22, 18, 769, DateTimeKind.Local).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 17, 15, 22, 18, 769, DateTimeKind.Local).AddTicks(7179));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 17, 15, 22, 18, 769, DateTimeKind.Local).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 17, 15, 22, 18, 769, DateTimeKind.Local).AddTicks(7269));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 17, 15, 22, 18, 769, DateTimeKind.Local).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 17, 15, 22, 18, 769, DateTimeKind.Local).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 17, 15, 22, 18, 769, DateTimeKind.Local).AddTicks(7733));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 17, 15, 22, 18, 769, DateTimeKind.Local).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 17, 15, 22, 18, 769, DateTimeKind.Local).AddTicks(7797));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 17, 15, 22, 18, 769, DateTimeKind.Local).AddTicks(7823));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 17, 15, 22, 18, 769, DateTimeKind.Local).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 17, 15, 22, 18, 769, DateTimeKind.Local).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 17, 15, 22, 18, 769, DateTimeKind.Local).AddTicks(7999));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 17, 15, 22, 18, 769, DateTimeKind.Local).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 17, 15, 22, 18, 769, DateTimeKind.Local).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 17, 15, 22, 18, 769, DateTimeKind.Local).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 17, 15, 22, 18, 769, DateTimeKind.Local).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 17, 15, 22, 18, 769, DateTimeKind.Local).AddTicks(8126));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 17, 15, 22, 18, 769, DateTimeKind.Local).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 17, 15, 22, 18, 769, DateTimeKind.Local).AddTicks(8147));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResetCode",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ResetPassToken",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "productType",
                table: "ProductOrders");

            migrationBuilder.DropColumn(
                name: "reactioncounter",
                table: "CustPosts");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 16, 19, 14, 42, 649, DateTimeKind.Local).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 16, 19, 14, 42, 649, DateTimeKind.Local).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 16, 19, 14, 42, 649, DateTimeKind.Local).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 16, 19, 14, 42, 649, DateTimeKind.Local).AddTicks(4221));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 16, 19, 14, 42, 649, DateTimeKind.Local).AddTicks(4251));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 16, 19, 14, 42, 649, DateTimeKind.Local).AddTicks(4291));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 16, 19, 14, 42, 649, DateTimeKind.Local).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 16, 19, 14, 42, 649, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 16, 19, 14, 42, 649, DateTimeKind.Local).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 16, 19, 14, 42, 649, DateTimeKind.Local).AddTicks(4484));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 16, 19, 14, 42, 649, DateTimeKind.Local).AddTicks(4523));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 16, 19, 14, 42, 649, DateTimeKind.Local).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 16, 19, 14, 42, 649, DateTimeKind.Local).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 16, 19, 14, 42, 649, DateTimeKind.Local).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 16, 19, 14, 42, 649, DateTimeKind.Local).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 16, 19, 14, 42, 649, DateTimeKind.Local).AddTicks(4718));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 16, 19, 14, 42, 649, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 16, 19, 14, 42, 649, DateTimeKind.Local).AddTicks(5142));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 16, 19, 14, 42, 649, DateTimeKind.Local).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 16, 19, 14, 42, 649, DateTimeKind.Local).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 16, 19, 14, 42, 649, DateTimeKind.Local).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 16, 19, 14, 42, 649, DateTimeKind.Local).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 16, 19, 14, 42, 649, DateTimeKind.Local).AddTicks(5066));
        }
    }
}
