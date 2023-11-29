using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project2.Migrations
{
    public partial class ihatemigrationbill : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Billfold",
                table: "Users",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(959));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(1143));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(1497));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(1906));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(2011));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(2077));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(2131));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(2563));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(2777));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(2828));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(3107));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(3487));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(3506));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(3379));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(3407));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(4432));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(4479));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(4489));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(4498));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(4507));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(4581));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(3757));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(3779));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(3809));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(3818));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(3828));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(3855));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(3873));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(3996));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 23, 53, 484, DateTimeKind.Local).AddTicks(4016));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Billfold",
                table: "Users",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(5848));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(6029));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(6271));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(6323));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(6376));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(6426));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(6478));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(7137));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(6969));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(7014));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(7807));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(7845));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(7855));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(7864));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(7873));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(7883));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(7911));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(7960));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(7980));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(7999));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(8009));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(8018));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(8027));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(7269));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(7287));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(7296));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(7305));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(7369));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(7378));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(7394));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(7403));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(7414));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(7425));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(7435));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 22, 19, 53, 203, DateTimeKind.Local).AddTicks(7465));
        }
    }
}
