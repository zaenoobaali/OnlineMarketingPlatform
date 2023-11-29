using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project2.Migrations
{
    public partial class userbillmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Discretion",
                table: "Popularizations",
                newName: "Description");

            migrationBuilder.AddColumn<long>(
                name: "Billfold",
                table: "Users",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "PointRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    marketerId = table.Column<int>(type: "int", nullable: false),
                    pointsAmount = table.Column<int>(type: "int", nullable: false),
                    pointsPrice = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PointRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PointRequests_Marketers_marketerId",
                        column: x => x.marketerId,
                        principalTable: "Marketers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 299, DateTimeKind.Local).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 299, DateTimeKind.Local).AddTicks(7665));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 299, DateTimeKind.Local).AddTicks(7963));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 299, DateTimeKind.Local).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 299, DateTimeKind.Local).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 299, DateTimeKind.Local).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 299, DateTimeKind.Local).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 299, DateTimeKind.Local).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 299, DateTimeKind.Local).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 299, DateTimeKind.Local).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 299, DateTimeKind.Local).AddTicks(8489));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 299, DateTimeKind.Local).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 299, DateTimeKind.Local).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 299, DateTimeKind.Local).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 299, DateTimeKind.Local).AddTicks(8973));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 299, DateTimeKind.Local).AddTicks(9082));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 299, DateTimeKind.Local).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 299, DateTimeKind.Local).AddTicks(9305));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 299, DateTimeKind.Local).AddTicks(9184));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 299, DateTimeKind.Local).AddTicks(9202));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 299, DateTimeKind.Local).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 299, DateTimeKind.Local).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 299, DateTimeKind.Local).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 300, DateTimeKind.Local).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 300, DateTimeKind.Local).AddTicks(186));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 300, DateTimeKind.Local).AddTicks(193));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 300, DateTimeKind.Local).AddTicks(201));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 300, DateTimeKind.Local).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 300, DateTimeKind.Local).AddTicks(216));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 300, DateTimeKind.Local).AddTicks(223));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 300, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 300, DateTimeKind.Local).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 300, DateTimeKind.Local).AddTicks(244));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 300, DateTimeKind.Local).AddTicks(251));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 300, DateTimeKind.Local).AddTicks(258));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 300, DateTimeKind.Local).AddTicks(265));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 300, DateTimeKind.Local).AddTicks(273));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 300, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 300, DateTimeKind.Local).AddTicks(287));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 300, DateTimeKind.Local).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 300, DateTimeKind.Local).AddTicks(302));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 300, DateTimeKind.Local).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 300, DateTimeKind.Local).AddTicks(318));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 300, DateTimeKind.Local).AddTicks(326));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 299, DateTimeKind.Local).AddTicks(9428));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 299, DateTimeKind.Local).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 299, DateTimeKind.Local).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 299, DateTimeKind.Local).AddTicks(9456));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 299, DateTimeKind.Local).AddTicks(9465));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 299, DateTimeKind.Local).AddTicks(9472));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 299, DateTimeKind.Local).AddTicks(9479));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 299, DateTimeKind.Local).AddTicks(9486));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 299, DateTimeKind.Local).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 299, DateTimeKind.Local).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 299, DateTimeKind.Local).AddTicks(9508));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 299, DateTimeKind.Local).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 299, DateTimeKind.Local).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 299, DateTimeKind.Local).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 299, DateTimeKind.Local).AddTicks(9536));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 299, DateTimeKind.Local).AddTicks(9544));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 299, DateTimeKind.Local).AddTicks(9551));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 299, DateTimeKind.Local).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 299, DateTimeKind.Local).AddTicks(9633));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 299, DateTimeKind.Local).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 21, 58, 7, 299, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 1,
                column: "Billfold",
                value: 1000000L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 2,
                column: "Billfold",
                value: 1000000L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 3,
                column: "Billfold",
                value: 1000000L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 4,
                column: "Billfold",
                value: 1000000L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 5,
                column: "Billfold",
                value: 1000000L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 6,
                column: "Billfold",
                value: 1000000L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 7,
                column: "Billfold",
                value: 1000000L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 8,
                column: "Billfold",
                value: 1000000L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 9,
                column: "Billfold",
                value: 1000000L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 10,
                column: "Billfold",
                value: 1000000L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 11,
                column: "Billfold",
                value: 1000000L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 12,
                column: "Billfold",
                value: 1000000L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 13,
                column: "Billfold",
                value: 1000000L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 14,
                column: "Billfold",
                value: 1000000L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 15,
                column: "Billfold",
                value: 1000000L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 16,
                column: "Billfold",
                value: 1000000L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 17,
                column: "Billfold",
                value: 1000000L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 18,
                column: "Billfold",
                value: 1000000L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 19,
                column: "Billfold",
                value: 1000000L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 20,
                column: "Billfold",
                value: 1000000L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 21,
                column: "Billfold",
                value: 1000000L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 22,
                column: "Billfold",
                value: 1000000L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 23,
                column: "Billfold",
                value: 1000000L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 24,
                column: "Billfold",
                value: 1000000L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 25,
                column: "Billfold",
                value: 1000000L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 26,
                column: "Billfold",
                value: 1000000L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 27,
                column: "Billfold",
                value: 1000000L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 28,
                column: "Billfold",
                value: 1000000L);

            migrationBuilder.CreateIndex(
                name: "IX_PointRequests_marketerId",
                table: "PointRequests",
                column: "marketerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PointRequests");

            migrationBuilder.DropColumn(
                name: "Billfold",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Popularizations",
                newName: "Discretion");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(4948));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(5268));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(5329));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(5499));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(5628));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(5738));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(5812));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(5852));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(5928));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6134));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6262));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6365));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6395));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(7066));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(7108));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(7164));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6621));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6642));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 22, 10, 45, 596, DateTimeKind.Local).AddTicks(6757));
        }
    }
}
