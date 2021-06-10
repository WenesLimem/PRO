using Microsoft.EntityFrameworkCore.Migrations;

namespace EkoRestaurant.Migrations
{
    public partial class AddSoftDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSoftDeleted",
                table: "Recipes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSoftDeleted",
                table: "RecipeIngredientQuantity",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSoftDeleted",
                table: "RecipeCategories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSoftDeleted",
                table: "ListeDesCoursesElements",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSoftDeleted",
                table: "ListeDesCourses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSoftDeleted",
                table: "Ingredients",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSoftDeleted",
                table: "IngredientCategories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSoftDeleted",
                table: "DailyMenus",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSoftDeleted",
                table: "ClientCommands",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSoftDeleted",
                table: "ClientCommandElements",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSoftDeleted",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "IsSoftDeleted",
                table: "RecipeIngredientQuantity");

            migrationBuilder.DropColumn(
                name: "IsSoftDeleted",
                table: "RecipeCategories");

            migrationBuilder.DropColumn(
                name: "IsSoftDeleted",
                table: "ListeDesCoursesElements");

            migrationBuilder.DropColumn(
                name: "IsSoftDeleted",
                table: "ListeDesCourses");

            migrationBuilder.DropColumn(
                name: "IsSoftDeleted",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "IsSoftDeleted",
                table: "IngredientCategories");

            migrationBuilder.DropColumn(
                name: "IsSoftDeleted",
                table: "DailyMenus");

            migrationBuilder.DropColumn(
                name: "IsSoftDeleted",
                table: "ClientCommands");

            migrationBuilder.DropColumn(
                name: "IsSoftDeleted",
                table: "ClientCommandElements");
        }
    }
}
