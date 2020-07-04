using Microsoft.EntityFrameworkCore.Migrations;

namespace AppleStore.Migrations
{
    public partial class AirPodsUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsWirelessCharging",
                table: "AirPodses");

            migrationBuilder.AddColumn<string>(
                name: "WirelessCharging",
                table: "AirPodses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WirelessCharging",
                table: "AirPodses");

            migrationBuilder.AddColumn<bool>(
                name: "IsWirelessCharging",
                table: "AirPodses",
                nullable: false,
                defaultValue: false);
        }
    }
}
