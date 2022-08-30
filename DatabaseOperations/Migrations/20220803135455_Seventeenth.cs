using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseOperations.Migrations
{
    public partial class Seventeenth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DrinkTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DrinkName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrinkPrice = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    DrinkDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisableData = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrinkTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ToppingTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ToppingName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToppingPrice = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    ToppingDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisableData = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToppingTypes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DrinkTypes");

            migrationBuilder.DropTable(
                name: "ToppingTypes");
        }
    }
}
