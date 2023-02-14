using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission06_dc455.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    EntryID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
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
                    table.PrimaryKey("PK_responses", x => x.EntryID);
                });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "EntryID", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Action/Adventure", "Peter Jackson", false, null, "Best battle ever!", "PG-13", "The Lord of the Rings: The Two Towers", 2004 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "EntryID", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Action/Adventure", "Joe/Anthony Russo", false, null, "Dope movie", "PG-13", "The Gray Man", 2022 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "EntryID", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Action/Adventure", "Martin Campbell", false, null, "GOAT", "PG-13", "Casino Royale", 2006 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");
        }
    }
}
