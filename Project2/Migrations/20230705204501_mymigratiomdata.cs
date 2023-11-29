using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project2.Migrations
{
    public partial class mymigratiomdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 23, 45, 0, 454, DateTimeKind.Local).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 23, 45, 0, 454, DateTimeKind.Local).AddTicks(8946));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 23, 45, 0, 454, DateTimeKind.Local).AddTicks(8972));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 23, 45, 0, 454, DateTimeKind.Local).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 23, 45, 0, 454, DateTimeKind.Local).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 23, 45, 0, 454, DateTimeKind.Local).AddTicks(9469));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 23, 45, 0, 454, DateTimeKind.Local).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 23, 45, 0, 454, DateTimeKind.Local).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 23, 45, 0, 454, DateTimeKind.Local).AddTicks(9587));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 23, 45, 0, 454, DateTimeKind.Local).AddTicks(9677));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 23, 45, 0, 454, DateTimeKind.Local).AddTicks(9724));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UID", "Email", "Name", "password", "status", "userType" },
                values: new object[,]
                {
                    { 13, "mohamadahmad@gmail.com", "Mohamad Ahmad", "AuZexzLn0HEFuA/E3hq0CU7+1cxMox48Al1obsTaQTg=", 0, 0 },
                    { 14, "abeerali@gmail.com", "Abeer Ali", "FLamUDGJ6e0c/+jx4afx+gFIXEIQPx5clhyq6FqySzc=", 0, 0 },
                    { 15, "samaherali@gmail.com", "Samaher Ali", "N3slx+IbqYtkLKvnYaIoFP4dF95dtkR3QnSnGyurRic=", 0, 0 },
                    { 16, "ramaabdalhak@gmail.com", "Rama Abd-AlHak", "fPeOc5z3lndpfas4da358cJu4j60HL2A9hWN/UE+1lI=", 0, 0 },
                    { 17, "rouaedress@gmail.com", "Roua Edress", "3vaGS3RwIOmFUrvhI1UwZVhNBSkM1IJRU0mMEufpenI=", 0, 0 },
                    { 18, "customer.service@400.sy", "Four Hundred", "aKe6uYxPexCfGNODnzfoEVZeVe41BAmt0wHTPyFBtps=", 0, 2 },
                    { 19, "casucci@gmail.com", "CASUCCI", "r2eLRdIrvOVBRwTMqg+a445/UFTaA0Hjg4N+7XuKRWU=", 0, 2 },
                    { 20, "forbody@gmail.com", "4BODY", "iGPtncoTOyx+jU/L/OkcHPwWbAcRi9sqZm0vuqPR1E4=", 0, 2 },
                    { 21, "syria@zarzourgroup.com", "DIADORA", "z8dugNQ9ogqRxQKuKjIKA4P8DVTcAz3fANhkGFIrrsg=", 0, 2 },
                    { 22, "info@batticolors.com", "Mixed colors of batti", "3ZHHOGds45YUgSZJcRS2BZBZUl48WVlGIuDaA+pofys=", 0, 2 },
                    { 23, "info@movo.delivery", "Movo delivery", "q5AMR+Z9atWehi1PZa88R7EVAXm2tgR7INFcgNOsfRA=", 0, 1 },
                    { 24, "eatery@gmail.com", "Al Kadmous", "7VQvedUyyA8SlsKECq9SbNjobmJsGdXWANN3t7xGgkE=", 0, 1 }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Birthdate", "CreatedDate", "MarketerId", "Name", "Point", "city", "phoneNumber", "photo", "userId", "zone" },
                values: new object[,]
                {
                    { 12, new DateTime(1963, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 5, 23, 45, 0, 454, DateTimeKind.Local).AddTicks(9751), null, "Mohamad Ahmad", 0, "Damascus", 963934873326L, "", 13, "Mazah" },
                    { 13, new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 5, 23, 45, 0, 454, DateTimeKind.Local).AddTicks(9780), null, "Abeer Ali", 0, "Lattakia", 963983739169L, "", 14, "Jablah" },
                    { 14, new DateTime(1973, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 5, 23, 45, 0, 454, DateTimeKind.Local).AddTicks(9807), null, "Samaher Ali", 0, "Lattakia", 963967811417L, "", 15, "Jablah" },
                    { 15, new DateTime(1999, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 5, 23, 45, 0, 454, DateTimeKind.Local).AddTicks(9878), null, "Rama Abd-AlHak", 0, "Damascus", 963993991918L, "", 16, "Mohajreen" },
                    { 16, new DateTime(1999, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 5, 23, 45, 0, 454, DateTimeKind.Local).AddTicks(9944), null, "Roua Edress", 0, "Damascus", 963947222344L, "", 17, "Sabborah" }
                });

            migrationBuilder.InsertData(
                table: "Delivers",
                columns: new[] { "Id", "CreatedDate", "MarketerId", "Name", "city", "mobileNumber", "phoneNumber", "photo", "userId", "zone" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 5, 23, 45, 0, 455, DateTimeKind.Local).AddTicks(283), null, "Movo delivery", "Damascus", 0L, 118054000L, "", 23, "Masaab ebn Omeer" },
                    { 2, new DateTime(2023, 7, 5, 23, 45, 0, 455, DateTimeKind.Local).AddTicks(294), null, "Al Kadmous", "Damascus", 963987654321L, 0L, "", 24, "Al Hamra Street" }
                });

            migrationBuilder.InsertData(
                table: "Marketers",
                columns: new[] { "Id", "CreatedDate", "Name", "Point", "city", "mobileNumber", "phoneNumber", "photo", "userId", "zone" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 5, 23, 45, 0, 455, DateTimeKind.Local).AddTicks(166), "Four Hundred", 0, "Damascus", 963993100400L, 963116912400L, "", 18, "Fahhameh" },
                    { 2, new DateTime(2023, 7, 5, 23, 45, 0, 455, DateTimeKind.Local).AddTicks(189), "CASUCCI", 0, "Damascus", 963932163000L, 2240926L, "", 19, "Fahhameh" },
                    { 3, new DateTime(2023, 7, 5, 23, 45, 0, 455, DateTimeKind.Local).AddTicks(201), "4BODY", 0, "Damascus", 963933320070L, 963112266170L, "", 20, "Fahhameh" },
                    { 4, new DateTime(2023, 7, 5, 23, 45, 0, 455, DateTimeKind.Local).AddTicks(213), "DIADORA", 0, "Damascus", 0L, 5440405L, "", 21, "Fahhameh" },
                    { 5, new DateTime(2023, 7, 5, 23, 45, 0, 455, DateTimeKind.Local).AddTicks(225), "Mixed colors of batti", 0, "Damascus", 963989312094L, 0L, "", 22, "Fahhameh" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 24);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 22, 51, 44, 308, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 22, 51, 44, 308, DateTimeKind.Local).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 22, 51, 44, 308, DateTimeKind.Local).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 22, 51, 44, 308, DateTimeKind.Local).AddTicks(8779));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 22, 51, 44, 308, DateTimeKind.Local).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 22, 51, 44, 308, DateTimeKind.Local).AddTicks(8882));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 22, 51, 44, 308, DateTimeKind.Local).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 22, 51, 44, 308, DateTimeKind.Local).AddTicks(8969));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 22, 51, 44, 308, DateTimeKind.Local).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 22, 51, 44, 308, DateTimeKind.Local).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 5, 22, 51, 44, 308, DateTimeKind.Local).AddTicks(9130));
        }
    }
}
