using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission6_nsweiler.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    movieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    category = table.Column<string>(nullable: false),
                    title = table.Column<string>(nullable: false),
                    year = table.Column<string>(nullable: false),
                    director = table.Column<string>(nullable: false),
                    rating = table.Column<string>(nullable: false),
                    lentTo = table.Column<string>(nullable: true),
                    notes = table.Column<string>(maxLength: 25, nullable: true),
                    edited = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.movieId);
                });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "movieId", "category", "director", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 1, "Action", "", false, "Styles Weiler", "", "PG-13", "Avengers", "2012" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "movieId", "category", "director", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 2, "Action", "George Lucas", false, "Styles Weiler", "", "PG-13", "Star Wars", "1977" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "movieId", "category", "director", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 3, "Action", "Rocky", false, "Styles Weiler", "", "PG", "Rocky", "1977" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");
        }
    }
}
