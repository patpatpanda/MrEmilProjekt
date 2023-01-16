using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MrEmilProjekt.Migrations
{
    public partial class ere : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Circumference",
                table: "Shapes",
                newName: "Perimeter");

            migrationBuilder.RenameColumn(
                name: "Bas",
                table: "Shapes",
                newName: "Lenght");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Perimeter",
                table: "Shapes",
                newName: "Circumference");

            migrationBuilder.RenameColumn(
                name: "Lenght",
                table: "Shapes",
                newName: "Bas");
        }
    }
}
