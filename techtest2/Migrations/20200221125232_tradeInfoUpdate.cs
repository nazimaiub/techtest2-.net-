using Microsoft.EntityFrameworkCore.Migrations;

namespace techtest2.Migrations
{
    public partial class tradeInfoUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "syllabusFilePath",
                table: "tradingInfoes",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "testPlanFilePath",
                table: "tradingInfoes",
                maxLength: 1000,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "syllabusFilePath",
                table: "tradingInfoes");

            migrationBuilder.DropColumn(
                name: "testPlanFilePath",
                table: "tradingInfoes");
        }
    }
}
