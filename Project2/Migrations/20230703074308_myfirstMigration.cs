using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project2.Migrations
{
    public partial class myfirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderBags_Posts_postId",
                table: "OrderBags");

            migrationBuilder.RenameColumn(
                name: "postId",
                table: "OrderBags",
                newName: "PostId");

            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "OrderBags",
                newName: "productorderId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderBags_postId",
                table: "OrderBags",
                newName: "IX_OrderBags_PostId");

            migrationBuilder.AlterColumn<int>(
                name: "PostId",
                table: "OrderBags",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "IdOrder",
                table: "OrderBags",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ProductOrders",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    prouductId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductOrders", x => x.id);
                    table.ForeignKey(
                        name: "FK_ProductOrders_Products_prouductId",
                        column: x => x.prouductId,
                        principalTable: "Products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderBags_productorderId",
                table: "OrderBags",
                column: "productorderId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrders_prouductId",
                table: "ProductOrders",
                column: "prouductId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderBags_Posts_PostId",
                table: "OrderBags",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderBags_ProductOrders_productorderId",
                table: "OrderBags",
                column: "productorderId",
                principalTable: "ProductOrders",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderBags_Posts_PostId",
                table: "OrderBags");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderBags_ProductOrders_productorderId",
                table: "OrderBags");

            migrationBuilder.DropTable(
                name: "ProductOrders");

            migrationBuilder.DropIndex(
                name: "IX_OrderBags_productorderId",
                table: "OrderBags");

            migrationBuilder.DropColumn(
                name: "IdOrder",
                table: "OrderBags");

            migrationBuilder.RenameColumn(
                name: "PostId",
                table: "OrderBags",
                newName: "postId");

            migrationBuilder.RenameColumn(
                name: "productorderId",
                table: "OrderBags",
                newName: "quantity");

            migrationBuilder.RenameIndex(
                name: "IX_OrderBags_PostId",
                table: "OrderBags",
                newName: "IX_OrderBags_postId");

            migrationBuilder.AlterColumn<int>(
                name: "postId",
                table: "OrderBags",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderBags_Posts_postId",
                table: "OrderBags",
                column: "postId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
