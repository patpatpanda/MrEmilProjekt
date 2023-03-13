using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MrEmilProjekt.Migrations
{
    public partial class tesst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Test",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Test",
                table: "Games");
        }
    }
}
