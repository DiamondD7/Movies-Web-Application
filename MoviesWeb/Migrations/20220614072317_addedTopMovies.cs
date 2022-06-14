using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesWeb.Migrations
{
    public partial class addedTopMovies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TopMoviesDB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MoviePrice = table.Column<int>(type: "int", nullable: false),
                    ReleasedDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovieName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovieDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopMoviesDB", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TopMoviesDB");
        }
    }
}
