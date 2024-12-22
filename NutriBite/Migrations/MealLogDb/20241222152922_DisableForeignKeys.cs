using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriBite.Migrations.MealLogDb
{
    /// <inheritdoc />
    public partial class DisableForeignKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Ensure foreign keys are dropped if they exist
            migrationBuilder.DropForeignKey(
                name: "FK_MealLogs_Foods_FoodId",
                table: "MealLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_MealLogs_Users_UserId",
                table: "MealLogs");

            // Skip renaming tables or modifying primary keys

            migrationBuilder.AddForeignKey(
                name: "FK_MealLogs_Foods_FoodId",
                table: "MealLogs",
                column: "FoodId",
                principalTable: "Foods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MealLogs_Users_UserId",
                table: "MealLogs",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }



        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MealLogs_Food_FoodId",
                table: "MealLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_MealLogs_User_UserId",
                table: "MealLogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Food",
                table: "Food");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "Food",
                newName: "Foods");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Foods",
                table: "Foods",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MealLogs_Foods_FoodId",
                table: "MealLogs",
                column: "FoodId",
                principalTable: "Foods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MealLogs_Users_UserId",
                table: "MealLogs",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
