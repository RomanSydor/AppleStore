using Microsoft.EntityFrameworkCore.Migrations;

namespace AppleStore.Migrations
{
    public partial class AppleWatchUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Communication",
                table: "AppleWatches",
                newName: "Gps");

            migrationBuilder.AddColumn<string>(
                name: "Cellular",
                table: "AppleWatches",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cellular",
                table: "AppleWatches");

            migrationBuilder.RenameColumn(
                name: "Gps",
                table: "AppleWatches",
                newName: "Communication");
        }
    }
}
