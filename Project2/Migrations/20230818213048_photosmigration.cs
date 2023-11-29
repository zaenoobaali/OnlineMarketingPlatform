using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project2.Migrations
{
    public partial class photosmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(170), "https://media.istockphoto.com/id/1363312796/photo/blue-hydrangea-background.webp?s=1024x1024&w=is&k=20&c=EEPfUAN5JhvnvjKV1vza_Tq2i-Oicya4joqZCAkgTQA=" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(299), "https://images.unsplash.com/photo-1519181245277-cffeb31da2e3?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=870&q=80" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(343), "https://plus.unsplash.com/premium_photo-1677916317230-d9b78d675264?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=388&q=80" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(807), "https://images.unsplash.com/photo-1530533718754-001d2668365a?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=870&q=80" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(889), "https://images.unsplash.com/photo-1571149828506-c48f1610314b?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=870&q=80" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(940), "https://images.unsplash.com/photo-1436891620584-47fd0e565afb?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=387&q=80" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(975), "https://images.unsplash.com/photo-1682686580036-b5e25932ce9a?ixlib=rb-4.0.3&ixid=M3wxMjA3fDF8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=775&q=80" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(1080), "https://images.unsplash.com/photo-1683357974024-373448bbf733?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=387&q=80" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(1119), "https://images.unsplash.com/photo-1528697203043-733dafdaa316?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=812&q=80" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(1154), "https://images.unsplash.com/photo-1688560722687-7d4d5fb8ff8f?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=870&q=80" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(1188), "https://images.unsplash.com/photo-1688728489565-8c155cf71c64?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=464&q=80" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(1222), "https://images.unsplash.com/photo-1691764548951-c3fdcf90544a?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=387&q=80" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(1257), "https://images.unsplash.com/photo-1493612276216-ee3925520721?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=464&q=80" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(1291), "https://images.unsplash.com/photo-1688728459248-c8dcc2c4f33b?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=387&q=80" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(1482), "https://images.unsplash.com/photo-1582769923195-c6e60dc1d8dc?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=464&q=80" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(1600), "https://images.unsplash.com/photo-1483412033650-1015ddeb83d1?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=873&q=80" });

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(1899));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(1911));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(1695));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(1709));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(1839), "https://drive.google.com/file/d/13Gu6ybou3APw9Ws6afBo_C-Hu8fq_kin/view?usp=drivesdk" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(2563));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(2579));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(2591));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(2598));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(2605));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(2611));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(2617));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(2624));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(2631));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(2638));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(2657));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(2663));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(2671));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(2677));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(2788));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(2795));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(2057));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(2064));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(2072));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(2080));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(2093));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(2099));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(2105));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(2113));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(2126));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(2139));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(2146));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(2153));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(2175));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(2182));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(2190));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(830), "" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(963), "" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(1011), "" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(1068), "" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(1228), "" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(1281), "" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(1319), "" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(1433), "" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(1476), "" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(1517), "" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(1557), "" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(1597), "" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(1635), "" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(1674), "" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(1867), "" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(1969), "" });

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2187));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2199));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2095));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2107), "https://scontent-sea1-1.xx.fbcdn.net/v/t39.30808-6/286066775_317831530564572_3718556029484236078_n.jpg?_nc_cat=103&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=rvbSrrgL2EIAX-JqFfS&_nc_ht=scontent-sea1-1.xx&oh=00_AfDYQbnEilFXn2G9GDAgSLLLOsr3daBH5hU0o3UNA9zzEw&oe=64CEE28E" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2781));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2788));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2803));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2810));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2825));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2833));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2840));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2847));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2853));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2860));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2892));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2899));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2913));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2362));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2369));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2377));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2384));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2391));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2405));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2425));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2439));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2447));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2454));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2462));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 21, 56, 31, 6, DateTimeKind.Local).AddTicks(2468));
        }
    }
}
