using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SoccerStats.Migrations
{
    public partial class initialBuild : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Home_Team_Id = table.Column<int>(nullable: false),
                    Away_Team_Id = table.Column<int>(nullable: false),
                    Home_Goals = table.Column<int>(nullable: false),
                    Away_Goals = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Match_No = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Team_Id = table.Column<int>(nullable: false),
                    Goals = table.Column<int>(nullable: false),
                    Assist = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Match_Goals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Match_Id = table.Column<int>(nullable: false),
                    Scorer_PID = table.Column<int>(nullable: false),
                    Assist_PID = table.Column<int>(nullable: false),
                    Condeding_GK_PID = table.Column<int>(nullable: false),
                    Time = table.Column<int>(nullable: false),
                    MatchId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Match_Goals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Match_Goals_Matches_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Matches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Player_Match_Time",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Player_Id = table.Column<int>(nullable: false),
                    Match_Id = table.Column<int>(nullable: false),
                    Start_Time = table.Column<int>(nullable: false),
                    End_Time = table.Column<int>(nullable: false),
                    MatchId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player_Match_Time", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Player_Match_Time_Matches_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Matches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Points = table.Column<int>(nullable: false),
                    Wins = table.Column<int>(nullable: false),
                    Losses = table.Column<int>(nullable: false),
                    Ties = table.Column<int>(nullable: false),
                    Games_Played = table.Column<int>(nullable: false),
                    Goals_For = table.Column<int>(nullable: false),
                    Goals_Against = table.Column<int>(nullable: false),
                    MatchId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teams_Matches_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Matches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Match_Goals_MatchId",
                table: "Match_Goals",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_Player_Match_Time_MatchId",
                table: "Player_Match_Time",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_MatchId",
                table: "Teams",
                column: "MatchId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Match_Goals");

            migrationBuilder.DropTable(
                name: "Player_Match_Time");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Matches");
        }
    }
}
