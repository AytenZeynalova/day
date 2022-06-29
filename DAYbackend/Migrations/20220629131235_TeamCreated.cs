using Microsoft.EntityFrameworkCore.Migrations;

namespace DAYbackend.Migrations
{
    public partial class TeamCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Img = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Desc = table.Column<string>(nullable: true),
                    TwttrUrl = table.Column<string>(nullable: true),
                    FbUrl = table.Column<string>(nullable: true),
                    InstaUrl = table.Column<string>(nullable: true),
                    LinkdnUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
