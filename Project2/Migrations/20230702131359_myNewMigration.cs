using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project2.Migrations
{
    public partial class myNewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Tenders_Customers_CustomerId",
            //    table: "Tenders");

            //migrationBuilder.DropIndex(
            //    name: "IX_Tenders_CustomerId",
            //    table: "Tenders");

            //migrationBuilder.DropColumn(
            //    name: "CustomerId",
            //    table: "Tenders");

            //migrationBuilder.RenameColumn(
            //    name: "customerId",
            //    table: "Tenders",
            //    newName: "CustomerId");

            migrationBuilder.AlterColumn<string>(
                name: "size",
                table: "ProductSize",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Tenders_CustomerId",
            //    table: "Tenders",
            //    column: "CustomerId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Tenders_Customers_CustomerId",
            //    table: "Tenders",
            //    column: "CustomerId",
            //    principalTable: "Customers",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tenders_Customers_CustomerId",
                table: "Tenders");

            migrationBuilder.DropIndex(
                name: "IX_Tenders_CustomerId",
                table: "Tenders");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Tenders",
                newName: "customerId");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Tenders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "size",
                table: "ProductSize",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Tenders_CustomerId",
                table: "Tenders",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tenders_Customers_CustomerId",
                table: "Tenders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
