using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project2.Migrations
{
    public partial class datamigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Interactions");

            //migrationBuilder.DropTable(
            //    name: "List<ProductSize>");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Maintainers");

            migrationBuilder.AddColumn<int>(
                name: "status",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Tenders",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "reactioncount",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "status",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "status",
                table: "Popularizations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<long>(
                name: "phoneNumber",
                table: "Marketers",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<long>(
                name: "mobileNumber",
                table: "Marketers",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<int>(
                name: "userId",
                table: "Maintainers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<long>(
                name: "phoneNumber",
                table: "Delivers",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<long>(
                name: "mobileNumber",
                table: "Delivers",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<long>(
                name: "phoneNumber",
                table: "Customers",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Auctions",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UID", "Email", "Name", "password", "status", "userType" },
                values: new object[,]
                {
                    { 1, "Admin@gmail.com", "Admin", "YISvNNx7m0uGboKqTmBVDOsPWlub165soNNiT+WCQ1w=", 0, 3 },
                    { 2, "zainabali@gmail.com", "Zainab Ali", "tP+zU/+3Jif+8lIOPWtWleavkgLYuhKsBaPbed6ZTNU=", 0, 0 },
                    { 3, "razanali@gmail.com", "Razan Ali", "Cb9rXXzWsIPK5g62LL1wAwPrkyHPtnriBCKkfJyRiwI=", 0, 0 },
                    { 4, "zainali@gmail.com", "Zain Ali", "G2VhoTZtMDbQCcdJMZqHZDCA8CZKHoNWryk1qgcnkxg=", 0, 0 },
                    { 5, "raghadali@gmail.com", "Raghad Ali", "uqJftz54SIyOCYk50ylR46FuBcuaIKAFfrzSNxO4Fro=", 0, 0 },
                    { 6, "ayaali@gmail.com", "Aya Ali", "Y//5iznoGvAW3lNF8rzUIR8dpfGto/uAcIjWFLHFriw=", 0, 0 },
                    { 7, "arwaessa@gmail.com", "Arwa Essa", "6zC5BhAqLbse5ss45vsN9RPbgRN7mmtI1WeCosmB+U0=", 0, 0 },
                    { 8, "osamaali@gmail.com", "Osama Ali", "uVimCnhgYFobgt4t7nYWeSbFEzauujKE8IJXknHzYws=", 0, 0 },
                    { 9, "saosanali@gmail.com", "Saosan Ali", "bP4E44SWE4QcCLsZeIbUF58h80cE85kWHynuMitO9Ks=", 0, 0 },
                    { 10, "reemmanssor@gmail.com", "Reem Manssor", "FgU3FHlO/jDQ03zPsz4ZW9AccxHNysEWNigKrM56IIM=", 0, 0 },
                    { 11, "magdesber@gmail.com", "Magd Esber", "lDBAMHP4cxj2NeZdVLwwT6GKn6mgGmnRkoftWQYRHtA=", 0, 0 },
                    { 12, "ramakaheel@gmail.com", "Rama Kaheel", "pNzdhNTNLbr/Pk3DL2dwDtXcQIajM1YSR2zpLCRobco=", 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Birthdate", "CreatedDate", "MarketerId", "Name", "Point", "city", "phoneNumber", "photo", "userId", "zone" },
                values: new object[,]
                {
                    { 1, new DateTime(1999, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 5, 22, 51, 44, 308, DateTimeKind.Local).AddTicks(8552), null, "Zainab Ali", 0, "Damascus", 963937239433L, "", 2, "Qatana" },
                    { 2, new DateTime(2002, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 5, 22, 51, 44, 308, DateTimeKind.Local).AddTicks(8706), null, "Razan Ali", 0, "Damascus", 963996902853L, "", 3, "Qatana" },
                    { 3, new DateTime(2006, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 5, 22, 51, 44, 308, DateTimeKind.Local).AddTicks(8741), null, "Zain Ali", 0, "Damascus", 963936851060L, "", 4, "Qatana" },
                    { 4, new DateTime(2008, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 5, 22, 51, 44, 308, DateTimeKind.Local).AddTicks(8779), null, "Raghad Ali", 0, "Damascus", 963934470881L, "", 5, "Qatana" },
                    { 5, new DateTime(2009, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 5, 22, 51, 44, 308, DateTimeKind.Local).AddTicks(8812), null, "Aya Ali", 0, "Damascus", 963934470881L, "", 6, "Qatana" },
                    { 6, new DateTime(1973, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 5, 22, 51, 44, 308, DateTimeKind.Local).AddTicks(8882), null, "Arwa Essa", 0, "Damascus", 963934470881L, "", 7, "Qatana" },
                    { 7, new DateTime(1962, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 5, 22, 51, 44, 308, DateTimeKind.Local).AddTicks(8936), null, "Osama Ali", 0, "Damascus", 963936851941L, "", 8, "Qatana" },
                    { 8, new DateTime(1970, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 5, 22, 51, 44, 308, DateTimeKind.Local).AddTicks(8969), null, "Saosan Ali", 0, "Damascus", 963985920017L, "", 9, "Mazah" },
                    { 9, new DateTime(1998, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 5, 22, 51, 44, 308, DateTimeKind.Local).AddTicks(9005), null, "Reem Manssor", 0, "Damascus", 963998784139L, "", 10, "Moaadameah" },
                    { 10, new DateTime(1997, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 5, 22, 51, 44, 308, DateTimeKind.Local).AddTicks(9079), null, "Magd Esber", 0, "Damascus", 963995755940L, "", 11, "Dummar" },
                    { 11, new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 5, 22, 51, 44, 308, DateTimeKind.Local).AddTicks(9130), null, "Rama Kaheel", 0, "Damascus", 963935470669L, "", 12, "Kafar-sosah" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Maintainers_userId",
                table: "Maintainers",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_Maintainers_Users_userId",
                table: "Maintainers",
                column: "userId",
                principalTable: "Users",
                principalColumn: "UID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Maintainers_Users_userId",
                table: "Maintainers");

            migrationBuilder.DropIndex(
                name: "IX_Maintainers_userId",
                table: "Maintainers");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UID",
                keyValue: 12);

            migrationBuilder.DropColumn(
                name: "status",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "reactioncount",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "status",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "status",
                table: "Popularizations");

            migrationBuilder.DropColumn(
                name: "mobileNumber",
                table: "Marketers");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "Maintainers");

            migrationBuilder.DropColumn(
                name: "mobileNumber",
                table: "Delivers");

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Tenders",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "phoneNumber",
                table: "Marketers",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Maintainers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "phoneNumber",
                table: "Delivers",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "phoneNumber",
                table: "Customers",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Auctions",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Interactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReactionType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Interactions_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Interactions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "List<ProductSize>",
                columns: table => new
                {
                    Capacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateIndex(
                name: "IX_Interactions_PostId",
                table: "Interactions",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Interactions_UserId",
                table: "Interactions",
                column: "UserId");
        }
    }
}
