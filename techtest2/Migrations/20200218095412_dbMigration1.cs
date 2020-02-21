using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace techtest2.Migrations
{
    public partial class dbMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "languages",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    langName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_languages", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "levels",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    levelName = table.Column<string>(maxLength: 50, nullable: false),
                    tradeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_levels", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "trades",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    tradeName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trades", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tradingInfoes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    tradeName = table.Column<string>(maxLength: 50, nullable: false),
                    levelName = table.Column<string>(maxLength: 50, nullable: false),
                    language = table.Column<string>(maxLength: 50, nullable: false),
                    syllabus = table.Column<string>(maxLength: 50, nullable: false),
                    syllabusFileName = table.Column<string>(nullable: true),
                    testPlanFileName = table.Column<string>(nullable: true),
                    developmentOfficer = table.Column<string>(nullable: false),
                    manager = table.Column<string>(nullable: false),
                    active = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tradingInfoes", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "languages");

            migrationBuilder.DropTable(
                name: "levels");

            migrationBuilder.DropTable(
                name: "trades");

            migrationBuilder.DropTable(
                name: "tradingInfoes");
        }
    }
}
