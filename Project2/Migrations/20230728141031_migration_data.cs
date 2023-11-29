using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project2.Migrations
{
    public partial class migration_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 28, 17, 10, 29, 730, DateTimeKind.Local).AddTicks(1105));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 28, 17, 10, 29, 730, DateTimeKind.Local).AddTicks(1392));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 28, 17, 10, 29, 730, DateTimeKind.Local).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 28, 17, 10, 29, 730, DateTimeKind.Local).AddTicks(1790));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Birthdate", "CreatedDate" },
                values: new object[] { new DateTime(2009, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 28, 17, 10, 29, 730, DateTimeKind.Local).AddTicks(1878) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 28, 17, 10, 29, 730, DateTimeKind.Local).AddTicks(1959));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 28, 17, 10, 29, 730, DateTimeKind.Local).AddTicks(1999));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 28, 17, 10, 29, 730, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 28, 17, 10, 29, 730, DateTimeKind.Local).AddTicks(2179));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 28, 17, 10, 29, 730, DateTimeKind.Local).AddTicks(2224));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 28, 17, 10, 29, 730, DateTimeKind.Local).AddTicks(2266));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 28, 17, 10, 29, 730, DateTimeKind.Local).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 28, 17, 10, 29, 730, DateTimeKind.Local).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 28, 17, 10, 29, 730, DateTimeKind.Local).AddTicks(2388));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 28, 17, 10, 29, 730, DateTimeKind.Local).AddTicks(2601));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 28, 17, 10, 29, 730, DateTimeKind.Local).AddTicks(2741));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 28, 17, 10, 29, 730, DateTimeKind.Local).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 28, 17, 10, 29, 730, DateTimeKind.Local).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 28, 17, 10, 29, 730, DateTimeKind.Local).AddTicks(2852));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 28, 17, 10, 29, 730, DateTimeKind.Local).AddTicks(2868));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 28, 17, 10, 29, 730, DateTimeKind.Local).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 28, 17, 10, 29, 730, DateTimeKind.Local).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 28, 17, 10, 29, 730, DateTimeKind.Local).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 11,
                columns: new[] { "Email", "password" },
                values: new object[] { "majdesber@gmail.com", "Xzfs+OTKsXMbhz1YMFLLFG2hlSLd4lgUbx97XivSIkU=" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UID", "Email", "Name", "ResetCode", "ResetPassToken", "UserName", "password", "status", "userType" },
                values: new object[,]
                {
                    { 25, "maintainer1@gmail.com", "Ahmad Mohseen", null, null, "ahmadmohseen", "kr80L+XPknGxQAW8q2GCGqlOA9GTJlfUj8OVHn9xgao=", 0, 4 },
                    { 26, "maintainer2@gmail.com", "Fares Monzer", null, null, "faresmonzer", "aPrypnu3HC1gDXJ6K2L8Jr5CeFG61zqe8wGbte2Yv4M=", 0, 4 },
                    { 27, "maintainer3@gmail.com", "Kais Salem", null, null, "kaissalem", "blXTXWpe+6B2bMMXOXZe9kmjjyE0IrvNCwCFIU9JEuA=", 0, 4 },
                    { 28, "maintainer4@gmail.com", "Mohanad Mahmood", null, null, "mohanadmahmood", "4GqMsBpT7hRiMZGcsTxE9a4aJ2VYiORHgOR2EXx17Qk=", 0, 4 }
                });

            migrationBuilder.InsertData(
                table: "Maintainers",
                columns: new[] { "Id", "FName", "LName", "RoleId", "UserName", "userId" },
                values: new object[,]
                {
                    { 1, "Ahmad", "Mohseen", 1, "ahmadmohseen", 25 },
                    { 2, "Fares", "Monzer", 2, "faresmonzer", 26 },
                    { 3, "Kais", "Salem", 3, "kaissalem", 27 },
                    { 4, "Mohanad", "Mahmood", 4, "mohanadmahmood", 28 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Maintainers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Maintainers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Maintainers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Maintainers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 28);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 23, 17, 46, 36, 1, DateTimeKind.Local).AddTicks(237));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 23, 17, 46, 36, 1, DateTimeKind.Local).AddTicks(364));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 23, 17, 46, 36, 1, DateTimeKind.Local).AddTicks(403));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 23, 17, 46, 36, 1, DateTimeKind.Local).AddTicks(464));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Birthdate", "CreatedDate" },
                values: new object[] { new DateTime(2009, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 23, 17, 46, 36, 1, DateTimeKind.Local).AddTicks(625) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 23, 17, 46, 36, 1, DateTimeKind.Local).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 23, 17, 46, 36, 1, DateTimeKind.Local).AddTicks(707));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 23, 17, 46, 36, 1, DateTimeKind.Local).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 23, 17, 46, 36, 1, DateTimeKind.Local).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 23, 17, 46, 36, 1, DateTimeKind.Local).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 23, 17, 46, 36, 1, DateTimeKind.Local).AddTicks(921));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 23, 17, 46, 36, 1, DateTimeKind.Local).AddTicks(954));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 23, 17, 46, 36, 1, DateTimeKind.Local).AddTicks(987));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 23, 17, 46, 36, 1, DateTimeKind.Local).AddTicks(1153));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 23, 17, 46, 36, 1, DateTimeKind.Local).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 23, 17, 46, 36, 1, DateTimeKind.Local).AddTicks(1455));

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
                columns: new[] { "Email", "password" },
                values: new object[] { "magdesber@gmail.com", "D9zHvRqVM7JiH5it+rdvmyMN/+ns9N4cya9E3sWeLsQ=" });
        }
    }
}
