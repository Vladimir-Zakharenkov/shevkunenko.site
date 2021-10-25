using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Site.Migrations
{
    public partial class Int_PageNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TitleOfPages",
                columns: table => new
                {
                    TitleOfPageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PageNumber = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TitleOfPages", x => x.TitleOfPageId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TitleOfPages");
        }
    }
}
