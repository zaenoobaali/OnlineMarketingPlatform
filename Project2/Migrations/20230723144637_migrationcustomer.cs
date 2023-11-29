using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project2.Migrations
{
    public partial class migrationcustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "zone",
                table: "Popularizations",
                newName: "targetzone");

            migrationBuilder.AddColumn<string>(
                name: "targetGender",
                table: "Popularizations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "age",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "gender",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "age", "gender" },
                values: new object[] { new DateTime(2023, 7, 23, 17, 46, 36, 1, DateTimeKind.Local).AddTicks(237), 23, "F" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "age", "gender" },
                values: new object[] { new DateTime(2023, 7, 23, 17, 46, 36, 1, DateTimeKind.Local).AddTicks(364), 21, "F" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "age", "gender" },
                values: new object[] { new DateTime(2023, 7, 23, 17, 46, 36, 1, DateTimeKind.Local).AddTicks(403), 16, "M" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "age", "gender" },
                values: new object[] { new DateTime(2023, 7, 23, 17, 46, 36, 1, DateTimeKind.Local).AddTicks(464), 15, "F" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "age", "gender" },
                values: new object[] { new DateTime(2023, 7, 23, 17, 46, 36, 1, DateTimeKind.Local).AddTicks(625), 13, "F" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "age", "gender" },
                values: new object[] { new DateTime(2023, 7, 23, 17, 46, 36, 1, DateTimeKind.Local).AddTicks(673), 49, "F" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "age", "gender" },
                values: new object[] { new DateTime(2023, 7, 23, 17, 46, 36, 1, DateTimeKind.Local).AddTicks(707), 61, "M" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "age", "gender" },
                values: new object[] { new DateTime(2023, 7, 23, 17, 46, 36, 1, DateTimeKind.Local).AddTicks(821), 53, "F" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "age", "gender" },
                values: new object[] { new DateTime(2023, 7, 23, 17, 46, 36, 1, DateTimeKind.Local).AddTicks(858), 25, "F" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "age", "gender" },
                values: new object[] { new DateTime(2023, 7, 23, 17, 46, 36, 1, DateTimeKind.Local).AddTicks(890), 26, "M" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "age", "gender" },
                values: new object[] { new DateTime(2023, 7, 23, 17, 46, 36, 1, DateTimeKind.Local).AddTicks(921), 25, "F" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "age", "gender" },
                values: new object[] { new DateTime(2023, 7, 23, 17, 46, 36, 1, DateTimeKind.Local).AddTicks(954), 59, "M" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "age", "gender" },
                values: new object[] { new DateTime(2023, 7, 23, 17, 46, 36, 1, DateTimeKind.Local).AddTicks(987), 48, "F" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "age", "gender" },
                values: new object[] { new DateTime(2023, 7, 23, 17, 46, 36, 1, DateTimeKind.Local).AddTicks(1153), 49, "F" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "age", "gender" },
                values: new object[] { new DateTime(2023, 7, 23, 17, 46, 36, 1, DateTimeKind.Local).AddTicks(1353), 24, "F" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "age", "gender" },
                values: new object[] { new DateTime(2023, 7, 23, 17, 46, 36, 1, DateTimeKind.Local).AddTicks(1455), 23, "F" });

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 23, 17, 46, 36, 1, DateTimeKind.Local).AddTicks(1629));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 23, 17, 46, 36, 1, DateTimeKind.Local).AddTicks(1640));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 23, 17, 46, 36, 1, DateTimeKind.Local).AddTicks(1536));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 23, 17, 46, 36, 1, DateTimeKind.Local).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 23, 17, 46, 36, 1, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 23, 17, 46, 36, 1, DateTimeKind.Local).AddTicks(1568));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 23, 17, 46, 36, 1, DateTimeKind.Local).AddTicks(1577));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 11,
                column: "password",
                value: "D9zHvRqVM7JiH5it+rdvmyMN/+ns9N4cya9E3sWeLsQ=");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "targetGender",
                table: "Popularizations");

            migrationBuilder.DropColumn(
                name: "age",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "gender",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "targetzone",
                table: "Popularizations",
                newName: "zone");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 20, 13, 9, 19, 496, DateTimeKind.Local).AddTicks(9792));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 20, 13, 9, 19, 496, DateTimeKind.Local).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 20, 13, 9, 19, 496, DateTimeKind.Local).AddTicks(9942));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 20, 13, 9, 19, 497, DateTimeKind.Local).AddTicks(64));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 20, 13, 9, 19, 497, DateTimeKind.Local).AddTicks(96));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 20, 13, 9, 19, 497, DateTimeKind.Local).AddTicks(138));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 20, 13, 9, 19, 497, DateTimeKind.Local).AddTicks(177));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 20, 13, 9, 19, 497, DateTimeKind.Local).AddTicks(200));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 20, 13, 9, 19, 497, DateTimeKind.Local).AddTicks(223));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 20, 13, 9, 19, 497, DateTimeKind.Local).AddTicks(389));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 20, 13, 9, 19, 497, DateTimeKind.Local).AddTicks(436));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 20, 13, 9, 19, 497, DateTimeKind.Local).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 20, 13, 9, 19, 497, DateTimeKind.Local).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 20, 13, 9, 19, 497, DateTimeKind.Local).AddTicks(512));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 20, 13, 9, 19, 497, DateTimeKind.Local).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 20, 13, 9, 19, 497, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 20, 13, 9, 19, 497, DateTimeKind.Local).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 20, 13, 9, 19, 497, DateTimeKind.Local).AddTicks(937));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 20, 13, 9, 19, 497, DateTimeKind.Local).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 20, 13, 9, 19, 497, DateTimeKind.Local).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 20, 13, 9, 19, 497, DateTimeKind.Local).AddTicks(841));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 20, 13, 9, 19, 497, DateTimeKind.Local).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 20, 13, 9, 19, 497, DateTimeKind.Local).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 11,
                column: "password",
                value: "lDBAMHP4cxj2NeZdVLwwT6GKn6mgGmnRkoftWQYRHtA=");
        }
    }
}
