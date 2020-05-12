using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace parksapifullstack.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parks",
                columns: table => new
                {
                    ParkId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    State = table.Column<string>(nullable: false),
                    Description = table.Column<string>(maxLength: 2000, nullable: true),
                    ClimbingRoutes = table.Column<int>(nullable: false),
                    Campgrounds = table.Column<int>(nullable: false),
                    GeneralStores = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.ParkId);
                });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Campgrounds", "City", "ClimbingRoutes", "Description", "GeneralStores", "Name", "State" },
                values: new object[,]
                {
                    { 2, 3, "Three Rivers", 1, "It's ancient", 4, "Sequoia National Park", "CA" },
                    { 3, 9, "Yosemite National Park", 1348, "I met my friend Sam here", 8, "Yosemite National Park", "CA" },
                    { 4, 4, "Grand Canyon", 46, "It big", 3, "Grand Canyon National Park", "AZ" },
                    { 5, 17, "Glacier", 5, "I didn't get to see it 'cause Donald shut down the government when I got there, whatta loon.", 1, "Glacier National Park", "MT" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parks");
        }
    }
}
