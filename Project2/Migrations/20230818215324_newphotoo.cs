using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project2.Migrations
{
    public partial class newphotoo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 833, DateTimeKind.Local).AddTicks(8087));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 833, DateTimeKind.Local).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 833, DateTimeKind.Local).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 833, DateTimeKind.Local).AddTicks(8414));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 833, DateTimeKind.Local).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 833, DateTimeKind.Local).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 833, DateTimeKind.Local).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 833, DateTimeKind.Local).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 833, DateTimeKind.Local).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 833, DateTimeKind.Local).AddTicks(8788));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 833, DateTimeKind.Local).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 833, DateTimeKind.Local).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 833, DateTimeKind.Local).AddTicks(8901));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 833, DateTimeKind.Local).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 833, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 833, DateTimeKind.Local).AddTicks(9287));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 833, DateTimeKind.Local).AddTicks(9489));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 833, DateTimeKind.Local).AddTicks(9502));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 19, 0, 53, 19, 833, DateTimeKind.Local).AddTicks(9395), "https://drive.google.com/file/d/13_FhARHW0v2hxkFipn1eBqaTHfxTPkbY/view?usp=drivesdk" });

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 833, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 19, 0, 53, 19, 833, DateTimeKind.Local).AddTicks(9419), "https://drive.google.com/file/d/13YXJ-M2YRBLpaw48auWMJ8ShB_148SVg/view?usp=drivesdk" });

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 19, 0, 53, 19, 833, DateTimeKind.Local).AddTicks(9428), "https://drive.google.com/file/d/13bZnH7bbIACPXfNnAR16Ay_lScEuTDbo/view?usp=drivesdk" });

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 833, DateTimeKind.Local).AddTicks(9438));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 834, DateTimeKind.Local).AddTicks(123));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 834, DateTimeKind.Local).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 834, DateTimeKind.Local).AddTicks(147));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 834, DateTimeKind.Local).AddTicks(155));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 834, DateTimeKind.Local).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 834, DateTimeKind.Local).AddTicks(169));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 834, DateTimeKind.Local).AddTicks(175));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 834, DateTimeKind.Local).AddTicks(183));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 834, DateTimeKind.Local).AddTicks(189));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 834, DateTimeKind.Local).AddTicks(195));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 834, DateTimeKind.Local).AddTicks(202));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 834, DateTimeKind.Local).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 834, DateTimeKind.Local).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 834, DateTimeKind.Local).AddTicks(222));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 834, DateTimeKind.Local).AddTicks(228));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 834, DateTimeKind.Local).AddTicks(234));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 834, DateTimeKind.Local).AddTicks(241));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 834, DateTimeKind.Local).AddTicks(247));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 834, DateTimeKind.Local).AddTicks(254));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 834, DateTimeKind.Local).AddTicks(261));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 834, DateTimeKind.Local).AddTicks(267));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 833, DateTimeKind.Local).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 833, DateTimeKind.Local).AddTicks(9653));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 833, DateTimeKind.Local).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 833, DateTimeKind.Local).AddTicks(9667));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 833, DateTimeKind.Local).AddTicks(9674));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 833, DateTimeKind.Local).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 833, DateTimeKind.Local).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 833, DateTimeKind.Local).AddTicks(9695));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 833, DateTimeKind.Local).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 833, DateTimeKind.Local).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 833, DateTimeKind.Local).AddTicks(9717));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 833, DateTimeKind.Local).AddTicks(9724));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 833, DateTimeKind.Local).AddTicks(9731));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 833, DateTimeKind.Local).AddTicks(9763));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 833, DateTimeKind.Local).AddTicks(9771));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 833, DateTimeKind.Local).AddTicks(9779));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 833, DateTimeKind.Local).AddTicks(9787));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 833, DateTimeKind.Local).AddTicks(9794));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 833, DateTimeKind.Local).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 833, DateTimeKind.Local).AddTicks(9808));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 53, 19, 833, DateTimeKind.Local).AddTicks(9816));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(299));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(343));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(807));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(889));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(975));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(1154));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(1188));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(1257));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(1291));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(1482));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(1600));

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
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(1695), "https://scontent-sea1-1.xx.fbcdn.net/v/t39.30808-6/341128419_3463352667274276_2171667707378597735_n.jpg?_nc_cat=100&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=vDg3xROjpCEAX-sGMFE&_nc_ht=scontent-sea1-1.xx&oh=00_AfAJ7EMobr7_zeIYnmEH3Ma0UuY4yMeJZ-robXe9knQDag&oe=64CE59A4" });

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
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(1719), "https://scontent-sea1-1.xx.fbcdn.net/v/t39.30808-6/335212653_978922139680099_738417653861151955_n.jpg?_nc_cat=110&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=w4WR4GdXKw4AX_ghKn2&_nc_oc=AQlc2R3M8BRt7-LKEv2zE0veKshHSBETqXYFG8AW2SJYYcu3xSfan4TSy1sPCFVTC7I&_nc_ht=scontent-sea1-1.xx&oh=00_AfAgUajRyvJuIOWqQaxbzbYq0Yl_1ZVPAcie_ZrDwNFtvA&oe=64CD58C7" });

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(1730), "https://scontent-sea1-1.xx.fbcdn.net/v/t39.30808-6/350510661_792092328902851_6819436556991760805_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=vIFhIzrcCQsAX81YJRX&_nc_ht=scontent-sea1-1.xx&oh=00_AfC1qoxEnBjVbystcBXjJkAUHGoj5aU94ufvclZteD7F7A&oe=64CDA92B" });

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 0, 30, 46, 213, DateTimeKind.Local).AddTicks(1839));

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
    }
}
