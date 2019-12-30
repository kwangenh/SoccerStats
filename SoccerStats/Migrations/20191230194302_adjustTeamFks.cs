using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SoccerStats.Migrations
{
    public partial class adjustTeamFks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Match_Goals_Matches_MatchId",
                table: "Match_Goals");

            migrationBuilder.DropForeignKey(
                name: "FK_Player_Match_Time_Matches_MatchId",
                table: "Player_Match_Time");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Matches_MatchId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_MatchId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Player_Match_Time_MatchId",
                table: "Player_Match_Time");

            migrationBuilder.DropIndex(
                name: "IX_Match_Goals_MatchId",
                table: "Match_Goals");

            migrationBuilder.DropColumn(
                name: "MatchId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Team_Id",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "MatchId",
                table: "Player_Match_Time");

            migrationBuilder.DropColumn(
                name: "Away_Team_Id",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "Home_Team_Id",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "MatchId",
                table: "Match_Goals");

            migrationBuilder.AddColumn<int>(
                name: "Team_Id",
                table: "Teams",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Birthday",
                table: "Players",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Players",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "Players",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_Team_Id",
                table: "Teams",
                column: "Team_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Players_TeamId",
                table: "Players",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Player_Match_Time_Match_Id",
                table: "Player_Match_Time",
                column: "Match_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Match_Goals_Match_Id",
                table: "Match_Goals",
                column: "Match_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Match_Goals_Matches_Match_Id",
                table: "Match_Goals",
                column: "Match_Id",
                principalTable: "Matches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Match_Time_Matches_Match_Id",
                table: "Player_Match_Time",
                column: "Match_Id",
                principalTable: "Matches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Teams_TeamId",
                table: "Players",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Matches_Team_Id",
                table: "Teams",
                column: "Team_Id",
                principalTable: "Matches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Match_Goals_Matches_Match_Id",
                table: "Match_Goals");

            migrationBuilder.DropForeignKey(
                name: "FK_Player_Match_Time_Matches_Match_Id",
                table: "Player_Match_Time");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Teams_TeamId",
                table: "Players");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Matches_Team_Id",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_Team_Id",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Players_TeamId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Player_Match_Time_Match_Id",
                table: "Player_Match_Time");

            migrationBuilder.DropIndex(
                name: "IX_Match_Goals_Match_Id",
                table: "Match_Goals");

            migrationBuilder.DropColumn(
                name: "Team_Id",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "Players");

            migrationBuilder.AddColumn<int>(
                name: "MatchId",
                table: "Teams",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Team_Id",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MatchId",
                table: "Player_Match_Time",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Away_Team_Id",
                table: "Matches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Home_Team_Id",
                table: "Matches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MatchId",
                table: "Match_Goals",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_MatchId",
                table: "Teams",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_Player_Match_Time_MatchId",
                table: "Player_Match_Time",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_Match_Goals_MatchId",
                table: "Match_Goals",
                column: "MatchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Match_Goals_Matches_MatchId",
                table: "Match_Goals",
                column: "MatchId",
                principalTable: "Matches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Match_Time_Matches_MatchId",
                table: "Player_Match_Time",
                column: "MatchId",
                principalTable: "Matches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Matches_MatchId",
                table: "Teams",
                column: "MatchId",
                principalTable: "Matches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
