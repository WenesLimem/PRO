using Microsoft.EntityFrameworkCore.Migrations;

namespace EkoRestaurant.Migrations
{
    public partial class MyFirstMigrationasd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Remark",
                table: "ClientCommandElements",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Remark",
                table: "ClientCommandElements");
        }
    }
}
