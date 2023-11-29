using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project2.Migrations
{
    public partial class ihatethatyouarehappywithoutme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 818, DateTimeKind.Local).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(108));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(175));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(247));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(337));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(393));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(565));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(658));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(697));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(772));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(808));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(1139));

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
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(1276));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(1299));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(1310));

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CreatedDate", "Description", "counter", "marketerId", "productId", "reactioncount", "status" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(1990), "Vibrant fruit patterns: For a modern and trendy look, opt from our Fruit of Desire Collection in all Batti Branches", 54, 5, 1, 200, 0 },
                    { 2, new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(2005), "BUY 1 GET 1 FREE  🤩Hurry! Get yours now while we're still on offer ,The offer is available in all Batti branches and for a limited time", 40, 5, 2, 300, 0 },
                    { 3, new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(2013), "Casual, modern, colorful: the new dress fit into any style. Check out the new models from vitality collection.", 30, 5, 3, 400, 0 },
                    { 4, new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(2022), "Trendy and colorful: matchy-matchy looks to celebrate Adha's Eid. Discover our Fruit of Desire Collection.", 51, 5, 4, 100, 0 },
                    { 5, new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(2030), "Summer needs a lot of clothes 👔Take advantage of the offers and shop a variety of T-shirtsBuy a half sleeve shirt size M of selected models , at the sale price, and get the second for free", 44, 1, 5, 150, 0 },
                    { 6, new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(2038), "Distinguish your child in the summer with cheerful colors", 23, 1, 6, 110, 0 },
                    { 7, new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(2045), "Feel confident and stylish 🔥⭐ ", 60, 1, 7, 70, 0 },
                    { 8, new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(2053), "The track jacket is made of breathable and water repellent fabric, with transfer prints on the sleeves and embroidered logos on the chest. Made in Italy.", 39, 4, 8, 600, 0 },
                    { 9, new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(2060), "Men hoodie available in different, nature-inspired colors. Made of recycled cotton, Hoodie 2030 is comfortable and sustainable: it is indeed made in Italy and GRS certified .( Discount 50% 'from 184000 to 92000')", 56, 4, 9, 500, 0 },
                    { 10, new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(2067), "The long sleeve tee is made from 100% cotton. Transfer prints on the sleeves, pocket with stitched pirate embroidery and logos of the three brands under the pocket.", 55, 4, 10, 90, 0 },
                    { 11, new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(2075), "Short-sleeved Polo shirt made of stretch polyester piquet inspired by a retro vibe style. SS Polo Icon features contrasting knitted inserts on the collar and on the sleeve hems. The logo design complies with the tournament regulations", 5, 4, 11, 56, 0 },
                    { 12, new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(2082), "The special summer collection is now in our halls In addition to bags and sports shoes 😍Now you can choose the most beautiful pieces, such as design, colors, quality, and price as well 😉We are waiting for you ❤❤", 46, 3, 12, 456, 0 },
                    { 13, new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(2090), "The special summer collection is now in our halls In addition to bags and sports shoes 😍\" +\r\n\"Now you can choose the most beautiful pieces, such as design, colors, quality, and price as well 😉\" +\r\n\"We are waiting for you ❤❤", 20, 3, 13, 500, 0 },
                    { 14, new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(2098), "The special summer collection is now in our halls In addition to bags and sports shoes 😍\" +\r\n\"Now you can choose the most beautiful pieces, such as design, colors, quality, and price as well 😉\" +\r\n\"We are waiting for you ❤❤", 47, 3, 14, 450, 0 },
                    { 15, new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(2106), "The special summer collection is now in our halls In addition to bags and sports shoes 😍\" +\r\n\"Now you can choose the most beautiful pieces, such as design, colors, quality, and price as well 😉\" +\r\n\"We are waiting for you ❤❤", 17, 3, 15, 566, 0 },
                    { 16, new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(2113), "New CASUCCI Collection Summer 2023 season", 33, 2, 16, 340, 0 },
                    { 17, new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(2120), "New CASUCCI Collection Summer 2023 season", 30, 2, 17, 350, 0 },
                    { 18, new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(2127), "New CASUCCI Collection Summer 2023 season", 20, 2, 18, 340, 0 },
                    { 19, new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(2134), "New CASUCCI Collection Summer 2023 season", 10, 2, 19, 340, 0 }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CreatedDate", "Description", "counter", "marketerId", "productId", "reactioncount", "status" },
                values: new object[,]
                {
                    { 20, new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(2142), "New CASUCCI Collection Summer 2023 season", 56, 2, 20, 500, 0 },
                    { 21, new DateTime(2023, 8, 6, 19, 25, 33, 819, DateTimeKind.Local).AddTicks(2149), "New CASUCCI Collection Summer 2023 season", 43, 2, 21, 456, 0 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(2310));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(2504));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(2915));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(3033));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(3082));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(3115));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(3218));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(3348));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(3411));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(3602));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(3712));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(3921));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(3853));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(4039));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(4045));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(4057));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(4098));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(4141));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(4146));
        }
    }
}
