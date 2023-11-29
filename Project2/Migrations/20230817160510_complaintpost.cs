using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project2.Migrations
{
    public partial class complaintpost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "URL",
                table: "Complaints");

            migrationBuilder.AddColumn<int>(
                name: "postId",
                table: "Complaints",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(3103));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(3148));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(3283));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(3446));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(3486));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(3602));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(3687));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(3812));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(3853));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(4399));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(4262));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(5001));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(5021));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(5053));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(5092));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(5108));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(5116));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(5185));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(4523));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(4545));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(4622));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(4655));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(4671));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 19, 5, 7, 882, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.CreateIndex(
                name: "IX_Complaints_postId",
                table: "Complaints",
                column: "postId");

            migrationBuilder.AddForeignKey(
                name: "FK_Complaints_Posts_postId",
                table: "Complaints",
                column: "postId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Complaints_Posts_postId",
                table: "Complaints");

            migrationBuilder.DropIndex(
                name: "IX_Complaints_postId",
                table: "Complaints");

            migrationBuilder.DropColumn(
                name: "postId",
                table: "Complaints");

            migrationBuilder.AddColumn<string>(
                name: "URL",
                table: "Complaints",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(780));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(952));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(1077));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(1433));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(1516));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(1565));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(1697));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(5341));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(5439));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(5906));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(6172));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(6195));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(6953));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(6961));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(6968));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(6976));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(7015));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(7031));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(7039));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(7055));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(7062));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(7071));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(6416));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(6428));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(6436));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(6467));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(6483));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(6497));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(6536));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(6543));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(6551));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(6567));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 23, 52, 49, 298, DateTimeKind.Local).AddTicks(6576));
        }
    }
}
