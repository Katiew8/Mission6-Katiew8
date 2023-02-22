using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission6_Katiew8.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.MovieId);
                    table.ForeignKey(
                        name: "FK_Responses_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Category" },
                values: new object[] { 1, "Action" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Category" },
                values: new object[] { 2, "Adventure" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Category" },
                values: new object[] { 3, "Comedy" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Category" },
                values: new object[] { 4, "Drama" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Category" },
                values: new object[] { 5, "Fantasy" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Category" },
                values: new object[] { 6, "Horror" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Category" },
                values: new object[] { 7, "Musical" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Category" },
                values: new object[] { 8, "Mystery" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Category" },
                values: new object[] { 9, "Romance" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Category" },
                values: new object[] { 10, "Rom-Com" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Category" },
                values: new object[] { 11, "Science Fiction" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Category" },
                values: new object[] { 12, "Sports" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Category" },
                values: new object[] { 13, "Thriller" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Category" },
                values: new object[] { 14, "Western" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "CategoryId", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, 1, "Ridley Scott", false, "", "", "R", "Gladiator", 2000 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "CategoryId", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, 3, "Christopher Guest", false, "", "", "PG-13", "Best in Show", 2000 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "CategoryId", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, 3, "Savage Steve Holland", false, "", "", "PG", "Better Off Dead", 1985 });

            migrationBuilder.CreateIndex(
                name: "IX_Responses_CategoryId",
                table: "Responses",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
