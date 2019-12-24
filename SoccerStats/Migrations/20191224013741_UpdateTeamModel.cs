using Microsoft.EntityFrameworkCore.Migrations;

namespace SoccerStats.Migrations
{
    public partial class UpdateTeamModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Players_Team_Id",
                table: "Players",
                column: "Team_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Teams_Team_Id",
                table: "Players",
                column: "Team_Id",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Teams_Team_Id",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_Team_Id",
                table: "Players");
        }
    }
}
