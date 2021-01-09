using Microsoft.EntityFrameworkCore.Migrations;

namespace Moldovan_Maria_AplicatieWeb.Migrations
{
    public partial class Timp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Timp",
                table: "Retete",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Timp",
                table: "Retete");
        }
    }
}
