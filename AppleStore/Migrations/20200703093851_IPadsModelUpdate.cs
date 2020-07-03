using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppleStore.Migrations
{
    public partial class IPadsModelUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "IPads",
               columns: table => new
               {
                   Id = table.Column<int>(nullable: false)
                       .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                   IPadModel = table.Column<string>(nullable: true),
                   TypeOfModel = table.Column<string>(nullable: true),
                   Memory = table.Column<int>(nullable: false),
                   Type = table.Column<string>(nullable: true),
                   ScreenType = table.Column<string>(nullable: true),
                   ScreenSize = table.Column<float>(nullable: false),
                   Processor = table.Column<string>(nullable: true),
                   Ram = table.Column<int>(nullable: false),
                   MainCamera = table.Column<string>(nullable: false),
                   FrontCamera = table.Column<int>(nullable: false),
                   YearOfProduction = table.Column<int>(nullable: false),
                   Color = table.Column<string>(nullable: true),
                   Price = table.Column<float>(nullable: false),
                   Description = table.Column<string>(nullable: true)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_IPads", x => x.Id);
               });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
               name: "IPads");
        }
    }
}
