using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseOperations.Migrations
{
    public partial class sisteenth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SweetenerTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SweetenerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SweetenerPrice = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    SweetenerDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisableData = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SweetenerTypes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SweetenerTypes");
        }
    }
}
