using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Potfolio.DataAccess.Migrations
{
    public partial class mig_service_icon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IconUrl",
                table: "Services",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IconUrl",
                table: "Services");
        }
    }
}
