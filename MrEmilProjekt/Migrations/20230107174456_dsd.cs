using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MrEmilProjekt.Migrations
{
    public partial class dsd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hypotenusa",
                table: "Shapes");

            migrationBuilder.CreateTable(
                name: "Triangels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Base = table.Column<double>(type: "float", nullable: false),
                    Hight = table.Column<double>(type: "float", nullable: false),
                    Hypotenusa = table.Column<double>(type: "float", nullable: false),
                    Area = table.Column<double>(type: "float", nullable: false),
                    Circumference = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Triangels", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Triangels");

            migrationBuilder.AddColumn<double>(
                name: "Hypotenusa",
                table: "Shapes",
                type: "float",
                nullable: true);
        }
    }
}
