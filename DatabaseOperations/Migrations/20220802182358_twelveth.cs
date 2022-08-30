using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseOperations.Migrations
{
    public partial class twelveth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TeaDesicription",
                table: "TeaTypes",
                newName: "TeaDescription");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TeaDescription",
                table: "TeaTypes",
                newName: "TeaDesicription");
        }
    }
}
