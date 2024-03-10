using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    adult = table.Column<bool>(nullable: false),
                    backdrop_path = table.Column<string>(nullable: true),
                    budget = table.Column<int>(nullable: false),
                    homepage = table.Column<string>(nullable: true),
                    imdb_id = table.Column<string>(nullable: true),
                    original_language = table.Column<string>(nullable: true),
                    original_title = table.Column<string>(nullable: true),
                    overview = table.Column<string>(nullable: true),
                    popularity = table.Column<float>(nullable: false),
                    poster_path = table.Column<string>(nullable: true),
                    release_date = table.Column<string>(nullable: true),
                    revenue = table.Column<int>(nullable: false),
                    runtime = table.Column<int>(nullable: false),
                    status = table.Column<string>(nullable: true),
                    tagline = table.Column<string>(nullable: true),
                    title = table.Column<string>(nullable: true),
                    video = table.Column<bool>(nullable: false),
                    vote_average = table.Column<float>(nullable: false),
                    vote_count = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    Movieid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.id);
                    table.ForeignKey(
                        name: "FK_Genre_Movies_Movieid",
                        column: x => x.Movieid,
                        principalTable: "Movies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Production_Companies",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    logo_path = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    origin_country = table.Column<string>(nullable: true),
                    Movieid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Production_Companies", x => x.id);
                    table.ForeignKey(
                        name: "FK_Production_Companies_Movies_Movieid",
                        column: x => x.Movieid,
                        principalTable: "Movies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Production_Countries",
                columns: table => new
                {
                    iso_3166_1 = table.Column<string>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    Movieid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Production_Countries", x => x.iso_3166_1);
                    table.ForeignKey(
                        name: "FK_Production_Countries_Movies_Movieid",
                        column: x => x.Movieid,
                        principalTable: "Movies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Spoken_Languages",
                columns: table => new
                {
                    english_name = table.Column<string>(nullable: false),
                    iso_639_1 = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    Movieid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spoken_Languages", x => x.english_name);
                    table.ForeignKey(
                        name: "FK_Spoken_Languages_Movies_Movieid",
                        column: x => x.Movieid,
                        principalTable: "Movies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Genre_Movieid",
                table: "Genre",
                column: "Movieid");

            migrationBuilder.CreateIndex(
                name: "IX_Production_Companies_Movieid",
                table: "Production_Companies",
                column: "Movieid");

            migrationBuilder.CreateIndex(
                name: "IX_Production_Countries_Movieid",
                table: "Production_Countries",
                column: "Movieid");

            migrationBuilder.CreateIndex(
                name: "IX_Spoken_Languages_Movieid",
                table: "Spoken_Languages",
                column: "Movieid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropTable(
                name: "Production_Companies");

            migrationBuilder.DropTable(
                name: "Production_Countries");

            migrationBuilder.DropTable(
                name: "Spoken_Languages");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
