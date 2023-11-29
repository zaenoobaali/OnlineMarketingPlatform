using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project2.Migrations
{
    public partial class AddForignkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "ProductOrders",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "productorderId",
                table: "OrderBags",
                newName: "ProductOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderBags_ProductOrderId",
                table: "OrderBags",
                column: "ProductOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderBags_ProductOrders_ProductOrderId",
                table: "OrderBags",
                column: "ProductOrderId",
                principalTable: "ProductOrders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderBags_ProductOrders_ProductOrderId",
                table: "OrderBags");

            migrationBuilder.DropIndex(
                name: "IX_OrderBags_ProductOrderId",
                table: "OrderBags");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ProductOrders",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "ProductOrderId",
                table: "OrderBags",
                newName: "productorderId");
        }
    }
}
