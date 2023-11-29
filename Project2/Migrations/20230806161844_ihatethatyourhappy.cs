using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project2.Migrations
{
    public partial class ihatethatyourhappy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "CreatedDate", "Name", "Price", "ProductStatus", "photo", "point", "productType" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(4023), "FRUIT OF DESIRE collection", 50000, 0, "https://scontent-mrs2-2.xx.fbcdn.net/v/t39.30808-6/355161607_564208439260417_6980687300810840314_n.jpg?_nc_cat=106&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=qfjFUcj8pzoAX99azd5&_nc_oc=AQnvQwrfN7pcVNg-6_lcnJwa0TG-_Ojo9qjK9US0EhhqifUJevJ_qm0aNpxCrtZ7-5w&_nc_ht=scontent-mrs2-2.xx&oh=00_AfCBSYFtpnof1Wpa9iId33XU87J5TwJVsnYVKwUX1rtAYA&oe=64CD4120", 50, "T-Shirt" },
                    { 2, new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(4033), "Women's suit", 260000, 2, "https://scontent-mrs2-2.xx.fbcdn.net/v/t39.30808-6/357734987_570964751918119_759831027575852777_n.jpg?_nc_cat=110&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=tlYkX4FzUSAAX90yi-Z&_nc_ht=scontent-mrs2-2.xx&oh=00_AfDjmekyGOGurtaqRW9tC5j1i1seCYcEPyllILLQB4Hfpw&oe=64D4F622", 260, "Suit" },
                    { 3, new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(4039), "Women's dress", 240000, 0, "https://scontent-mrs2-2.xx.fbcdn.net/v/t39.30808-6/365597223_585559370458657_5580480244724386446_n.jpg?_nc_cat=102&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=fL4zge3a0XIAX94w0z_&_nc_ht=scontent-mrs2-2.xx&oh=00_AfB1TMx7P7aVkzCb6CrnNhjmCivQnzXe-6JsvtToZNbPqg&oe=64D4E90D", 240, "Dress" },
                    { 4, new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(4045), "Cotton blouse", 120000, 0, "https://scontent-mrs2-2.xx.fbcdn.net/v/t39.30808-6/356395587_564779625869965_219606057578645242_n.jpg?_nc_cat=101&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=22dD2RqZH3sAX-lnzex&_nc_ht=scontent-mrs2-2.xx&oh=00_AfDejO-_2WlQ74CLpq3VAraDqcRHsMZkirGzSpjyEHT-ow&oe=64CD6C61", 120, "Blouse" },
                    { 5, new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(4051), "Half Sleeve Shirt", 130000, 2, "https://scontent-sjc3-1.xx.fbcdn.net/v/t39.30808-6/363359035_693166479519953_4336954037090474141_n.jpg?stp=dst-jpg_p600x600&_nc_cat=101&ccb=1-7&_nc_sid=730e14&_nc_ohc=jfycB9sXjkwAX-Gjq3r&_nc_ht=scontent-sjc3-1.xx&oh=00_AfA6KNYyAXkm4ANG4ENdKd2BTiUdaIora2lteurGmkY4jw&oe=64CDCE27", 130, "T-Shirt" },
                    { 6, new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(4057), "Kids Clothes", 200000, 0, "https://scontent-sjc3-1.xx.fbcdn.net/v/t39.30808-6/363299835_690878096415458_2800596399957126986_n.jpg?stp=dst-jpg_s600x600&_nc_cat=110&ccb=1-7&_nc_sid=730e14&_nc_ohc=4C0ZUHyd-rAAX9UIdYJ&_nc_ht=scontent-sjc3-1.xx&oh=00_AfBXi4TRHg9Q3D8Azn58nvBLinn_GZ45S6mi6Rb4bWHcrg&oe=64CC51F5", 200, "Clothes" },
                    { 7, new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(4062), "Men T-shirt", 95000, 0, "https://scontent-sjc3-1.xx.fbcdn.net/v/t39.30808-6/362290221_688812676622000_5276037355220976729_n.jpg?stp=dst-jpg_s600x600&_nc_cat=107&ccb=1-7&_nc_sid=730e14&_nc_ohc=SCDiw1ld8g4AX-KGaAW&_nc_ht=scontent-sjc3-1.xx&oh=00_AfCCVtchlg5XtLvmWXGOJSvpLIk2tfeqy11GUu1hq-9Olg&oe=64CCF749", 95, "T-Shirt" },
                    { 8, new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(4069), "TRACK JACKET PIRATI", 220000, 0, "https://www.diadora.com/dw/image/v2/BBPK_PRD/on/demandware.static/-/Sites-diadora-master/default/dw6ea061e6/images/hi-res/502.181066_20002_10_HR.jpg?sw=1920", 220, "Jacket" },
                    { 9, new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(4074), "HOODIE 2030", 92000, 1, "https://www.diadora.com/dw/image/v2/BBPK_PRD/on/demandware.static/-/Sites-diadora-master/default/dw4ab93b55/images/hi-res/502.179395_60063_10_HR.jpg?sw=1920", 92, "Hoodie" },
                    { 10, new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(4080), "T-SHIRT LS PIRATI", 91000, 0, "https://www.diadora.com/dw/image/v2/BBPK_PRD/on/demandware.static/-/Sites-diadora-master/default/dwe0de2333/images/hi-res/502.181067_20002_10_HR.jpg?sw=1920", 91, "T-Shirt" },
                    { 11, new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(4086), "SS POLO ICON", 75000, 0, "https://www.diadora.com/dw/image/v2/BBPK_PRD/on/demandware.static/-/Sites-diadora-master/default/dwe0de2333/images/hi-res/502.181067_20002_10_HR.jpg?sw=1920", 75, "T-Shirt" },
                    { 12, new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(4092), "Sports Wear", 175000, 0, "https://scontent-sjc3-1.xx.fbcdn.net/v/t39.30808-6/351561572_6469658053090940_8099638842778439333_n.jpg?_nc_cat=102&ccb=1-7&_nc_sid=730e14&_nc_ohc=nwIEKo6n6M4AX9our4M&_nc_ht=scontent-sjc3-1.xx&oh=00_AfDUTMZ2a5r9EFYiZ9XC3VpVm7NQX-FZc3UhsDmfuYDKHA&oe=64CC3C43", 175, "sports wear" },
                    { 13, new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(4098), "Sports Wear", 175000, 0, "https://scontent-sjc3-1.xx.fbcdn.net/v/t39.30808-6/353626922_4202504596641855_622169282761785229_n.jpg?stp=dst-jpg_s600x600&_nc_cat=111&ccb=1-7&_nc_sid=730e14&_nc_ohc=8p4FLL_RnVcAX8Ee1wS&_nc_ht=scontent-sjc3-1.xx&oh=00_AfDegqsFkpNbIq9B3_ujbWjfWH0QoihjZzrqrpoai9BEdA&oe=64CDB5D1", 175, "sports wear" },
                    { 14, new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(4103), "Sports Wear", 150000, 0, "https://scontent-sjc3-1.xx.fbcdn.net/v/t39.30808-6/354075177_4208536022705379_4647263395569733627_n.jpg?stp=dst-jpg_s600x600&_nc_cat=111&ccb=1-7&_nc_sid=730e14&_nc_ohc=s0SfU6K7qtUAX_TL4ff&_nc_oc=AQkPcPlL4Xw0ntiUzeGH6cyapSGuSael6mZVxYFJ0J5R9x6-2WfNi3mtcBxJ3SfPUcU&_nc_ht=scontent-sjc3-1.xx&oh=00_AfD8Ip-ZNmnaGffpstxYBLCn6Gl9sD-JhVOVxbgzMJUQMw&oe=64CBFF25", 150, "sports wear" },
                    { 15, new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(4111), "Sports Wear", 250000, 0, "https://scontent-sjc3-1.xx.fbcdn.net/v/t39.30808-6/356104038_4213923962166585_7828901660994432723_n.jpg?stp=dst-jpg_p417x417&_nc_cat=102&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=L3domGDq2vMAX9HI2ED&_nc_ht=scontent-sjc3-1.xx&oh=00_AfCZr5G8MxAyIRh94eqsLX5h96ETimCACgICKRjhngo9ZA&oe=64CDA055", 250, "sports wear" },
                    { 16, new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(4117), "Marines pants", 180000, 0, "https://casucci-fashion.com/site/img/uploads1/xsmall/product_sub_20230723012843_5154.jpg", 180, "Pant" },
                    { 17, new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(4123), "Linen pants", 125000, 0, "https://casucci-fashion.com/site/img/uploads1/xsmall/product_main_20230623091317_1309.jpg", 125, "Pant" },
                    { 18, new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(4128), "Wide women's pants", 120000, 0, "https://casucci-fashion.com/site/img/uploads1/xsmall/product_main_20220514120722_751.jpg", 120, "Pant" },
                    { 19, new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(4134), "Women's Linen Pants", 120000, 0, "https://casucci-fashion.com/site/img/uploads1/xsmall/product_main_20230327015738_1185.jpg", 120, "Pant" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "CreatedDate", "Name", "Price", "ProductStatus", "photo", "point", "productType" },
                values: new object[] { 20, new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(4141), "Women's Linen Pants", 37000, 2, "https://casucci-fashion.com/site/img/uploads1/xsmall/product_color_20220421095238_656_2617_2618.jpg", 37, "Pant" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "CreatedDate", "Name", "Price", "ProductStatus", "photo", "point", "productType" },
                values: new object[] { 21, new DateTime(2023, 8, 6, 19, 18, 41, 980, DateTimeKind.Local).AddTicks(4146), "Women's sweatpants", 60000, 0, "https://casucci-fashion.com/site/img/uploads1/xsmall/product_main_20220607091628_802.jpg", 60, "Pant" });

            migrationBuilder.InsertData(
                table: "ProductColors",
                columns: new[] { "Id", "color", "productId" },
                values: new object[,]
                {
                    { 1, "Black", 1 },
                    { 2, "Yellow", 1 },
                    { 3, "Gray", 1 },
                    { 4, "Green", 2 },
                    { 5, "Black", 2 },
                    { 6, "Pink", 2 },
                    { 7, "White", 2 },
                    { 8, "Blue", 3 },
                    { 9, "Pink", 3 },
                    { 10, "Orange", 3 },
                    { 11, "Green", 3 },
                    { 12, "White", 3 },
                    { 13, "Red", 4 },
                    { 14, "Black", 4 },
                    { 15, "Pink", 4 },
                    { 16, "Gray", 4 },
                    { 17, "Blue", 5 },
                    { 18, "Blue", 6 },
                    { 19, "Green", 6 },
                    { 20, "Gray", 6 },
                    { 21, "White", 6 },
                    { 22, "Black", 7 },
                    { 23, "White", 8 },
                    { 24, "Blue", 9 },
                    { 25, "White", 10 },
                    { 26, "White", 11 },
                    { 27, "Blue", 11 },
                    { 28, "Black", 11 },
                    { 29, "White", 12 },
                    { 30, "Black", 12 },
                    { 31, "Blue", 12 },
                    { 32, "Red", 12 },
                    { 33, "White", 13 },
                    { 34, "Black", 13 },
                    { 35, "Red", 13 },
                    { 36, "Blue", 14 },
                    { 37, "Black", 14 },
                    { 38, "White", 14 },
                    { 39, "White", 15 },
                    { 40, "BlacK", 15 },
                    { 41, "Gray", 15 },
                    { 42, "Gray", 16 }
                });

            migrationBuilder.InsertData(
                table: "ProductColors",
                columns: new[] { "Id", "color", "productId" },
                values: new object[,]
                {
                    { 43, "Green", 17 },
                    { 44, "Blue", 18 },
                    { 45, "Light Blue", 19 },
                    { 46, "Beige", 20 },
                    { 47, "White", 20 },
                    { 48, "Blue", 21 }
                });

            migrationBuilder.InsertData(
                table: "ProductSizes",
                columns: new[] { "Id", "productId", "size" },
                values: new object[,]
                {
                    { 1, 1, "L" },
                    { 2, 1, "M" },
                    { 3, 1, "S" },
                    { 4, 2, "L" },
                    { 5, 2, "M" },
                    { 6, 2, "XL" },
                    { 7, 2, "S" },
                    { 8, 3, "M" },
                    { 9, 3, "S" },
                    { 10, 3, "L" },
                    { 11, 3, "XL" },
                    { 12, 4, "S" },
                    { 13, 4, "M" },
                    { 14, 4, "L" },
                    { 15, 5, "M" },
                    { 16, 6, "S" },
                    { 17, 7, "M" },
                    { 18, 7, "L" },
                    { 19, 8, "S" },
                    { 20, 8, "L" },
                    { 21, 8, "XL" },
                    { 22, 9, "S" },
                    { 23, 9, "XS" },
                    { 24, 9, "M" },
                    { 25, 9, "L" },
                    { 26, 9, "XL" },
                    { 27, 9, "XXL" },
                    { 28, 10, "S" },
                    { 29, 10, "XS" },
                    { 30, 10, "M" },
                    { 31, 10, "L" },
                    { 32, 10, "XL" },
                    { 33, 10, "XXL" },
                    { 34, 11, "S" },
                    { 35, 11, "XS" },
                    { 36, 11, "M" }
                });

            migrationBuilder.InsertData(
                table: "ProductSizes",
                columns: new[] { "Id", "productId", "size" },
                values: new object[,]
                {
                    { 37, 11, "L" },
                    { 38, 11, "XL" },
                    { 39, 11, "XXL" },
                    { 40, 12, "M" },
                    { 41, 12, "L" },
                    { 42, 12, "XL" },
                    { 43, 12, "XXL" },
                    { 44, 13, "M" },
                    { 45, 13, "L" },
                    { 46, 13, "XL" },
                    { 47, 13, "XXL" },
                    { 48, 14, "M" },
                    { 49, 14, "L" },
                    { 50, 14, "XL" },
                    { 51, 14, "XXL" },
                    { 52, 15, "M" },
                    { 53, 15, "L" },
                    { 54, 15, "XL" },
                    { 55, 15, "XXL" },
                    { 56, 16, "M" },
                    { 57, 16, "L" },
                    { 58, 17, "M" },
                    { 59, 17, "L" },
                    { 60, 18, "S" },
                    { 61, 18, "M" },
                    { 62, 18, "L" },
                    { 63, 19, "M" },
                    { 64, 20, "30" },
                    { 65, 20, "32" },
                    { 66, 20, "34" },
                    { 67, 20, "36" },
                    { 68, 21, "28" },
                    { 69, 21, "30" },
                    { 70, 21, "32" },
                    { 71, 21, "34" },
                    { 72, 21, "36" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 2, 19, 10, 50, 768, DateTimeKind.Local).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 2, 19, 10, 50, 768, DateTimeKind.Local).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 2, 19, 10, 50, 768, DateTimeKind.Local).AddTicks(7296));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 2, 19, 10, 50, 768, DateTimeKind.Local).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 2, 19, 10, 50, 768, DateTimeKind.Local).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 2, 19, 10, 50, 768, DateTimeKind.Local).AddTicks(7852));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 2, 19, 10, 50, 768, DateTimeKind.Local).AddTicks(7883));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 2, 19, 10, 50, 768, DateTimeKind.Local).AddTicks(8013));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 2, 19, 10, 50, 768, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 2, 19, 10, 50, 768, DateTimeKind.Local).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 2, 19, 10, 50, 768, DateTimeKind.Local).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 2, 19, 10, 50, 768, DateTimeKind.Local).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 2, 19, 10, 50, 768, DateTimeKind.Local).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 2, 19, 10, 50, 768, DateTimeKind.Local).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 2, 19, 10, 50, 768, DateTimeKind.Local).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 2, 19, 10, 50, 768, DateTimeKind.Local).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 2, 19, 10, 50, 768, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 2, 19, 10, 50, 768, DateTimeKind.Local).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 2, 19, 10, 50, 768, DateTimeKind.Local).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 2, 19, 10, 50, 768, DateTimeKind.Local).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 2, 19, 10, 50, 768, DateTimeKind.Local).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 2, 19, 10, 50, 768, DateTimeKind.Local).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 2, 19, 10, 50, 768, DateTimeKind.Local).AddTicks(8717));
        }
    }
}
