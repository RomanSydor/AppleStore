using Microsoft.EntityFrameworkCore.Migrations;

namespace AppleStore.Migrations
{
    public partial class IPhoneUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VideoRecording",
                table: "IPhones",
                newName: "UhdRecording");

            migrationBuilder.AlterColumn<string>(
                name: "MainCamera",
                table: "IPhones",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UhdRecording",
                table: "IPhones",
                newName: "VideoRecording");

            migrationBuilder.AlterColumn<int>(
                name: "MainCamera",
                table: "IPhones",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
