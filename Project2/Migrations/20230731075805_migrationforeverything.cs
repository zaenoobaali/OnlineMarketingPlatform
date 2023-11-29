using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project2.Migrations
{
    public partial class migrationforeverything : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_marketerBags_Customers_customerId",
                table: "marketerBags");

            migrationBuilder.DropForeignKey(
                name: "FK_marketerBags_Marketers_marketerId",
                table: "marketerBags");

            migrationBuilder.DropForeignKey(
                name: "FK_marketerBags_ProductOrders_ProductOrderId",
                table: "marketerBags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_marketerBags",
                table: "marketerBags");

            migrationBuilder.RenameTable(
                name: "marketerBags",
                newName: "MarketerBags");

            migrationBuilder.RenameIndex(
                name: "IX_marketerBags_ProductOrderId",
                table: "MarketerBags",
                newName: "IX_MarketerBags_ProductOrderId");

            migrationBuilder.RenameIndex(
                name: "IX_marketerBags_marketerId",
                table: "MarketerBags",
                newName: "IX_MarketerBags_marketerId");

            migrationBuilder.RenameIndex(
                name: "IX_marketerBags_customerId",
                table: "MarketerBags",
                newName: "IX_MarketerBags_customerId");

            migrationBuilder.AddColumn<bool>(
                name: "IsAgent",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MarketerBags",
                table: "MarketerBags",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ContractedDelivers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    deliverId = table.Column<int>(type: "int", nullable: false),
                    marketerId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractedDelivers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContractedDelivers_Delivers_deliverId",
                        column: x => x.deliverId,
                        principalTable: "Delivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContractedDelivers_Marketers_marketerId",
                        column: x => x.marketerId,
                        principalTable: "Marketers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustomersAgents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customerId = table.Column<int>(type: "int", nullable: false),
                    marketerId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersAgents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomersAgents_Customers_customerId",
                        column: x => x.customerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomersAgents_Marketers_marketerId",
                        column: x => x.marketerId,
                        principalTable: "Marketers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 10, 58, 3, 161, DateTimeKind.Local).AddTicks(9699));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 10, 58, 3, 161, DateTimeKind.Local).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 10, 58, 3, 161, DateTimeKind.Local).AddTicks(9905));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 10, 58, 3, 161, DateTimeKind.Local).AddTicks(9971));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 10, 58, 3, 162, DateTimeKind.Local).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 10, 58, 3, 162, DateTimeKind.Local).AddTicks(407));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 10, 58, 3, 162, DateTimeKind.Local).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 10, 58, 3, 162, DateTimeKind.Local).AddTicks(801));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 10, 58, 3, 162, DateTimeKind.Local).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 10, 58, 3, 162, DateTimeKind.Local).AddTicks(885));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 10, 58, 3, 162, DateTimeKind.Local).AddTicks(925));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 10, 58, 3, 162, DateTimeKind.Local).AddTicks(961));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 10, 58, 3, 162, DateTimeKind.Local).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 10, 58, 3, 162, DateTimeKind.Local).AddTicks(1037));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 10, 58, 3, 162, DateTimeKind.Local).AddTicks(1244));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 10, 58, 3, 162, DateTimeKind.Local).AddTicks(1425));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 10, 58, 3, 162, DateTimeKind.Local).AddTicks(1667));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 10, 58, 3, 162, DateTimeKind.Local).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 10, 58, 3, 162, DateTimeKind.Local).AddTicks(1548));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 10, 58, 3, 162, DateTimeKind.Local).AddTicks(1566));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 10, 58, 3, 162, DateTimeKind.Local).AddTicks(1576));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 10, 58, 3, 162, DateTimeKind.Local).AddTicks(1586));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 10, 58, 3, 162, DateTimeKind.Local).AddTicks(1597));

            migrationBuilder.CreateIndex(
                name: "IX_ContractedDelivers_deliverId",
                table: "ContractedDelivers",
                column: "deliverId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractedDelivers_marketerId",
                table: "ContractedDelivers",
                column: "marketerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersAgents_customerId",
                table: "CustomersAgents",
                column: "customerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersAgents_marketerId",
                table: "CustomersAgents",
                column: "marketerId");

            migrationBuilder.AddForeignKey(
                name: "FK_MarketerBags_Customers_customerId",
                table: "MarketerBags",
                column: "customerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MarketerBags_Marketers_marketerId",
                table: "MarketerBags",
                column: "marketerId",
                principalTable: "Marketers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MarketerBags_ProductOrders_ProductOrderId",
                table: "MarketerBags",
                column: "ProductOrderId",
                principalTable: "ProductOrders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MarketerBags_Customers_customerId",
                table: "MarketerBags");

            migrationBuilder.DropForeignKey(
                name: "FK_MarketerBags_Marketers_marketerId",
                table: "MarketerBags");

            migrationBuilder.DropForeignKey(
                name: "FK_MarketerBags_ProductOrders_ProductOrderId",
                table: "MarketerBags");

            migrationBuilder.DropTable(
                name: "ContractedDelivers");

            migrationBuilder.DropTable(
                name: "CustomersAgents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MarketerBags",
                table: "MarketerBags");

            migrationBuilder.DropColumn(
                name: "IsAgent",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "MarketerBags",
                newName: "marketerBags");

            migrationBuilder.RenameIndex(
                name: "IX_MarketerBags_ProductOrderId",
                table: "marketerBags",
                newName: "IX_marketerBags_ProductOrderId");

            migrationBuilder.RenameIndex(
                name: "IX_MarketerBags_marketerId",
                table: "marketerBags",
                newName: "IX_marketerBags_marketerId");

            migrationBuilder.RenameIndex(
                name: "IX_MarketerBags_customerId",
                table: "marketerBags",
                newName: "IX_marketerBags_customerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_marketerBags",
                table: "marketerBags",
                column: "Id");

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
                column: "CreatedDate",
                value: new DateTime(2023, 7, 28, 17, 10, 29, 730, DateTimeKind.Local).AddTicks(1878));

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

            migrationBuilder.AddForeignKey(
                name: "FK_marketerBags_Customers_customerId",
                table: "marketerBags",
                column: "customerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_marketerBags_Marketers_marketerId",
                table: "marketerBags",
                column: "marketerId",
                principalTable: "Marketers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_marketerBags_ProductOrders_ProductOrderId",
                table: "marketerBags",
                column: "ProductOrderId",
                principalTable: "ProductOrders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
