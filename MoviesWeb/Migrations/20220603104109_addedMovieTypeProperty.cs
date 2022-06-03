using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesWeb.Migrations
{
    public partial class addedMovieTypeProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MovieType",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MovieType",
                table: "Order");
        }
    }
}
