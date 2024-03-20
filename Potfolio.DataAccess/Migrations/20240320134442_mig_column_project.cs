using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Potfolio.DataAccess.Migrations
{
    public partial class mig_column_project : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EndDate",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Platform",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StartDate",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Projects",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Values",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Platform",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Values",
                table: "Projects");
        }
    }
}
