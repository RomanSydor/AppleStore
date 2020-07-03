using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppleStore.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AirPodses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AirPodsModel = table.Column<string>(nullable: true),
                    YearOfProduction = table.Column<int>(nullable: false),
                    IsWirelessCharging = table.Column<bool>(nullable: false),
                    Price = table.Column<float>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirPodses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppleWatches",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AppleWatchModel = table.Column<string>(nullable: true),
                    ScreenSize = table.Column<int>(nullable: false),
                    Communication = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    HousingMaterial = table.Column<string>(nullable: true),
                    StrapType = table.Column<string>(nullable: true),
                    Price = table.Column<float>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppleWatches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IPads",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IPadModel = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Memory = table.Column<int>(nullable: false),
                    IsCellular = table.Column<bool>(nullable: false),
                    ScreenSize = table.Column<float>(nullable: false),
                    YearOfProduction = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    Price = table.Column<float>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IPads", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IPhones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IPhoneModel = table.Column<string>(nullable: true),
                    Memory = table.Column<int>(nullable: false),
                    ScreenType = table.Column<string>(nullable: true),
                    ScreenSize = table.Column<float>(nullable: false),
                    VideoRecording = table.Column<string>(nullable: true),
                    Processor = table.Column<string>(nullable: true),
                    Ram = table.Column<int>(nullable: false),
                    MainCamera = table.Column<int>(nullable: false),
                    FrontCamera = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    Price = table.Column<float>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IPhones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Macs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MacModel = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Memory = table.Column<int>(nullable: false),
                    ScreenSize = table.Column<float>(nullable: false),
                    Processor = table.Column<string>(nullable: true),
                    Ram = table.Column<int>(nullable: false),
                    SsdCapacity = table.Column<int>(nullable: true),
                    DriveCapacity = table.Column<string>(nullable: true),
                    VideoCard = table.Column<string>(nullable: true),
                    YearOfProduction = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    Price = table.Column<float>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Macs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AirPodses");

            migrationBuilder.DropTable(
                name: "AppleWatches");

            migrationBuilder.DropTable(
                name: "IPads");

            migrationBuilder.DropTable(
                name: "IPhones");

            migrationBuilder.DropTable(
                name: "Macs");
        }
    }
}
