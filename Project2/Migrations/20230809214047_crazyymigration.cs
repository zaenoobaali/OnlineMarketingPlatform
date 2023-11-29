using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project2.Migrations
{
    public partial class crazyymigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "gender" },
                values: new object[] { new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(1742), "Female" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "gender" },
                values: new object[] { new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(1870), "Female" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "gender" },
                values: new object[] { new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(1915), "Male" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "gender" },
                values: new object[] { new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(1969), "Female" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "gender" },
                values: new object[] { new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(2106), "Female" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "gender" },
                values: new object[] { new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(2157), "Female" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "gender" },
                values: new object[] { new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(2194), "Male" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "gender" },
                values: new object[] { new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(2311), "Female" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "gender" },
                values: new object[] { new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(2350), "Female" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "gender" },
                values: new object[] { new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(2385), "Male" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "gender" },
                values: new object[] { new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(2422), "Female" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "gender" },
                values: new object[] { new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(2457), "Male" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "gender" },
                values: new object[] { new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(2495), "Female" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "gender" },
                values: new object[] { new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(2533), "Female" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "gender" },
                values: new object[] { new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(2715), "Female" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "gender" },
                values: new object[] { new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(2835), "Female" });

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(3043));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(2929));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(2945));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(2956));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(2966));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(2976));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(3684));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(3692));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(3707));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(3724));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(3732));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(3762));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(3776));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(3812));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(3163));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(3175));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(3183));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(3191));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(3199));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(3207));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(3216));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(3224));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(3232));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(3262));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 10, 0, 40, 45, 128, DateTimeKind.Local).AddTicks(3322));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "gender" },
                values: new object[] { new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(5878), "F" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "gender" },
                values: new object[] { new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(6013), "F" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "gender" },
                values: new object[] { new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(6139), "M" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "gender" },
                values: new object[] { new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(6267), "F" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "gender" },
                values: new object[] { new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(6344), "F" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "gender" },
                values: new object[] { new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(6407), "F" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "gender" },
                values: new object[] { new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(6453), "M" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "gender" },
                values: new object[] { new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(6590), "F" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "gender" },
                values: new object[] { new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(6638), "F" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "gender" },
                values: new object[] { new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(6679), "M" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "gender" },
                values: new object[] { new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(6722), "F" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "gender" },
                values: new object[] { new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(6768), "M" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "gender" },
                values: new object[] { new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(6809), "F" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "gender" },
                values: new object[] { new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(6940), "F" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "gender" },
                values: new object[] { new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(7141), "F" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "gender" },
                values: new object[] { new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(7271), "F" });

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(7489));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(7503));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(7373));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(7385));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(7429));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(8118));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(8151));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(8194));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(8294));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(7632));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(7653));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(7685));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(7701));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(7710));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(7753));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(7794));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 25, 54, 936, DateTimeKind.Local).AddTicks(7802));
        }
    }
}
