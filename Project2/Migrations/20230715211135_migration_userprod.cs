using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project2.Migrations
{
    public partial class migration_userprod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Maintainers",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Customers",
                newName: "UserName");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "productType",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductStatus",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Marketers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FName",
                table: "Maintainers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LName",
                table: "Maintainers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Delivers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "FName", "LName", "UserName" },
                values: new object[] { new DateTime(2023, 7, 16, 0, 11, 33, 738, DateTimeKind.Local).AddTicks(7783), "Zainab", "Ali", "zainabali" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "FName", "LName", "UserName" },
                values: new object[] { new DateTime(2023, 7, 16, 0, 11, 33, 738, DateTimeKind.Local).AddTicks(7881), "Razan", "Ali", "razanali" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "FName", "LName", "UserName" },
                values: new object[] { new DateTime(2023, 7, 16, 0, 11, 33, 738, DateTimeKind.Local).AddTicks(8127), "Zain", "Ali", "zainali" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "FName", "LName", "UserName" },
                values: new object[] { new DateTime(2023, 7, 16, 0, 11, 33, 738, DateTimeKind.Local).AddTicks(8244), "Raghad", "Ali", "raghadali" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "FName", "LName", "UserName" },
                values: new object[] { new DateTime(2023, 7, 16, 0, 11, 33, 738, DateTimeKind.Local).AddTicks(8271), "Aya", "Ali", "ayaali" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "FName", "LName", "UserName" },
                values: new object[] { new DateTime(2023, 7, 16, 0, 11, 33, 738, DateTimeKind.Local).AddTicks(8305), "Arwa", "Essa", "arwaessa" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "FName", "LName", "UserName" },
                values: new object[] { new DateTime(2023, 7, 16, 0, 11, 33, 738, DateTimeKind.Local).AddTicks(8344), "Osama", "Ali", "osamaali" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "FName", "LName", "UserName" },
                values: new object[] { new DateTime(2023, 7, 16, 0, 11, 33, 738, DateTimeKind.Local).AddTicks(8367), "Saosan", "Ali", "saosanali" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "FName", "LName", "UserName" },
                values: new object[] { new DateTime(2023, 7, 16, 0, 11, 33, 738, DateTimeKind.Local).AddTicks(8388), "Reem", "Manssor", "reemmanssor" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "FName", "LName", "UserName" },
                values: new object[] { new DateTime(2023, 7, 16, 0, 11, 33, 738, DateTimeKind.Local).AddTicks(8519), "Majd", "Esber", "majdesber" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "FName", "LName", "UserName" },
                values: new object[] { new DateTime(2023, 7, 16, 0, 11, 33, 738, DateTimeKind.Local).AddTicks(8554), "Rama", "Kaheel", "ramakaheel" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "FName", "LName", "UserName" },
                values: new object[] { new DateTime(2023, 7, 16, 0, 11, 33, 738, DateTimeKind.Local).AddTicks(8574), "Mohamad", "Ahmad", "mohamadahmad" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "FName", "LName", "UserName" },
                values: new object[] { new DateTime(2023, 7, 16, 0, 11, 33, 738, DateTimeKind.Local).AddTicks(8594), "Abeer", "Ali", "abeerali" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "FName", "LName", "UserName" },
                values: new object[] { new DateTime(2023, 7, 16, 0, 11, 33, 738, DateTimeKind.Local).AddTicks(8613), "Samaher", "Ali", "samaherali" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "FName", "LName", "UserName" },
                values: new object[] { new DateTime(2023, 7, 16, 0, 11, 33, 738, DateTimeKind.Local).AddTicks(8681), "Rama", "Abd-AlHak", "ramaabdalhak" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "FName", "LName", "UserName" },
                values: new object[] { new DateTime(2023, 7, 16, 0, 11, 33, 738, DateTimeKind.Local).AddTicks(8742), "Roua", "Edress", "rouaedress" });

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UserName" },
                values: new object[] { new DateTime(2023, 7, 16, 0, 11, 33, 738, DateTimeKind.Local).AddTicks(9142), "movo" });

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UserName" },
                values: new object[] { new DateTime(2023, 7, 16, 0, 11, 33, 738, DateTimeKind.Local).AddTicks(9153), "alkadmous" });

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UserName" },
                values: new object[] { new DateTime(2023, 7, 16, 0, 11, 33, 738, DateTimeKind.Local).AddTicks(8829), "fourhundred" });

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UserName" },
                values: new object[] { new DateTime(2023, 7, 16, 0, 11, 33, 738, DateTimeKind.Local).AddTicks(8844), "casucci" });

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UserName" },
                values: new object[] { new DateTime(2023, 7, 16, 0, 11, 33, 738, DateTimeKind.Local).AddTicks(8855), "4body" });

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UserName" },
                values: new object[] { new DateTime(2023, 7, 16, 0, 11, 33, 738, DateTimeKind.Local).AddTicks(9072), "diadora" });

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UserName" },
                values: new object[] { new DateTime(2023, 7, 16, 0, 11, 33, 738, DateTimeKind.Local).AddTicks(9087), "batti" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 1,
                column: "UserName",
                value: "admin");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 2,
                column: "UserName",
                value: "zainabali");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 3,
                column: "UserName",
                value: "razanali");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 4,
                column: "UserName",
                value: "zainali");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 5,
                column: "UserName",
                value: "raghadali");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 6,
                column: "UserName",
                value: "ayaali");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 7,
                column: "UserName",
                value: "arwaessa");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 8,
                column: "UserName",
                value: "osamaali");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 9,
                column: "UserName",
                value: "saosanali");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 10,
                column: "UserName",
                value: "reemmanssor");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 11,
                columns: new[] { "Name", "UserName" },
                values: new object[] { "Majd Esber", "majdesber" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 12,
                column: "UserName",
                value: "ramakaheel");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 13,
                column: "UserName",
                value: "mohamadahmad");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 14,
                column: "UserName",
                value: "abeerali");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 15,
                column: "UserName",
                value: "samaherali");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 16,
                column: "UserName",
                value: "ramaabdalhak");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 17,
                column: "UserName",
                value: "rouaedress");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 18,
                column: "UserName",
                value: "fourhundred");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 19,
                column: "UserName",
                value: "casucci");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 20,
                column: "UserName",
                value: "4body");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 21,
                column: "UserName",
                value: "diadora");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 22,
                column: "UserName",
                value: "batti");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 23,
                column: "UserName",
                value: "movo");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 24,
                column: "UserName",
                value: "alkadmous");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ProductStatus",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Marketers");

            migrationBuilder.DropColumn(
                name: "FName",
                table: "Maintainers");

            migrationBuilder.DropColumn(
                name: "LName",
                table: "Maintainers");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Delivers");

            migrationBuilder.DropColumn(
                name: "FName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LName",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Maintainers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Customers",
                newName: "Name");

            migrationBuilder.AlterColumn<int>(
                name: "productType",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 7, 13, 13, 58, 7, 851, DateTimeKind.Local).AddTicks(7042), "Zainab Ali" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 7, 13, 13, 58, 7, 851, DateTimeKind.Local).AddTicks(7145), "Razan Ali" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 7, 13, 13, 58, 7, 851, DateTimeKind.Local).AddTicks(7232), "Zain Ali" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 7, 13, 13, 58, 7, 851, DateTimeKind.Local).AddTicks(7350), "Raghad Ali" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 7, 13, 13, 58, 7, 851, DateTimeKind.Local).AddTicks(7382), "Aya Ali" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 7, 13, 13, 58, 7, 851, DateTimeKind.Local).AddTicks(7710), "Arwa Essa" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 7, 13, 13, 58, 7, 851, DateTimeKind.Local).AddTicks(7761), "Osama Ali" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 7, 13, 13, 58, 7, 851, DateTimeKind.Local).AddTicks(7787), "Saosan Ali" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 7, 13, 13, 58, 7, 851, DateTimeKind.Local).AddTicks(7818), "Reem Manssor" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 7, 13, 13, 58, 7, 851, DateTimeKind.Local).AddTicks(7917), "Magd Esber" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 7, 13, 13, 58, 7, 851, DateTimeKind.Local).AddTicks(7960), "Rama Kaheel" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 7, 13, 13, 58, 7, 851, DateTimeKind.Local).AddTicks(7985), "Mohamad Ahmad" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 7, 13, 13, 58, 7, 851, DateTimeKind.Local).AddTicks(8011), "Abeer Ali" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 7, 13, 13, 58, 7, 851, DateTimeKind.Local).AddTicks(8039), "Samaher Ali" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 7, 13, 13, 58, 7, 851, DateTimeKind.Local).AddTicks(8095), "Rama Abd-AlHak" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 7, 13, 13, 58, 7, 851, DateTimeKind.Local).AddTicks(8164), "Roua Edress" });

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 13, 13, 58, 7, 851, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 13, 13, 58, 7, 851, DateTimeKind.Local).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 13, 13, 58, 7, 851, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 13, 13, 58, 7, 851, DateTimeKind.Local).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 13, 13, 58, 7, 851, DateTimeKind.Local).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 13, 13, 58, 7, 851, DateTimeKind.Local).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 13, 13, 58, 7, 851, DateTimeKind.Local).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 11,
                column: "Name",
                value: "Magd Esber");
        }
    }
}
