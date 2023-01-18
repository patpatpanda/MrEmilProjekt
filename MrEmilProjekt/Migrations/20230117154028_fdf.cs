using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MrEmilProjekt.Migrations
{
    public partial class fdf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Shapes",
                newName: "_Name");

            migrationBuilder.RenameColumn(
                name: "Lenght",
                table: "Shapes",
                newName: "_Lenght");

            migrationBuilder.RenameColumn(
                name: "Height",
                table: "Shapes",
                newName: "_Height");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "_Name",
                table: "Shapes",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "_Lenght",
                table: "Shapes",
                newName: "Lenght");

            migrationBuilder.RenameColumn(
                name: "_Height",
                table: "Shapes",
                newName: "Height");
        }
    }
}
