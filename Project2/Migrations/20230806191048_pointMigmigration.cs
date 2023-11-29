using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project2.Migrations
{
    public partial class pointMigmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Point" },
                values: new object[] { new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(4948), 200 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Point" },
                values: new object[] { new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(5213), 230 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Point" },
                values: new object[] { new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(5268), 398 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Point" },
                values: new object[] { new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(5329), 100 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Point" },
                values: new object[] { new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(5402), 100 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Point" },
                values: new object[] { new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(5459), 300 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Point" },
                values: new object[] { new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(5499), 500 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Point" },
                values: new object[] { new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(5628), 346 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Point" },
                values: new object[] { new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(5738), 100 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Point" },
                values: new object[] { new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(5775), 100 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Point" },
                values: new object[] { new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(5812), 100 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Point" },
                values: new object[] { new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(5852), 900 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Point" },
                values: new object[] { new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(5890), 230 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Point" },
                values: new object[] { new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(5928), 240 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Point" },
                values: new object[] { new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6134), 300 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Point" },
                values: new object[] { new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6262), 300 });

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Point" },
                values: new object[] { new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6350), 200000 });

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Point" },
                values: new object[] { new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6365), 200000 });

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Point" },
                values: new object[] { new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6374), 200000 });

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Point" },
                values: new object[] { new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6385), 200000 });

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Point" },
                values: new object[] { new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6395), 200000 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(7066));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(7108));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(7164));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6621));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6642));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6757));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Point" },
                values: new object[] { new DateTime(2023, 8, 6, 19, 25, 33, 818, DateTimeKind.Local).AddTicks(9878), 0 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Point" },
                values: new object[] { new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(108), 0 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Point" },
                values: new object[] { new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(175), 0 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Point" },
                values: new object[] { new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(247), 0 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Point" },
                values: new object[] { new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(337), 0 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Point" },
                values: new object[] { new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(393), 0 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Point" },
                values: new object[] { new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(437), 0 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Point" },
                values: new object[] { new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(565), 0 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Point" },
                values: new object[] { new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(614), 0 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Point" },
                values: new object[] { new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(658), 0 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Point" },
                values: new object[] { new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(697), 0 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Point" },
                values: new object[] { new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(736), 0 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Point" },
                values: new object[] { new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(772), 0 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Point" },
                values: new object[] { new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(808), 0 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Point" },
                values: new object[] { new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(1000), 0 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Point" },
                values: new object[] { new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(1139), 0 });

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(1377));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(1389));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Point" },
                values: new object[] { new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(1258), 0 });

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Point" },
                values: new object[] { new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(1276), 0 });

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Point" },
                values: new object[] { new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(1288), 0 });

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Point" },
                values: new object[] { new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(1299), 0 });

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Point" },
                values: new object[] { new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(1310), 0 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(1990));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(2005));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(2022));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(2038));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(2053));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(2067));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(2075));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(2090));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(2106));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(2113));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(2127));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(2134));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(2142));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(2149));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(1531));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(1546));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(1554));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(1569));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(1576));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(1583));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(1591));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(1599));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(1606));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(1614));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(1621));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(1628));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(1636));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(1650));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(1665));
        }
    }
}
