using Microsoft.EntityFrameworkCore.Migrations;

namespace AppleStore.Migrations
{
    public partial class PurchaseUpd2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "TotalPrice",
                table: "Purchases",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "Purchases");
        }
    }
}
