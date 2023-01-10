using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MrEmilProjekt.Migrations
{
    public partial class tst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AverageWin",
                table: "TheGames",
                newName: "Average");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Average",
                table: "TheGames",
                newName: "AverageWin");
        }
    }
}
