using Microsoft.EntityFrameworkCore.Migrations;

namespace techtest2.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "languages",
                columns: new[] { "id", "langName" },
                values: new object[,]
                {
                    { 1, "English" },
                    { 2, "Chineese" },
                    { 3, "Thai" },
                    { 4, "Tamil" },
                    { 5, "korean" },
                    { 6, "burmese" }
                });

            migrationBuilder.InsertData(
                table: "levels",
                columns: new[] { "id", "levelName", "tradeId" },
                values: new object[,]
                {
                    { 1, "HIGH", 1 },
                    { 2, "MEDIUM", 2 },
                    { 3, "LOW", 1 }
                });

            migrationBuilder.InsertData(
                table: "trades",
                columns: new[] { "id", "tradeName" },
                values: new object[,]
                {
                    { 1, "MS INTERNATIONAL" },
                    { 2, "RAHIM INTERNATIONAL" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "levels",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "levels",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "levels",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "trades",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "trades",
                keyColumn: "id",
                keyValue: 2);
        }
    }
}
