using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project2.Migrations
{
    public partial class migration_posts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "status",
                table: "CustPosts",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "status",
                table: "CustPosts");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 16, 0, 11, 33, 738, DateTimeKind.Local).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 16, 0, 11, 33, 738, DateTimeKind.Local).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 16, 0, 11, 33, 738, DateTimeKind.Local).AddTicks(8127));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 16, 0, 11, 33, 738, DateTimeKind.Local).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 16, 0, 11, 33, 738, DateTimeKind.Local).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 16, 0, 11, 33, 738, DateTimeKind.Local).AddTicks(8305));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 16, 0, 11, 33, 738, DateTimeKind.Local).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 16, 0, 11, 33, 738, DateTimeKind.Local).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 16, 0, 11, 33, 738, DateTimeKind.Local).AddTicks(8388));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 16, 0, 11, 33, 738, DateTimeKind.Local).AddTicks(8519));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 16, 0, 11, 33, 738, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 16, 0, 11, 33, 738, DateTimeKind.Local).AddTicks(8574));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 16, 0, 11, 33, 738, DateTimeKind.Local).AddTicks(8594));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 16, 0, 11, 33, 738, DateTimeKind.Local).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 16, 0, 11, 33, 738, DateTimeKind.Local).AddTicks(8681));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 16, 0, 11, 33, 738, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 16, 0, 11, 33, 738, DateTimeKind.Local).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 16, 0, 11, 33, 738, DateTimeKind.Local).AddTicks(9153));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 16, 0, 11, 33, 738, DateTimeKind.Local).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 16, 0, 11, 33, 738, DateTimeKind.Local).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 16, 0, 11, 33, 738, DateTimeKind.Local).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 16, 0, 11, 33, 738, DateTimeKind.Local).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 16, 0, 11, 33, 738, DateTimeKind.Local).AddTicks(9087));
        }
    }
}
