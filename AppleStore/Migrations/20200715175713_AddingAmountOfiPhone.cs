using Microsoft.EntityFrameworkCore.Migrations;

namespace AppleStore.Migrations
{
    public partial class AddingAmountOfiPhone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AmountOfProduct",
                table: "IPhones",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmountOfProduct",
                table: "IPhones");
        }
    }
}
