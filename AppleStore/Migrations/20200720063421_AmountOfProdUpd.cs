using Microsoft.EntityFrameworkCore.Migrations;

namespace AppleStore.Migrations
{
    public partial class AmountOfProdUpd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AmountOfProduct",
                table: "Macs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AmountOfProduct",
                table: "IPads",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AmountOfProduct",
                table: "AppleWatches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AmountOfProduct",
                table: "AirPodses",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmountOfProduct",
                table: "Macs");

            migrationBuilder.DropColumn(
                name: "AmountOfProduct",
                table: "IPads");

            migrationBuilder.DropColumn(
                name: "AmountOfProduct",
                table: "AppleWatches");

            migrationBuilder.DropColumn(
                name: "AmountOfProduct",
                table: "AirPodses");
        }
    }
}
