using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project2.Migrations
{
    public partial class moreandmoremigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReactionOnPosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    postId = table.Column<int>(type: "int", nullable: false),
                    userId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReactionOnPosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReactionOnPosts_Posts_postId",
                        column: x => x.postId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReactionOnPosts_Users_userId",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "UID",
                        onDelete: ReferentialAction.Restrict);
                });

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
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 2, 19, 10, 50, 768, DateTimeKind.Local).AddTicks(8795), "https://lh3.googleusercontent.com/p/AF1QipPUuFAL_44ng3qOaOG4aoqFzbHJmIRcheBwW_SD=s680-w680-h510" });

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "mobileNumber", "phoneNumber", "photo" },
                values: new object[] { new DateTime(2023, 8, 2, 19, 10, 50, 768, DateTimeKind.Local).AddTicks(8807), 0L, 113325002L, "https://www.alkadmous.com/images/logo.png" });

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 2, 19, 10, 50, 768, DateTimeKind.Local).AddTicks(8677), "https://scontent-sea1-1.xx.fbcdn.net/v/t39.30808-6/341128419_3463352667274276_2171667707378597735_n.jpg?_nc_cat=100&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=vDg3xROjpCEAX-sGMFE&_nc_ht=scontent-sea1-1.xx&oh=00_AfAJ7EMobr7_zeIYnmEH3Ma0UuY4yMeJZ-robXe9knQDag&oe=64CE59A4" });

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 2, 19, 10, 50, 768, DateTimeKind.Local).AddTicks(8691), "https://www.casucci-fashion.com/site/img/uploads1/larg/branches_20211101051244_56.jpg" });

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 2, 19, 10, 50, 768, DateTimeKind.Local).AddTicks(8700), "https://scontent-sea1-1.xx.fbcdn.net/v/t39.30808-6/335212653_978922139680099_738417653861151955_n.jpg?_nc_cat=110&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=w4WR4GdXKw4AX_ghKn2&_nc_oc=AQlc2R3M8BRt7-LKEv2zE0veKshHSBETqXYFG8AW2SJYYcu3xSfan4TSy1sPCFVTC7I&_nc_ht=scontent-sea1-1.xx&oh=00_AfAgUajRyvJuIOWqQaxbzbYq0Yl_1ZVPAcie_ZrDwNFtvA&oe=64CD58C7" });

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 2, 19, 10, 50, 768, DateTimeKind.Local).AddTicks(8708), "https://scontent-sea1-1.xx.fbcdn.net/v/t39.30808-6/350510661_792092328902851_6819436556991760805_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=vIFhIzrcCQsAX81YJRX&_nc_ht=scontent-sea1-1.xx&oh=00_AfC1qoxEnBjVbystcBXjJkAUHGoj5aU94ufvclZteD7F7A&oe=64CDA92B" });

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 8, 2, 19, 10, 50, 768, DateTimeKind.Local).AddTicks(8717), "https://scontent-sea1-1.xx.fbcdn.net/v/t39.30808-6/286066775_317831530564572_3718556029484236078_n.jpg?_nc_cat=103&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=rvbSrrgL2EIAX-JqFfS&_nc_ht=scontent-sea1-1.xx&oh=00_AfDYQbnEilFXn2G9GDAgSLLLOsr3daBH5hU0o3UNA9zzEw&oe=64CEE28E" });

            migrationBuilder.CreateIndex(
                name: "IX_ReactionOnPosts_postId",
                table: "ReactionOnPosts",
                column: "postId");

            migrationBuilder.CreateIndex(
                name: "IX_ReactionOnPosts_userId",
                table: "ReactionOnPosts",
                column: "userId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReactionOnPosts");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 14, 3, 20, 927, DateTimeKind.Local).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 14, 3, 20, 927, DateTimeKind.Local).AddTicks(3787));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 14, 3, 20, 927, DateTimeKind.Local).AddTicks(3826));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 14, 3, 20, 927, DateTimeKind.Local).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 14, 3, 20, 927, DateTimeKind.Local).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 14, 3, 20, 927, DateTimeKind.Local).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 14, 3, 20, 927, DateTimeKind.Local).AddTicks(4424));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 14, 3, 20, 927, DateTimeKind.Local).AddTicks(4532));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 14, 3, 20, 927, DateTimeKind.Local).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 14, 3, 20, 927, DateTimeKind.Local).AddTicks(4603));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 14, 3, 20, 927, DateTimeKind.Local).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 14, 3, 20, 927, DateTimeKind.Local).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 14, 3, 20, 927, DateTimeKind.Local).AddTicks(4769));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 14, 3, 20, 927, DateTimeKind.Local).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 14, 3, 20, 927, DateTimeKind.Local).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 31, 14, 3, 20, 927, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 7, 31, 14, 3, 20, 927, DateTimeKind.Local).AddTicks(5301), "" });

            migrationBuilder.UpdateData(
                table: "Delivers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "mobileNumber", "phoneNumber", "photo" },
                values: new object[] { new DateTime(2023, 7, 31, 14, 3, 20, 927, DateTimeKind.Local).AddTicks(5310), 963987654321L, 0L, "" });

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 7, 31, 14, 3, 20, 927, DateTimeKind.Local).AddTicks(5207), "" });

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 7, 31, 14, 3, 20, 927, DateTimeKind.Local).AddTicks(5222), "" });

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 7, 31, 14, 3, 20, 927, DateTimeKind.Local).AddTicks(5231), "" });

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 7, 31, 14, 3, 20, 927, DateTimeKind.Local).AddTicks(5241), "" });

            migrationBuilder.UpdateData(
                table: "Marketers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "photo" },
                values: new object[] { new DateTime(2023, 7, 31, 14, 3, 20, 927, DateTimeKind.Local).AddTicks(5251), "" });
        }
    }
}
