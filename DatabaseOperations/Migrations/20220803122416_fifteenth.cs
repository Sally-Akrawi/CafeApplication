using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseOperations.Migrations
{
    public partial class fifteenth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "DisableData",
                table: "SyrupTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisableData",
                table: "SyrupTypes");
        }
    }
}
