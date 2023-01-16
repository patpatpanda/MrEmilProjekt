using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MrEmilProjekt.Migrations
{
    public partial class testlol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TheGames",
                table: "TheGames");

            migrationBuilder.RenameTable(
                name: "TheGames",
                newName: "Games");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Games",
                table: "Games",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Games",
                table: "Games");

            migrationBuilder.RenameTable(
                name: "Games",
                newName: "TheGames");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TheGames",
                table: "TheGames",
                column: "Id");
        }
    }
}
