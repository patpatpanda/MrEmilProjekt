using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MrEmilProjekt.Migrations
{
    public partial class djjf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Hypotenusa",
                table: "Shapes",
                type: "float",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hypotenusa",
                table: "Shapes");
        }
    }
}
