using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project2.Migrations
{
    public partial class migratphotos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(5596));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(5883));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(5963));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(6038));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(6453));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(6492));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(6619));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(6811));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(7030), "https://d1yjjnpx0p53s8.cloudfront.net/styles/logo-thumbnail/s3/072011/four_hundred.png?itok=2vTbTRms" });

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(7052), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSYzjEqiqABoKEHwf3djup6cR_9GsRo32Io7X1Kn6cyvQ&s" });

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(7061), "https://upload.wikimedia.org/wikipedia/commons/thumb/2/28/Diadora_logo.png/1200px-Diadora_logo.png" });

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(7069), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRkrCI_2KyBPWDQBPxbnM2Lth9rdH9KJgzod8jmqucRn7gApPIKSU8jsOrGyrzrNbbCtCI&usqp=CAU" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(8055));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(8066));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(8114));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(8125));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(8162));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(8167));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(7614), "https://media.istockphoto.com/id/1419697140/photo/sleeveless-cute-shirt-isolated-on-white-background.jpg?s=1024x1024&w=is&k=20&c=-NML3t1Fi34_h4AI6AUOo25s8ScIBvdQF1WH9GA_X9w=" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(7632), "https://images.unsplash.com/photo-1614786269829-d24616faf56d?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=435&q=80" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(7637), "https://images.unsplash.com/photo-1466694474381-de12210d82ac?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=388&q=80" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(7643), "https://images.unsplash.com/photo-1568732939097-b949d8c03cc1?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=387&q=80" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(7649), "https://media.istockphoto.com/id/1149139091/photo/blank-blue-mens-short-sleeve-summer-shirt-front-isolated-on-white-background-creased-wrinkle.webp?b=1&s=170667a&w=0&k=20&c=BOS13CMzBmgYfdEwRWX-RGp2B7J35a1Tw1e5pmH1lSw=" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(7655));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(7683));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(7705));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(7710));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(7716));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(7722));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(7727));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 12, 57, 29, 684, DateTimeKind.Local).AddTicks(7738));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 547, DateTimeKind.Local).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 547, DateTimeKind.Local).AddTicks(9192));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 547, DateTimeKind.Local).AddTicks(9227));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 547, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 547, DateTimeKind.Local).AddTicks(9725));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 547, DateTimeKind.Local).AddTicks(9773));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 547, DateTimeKind.Local).AddTicks(9803));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 547, DateTimeKind.Local).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 547, DateTimeKind.Local).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 547, DateTimeKind.Local).AddTicks(9989));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(93));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(121));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(155));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(182));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(356));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(472));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(575), "https://drive.google.com/file/d/13_FhARHW0v2hxkFipn1eBqaTHfxTPkbY/view?usp=drivesdk" });

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(598), "https://drive.google.com/file/d/13YXJ-M2YRBLpaw48auWMJ8ShB_148SVg/view?usp=drivesdk" });

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(606), "https://drive.google.com/file/d/13bZnH7bbIACPXfNnAR16Ay_lScEuTDbo/view?usp=drivesdk" });

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(614), "https://drive.google.com/file/d/13Gu6ybou3APw9Ws6afBo_C-Hu8fq_kin/view?usp=drivesdk" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(1223));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(1235));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(1247));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(1269));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(1275));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(1286));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(1292));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(1297));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(1303));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(1309));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(1315));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(785), "https://scontent-mrs2-2.xx.fbcdn.net/v/t39.30808-6/355161607_564208439260417_6980687300810840314_n.jpg?_nc_cat=106&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=qfjFUcj8pzoAX99azd5&_nc_oc=AQnvQwrfN7pcVNg-6_lcnJwa0TG-_Ojo9qjK9US0EhhqifUJevJ_qm0aNpxCrtZ7-5w&_nc_ht=scontent-mrs2-2.xx&oh=00_AfCBSYFtpnof1Wpa9iId33XU87J5TwJVsnYVKwUX1rtAYA&oe=64CD4120" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(794), "https://scontent-mrs2-2.xx.fbcdn.net/v/t39.30808-6/357734987_570964751918119_759831027575852777_n.jpg?_nc_cat=110&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=tlYkX4FzUSAAX90yi-Z&_nc_ht=scontent-mrs2-2.xx&oh=00_AfDjmekyGOGurtaqRW9tC5j1i1seCYcEPyllILLQB4Hfpw&oe=64D4F622" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(800), "https://scontent-mrs2-2.xx.fbcdn.net/v/t39.30808-6/365597223_585559370458657_5580480244724386446_n.jpg?_nc_cat=102&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=fL4zge3a0XIAX94w0z_&_nc_ht=scontent-mrs2-2.xx&oh=00_AfB1TMx7P7aVkzCb6CrnNhjmCivQnzXe-6JsvtToZNbPqg&oe=64D4E90D" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(806), "https://scontent-mrs2-2.xx.fbcdn.net/v/t39.30808-6/356395587_564779625869965_219606057578645242_n.jpg?_nc_cat=101&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=22dD2RqZH3sAX-lnzex&_nc_ht=scontent-mrs2-2.xx&oh=00_AfDejO-_2WlQ74CLpq3VAraDqcRHsMZkirGzSpjyEHT-ow&oe=64CD6C61" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(811), "https://scontent-sjc3-1.xx.fbcdn.net/v/t39.30808-6/363359035_693166479519953_4336954037090474141_n.jpg?stp=dst-jpg_p600x600&_nc_cat=101&ccb=1-7&_nc_sid=730e14&_nc_ohc=jfycB9sXjkwAX-Gjq3r&_nc_ht=scontent-sjc3-1.xx&oh=00_AfA6KNYyAXkm4ANG4ENdKd2BTiUdaIora2lteurGmkY4jw&oe=64CDCE27" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(817));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(822));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(853));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(885));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 10, 59, 9, 548, DateTimeKind.Local).AddTicks(926));
        }
    }
}
