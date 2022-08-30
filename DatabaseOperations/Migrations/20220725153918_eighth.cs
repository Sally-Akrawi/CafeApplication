using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseOperations.Migrations
{
    public partial class eighth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "DisableData",
                table: "FoodTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisableData",
                table: "FoodTypes");
        }
    }
}
