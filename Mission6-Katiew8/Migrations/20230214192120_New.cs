using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission6_Katiew8.Migrations
{
    public partial class New : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Rating",
                table: "Responses",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Action, Adventure, Drama", "Ridley Scott", false, "", "", "R", "Gladiator", 2000 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Comedy/Mockumentary", "Christopher Guest", false, "", "", "PG-13", "Best in Show", 2000 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Romantic Comedy", "Savage Steve Holland", false, "", "", "PG", "Better Off Dead", 1985 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "MovieId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "MovieId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "MovieId",
                keyValue: 3);

            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "Responses",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
