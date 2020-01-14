using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SoccerStats.Migrations
{
    public partial class addedPlayerNumberAndFirstLastNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Matches_MatchId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_MatchId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "MatchId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Assist",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "Goals",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "Team_Id",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "Match_Id",
                table: "Player_Match_Time");

            migrationBuilder.DropColumn(
                name: "Player_Id",
                table: "Player_Match_Time");

            migrationBuilder.DropColumn(
                name: "Away_Team_Id",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "Home_Team_Id",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "Match_No",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "Assist_PID",
                table: "Match_Goals");

            migrationBuilder.DropColumn(
                name: "Condeding_GK_PID",
                table: "Match_Goals");

            migrationBuilder.DropColumn(
                name: "Match_Id",
                table: "Match_Goals");

            migrationBuilder.DropColumn(
                name: "Scorer_PID",
                table: "Match_Goals");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Teams",
                maxLength: 40,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Birthday",
                table: "Players",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Players",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Players",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "Players",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "Players",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlayerId",
                table: "Player_Match_Time",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AwayTeamId",
                table: "Matches",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Away_Match_Number",
                table: "Matches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HomeTeamId",
                table: "Matches",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Home_Match_Number",
                table: "Matches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AssistorId",
                table: "Match_Goals",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConcederId",
                table: "Match_Goals",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ScorerId",
                table: "Match_Goals",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Players_TeamId",
                table: "Players",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Player_Match_Time_PlayerId",
                table: "Player_Match_Time",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_AwayTeamId",
                table: "Matches",
                column: "AwayTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_HomeTeamId",
                table: "Matches",
                column: "HomeTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Match_Goals_AssistorId",
                table: "Match_Goals",
                column: "AssistorId");

            migrationBuilder.CreateIndex(
                name: "IX_Match_Goals_ConcederId",
                table: "Match_Goals",
                column: "ConcederId");

            migrationBuilder.CreateIndex(
                name: "IX_Match_Goals_ScorerId",
                table: "Match_Goals",
                column: "ScorerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Match_Goals_Players_AssistorId",
                table: "Match_Goals",
                column: "AssistorId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Match_Goals_Players_ConcederId",
                table: "Match_Goals",
                column: "ConcederId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Match_Goals_Players_ScorerId",
                table: "Match_Goals",
                column: "ScorerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Teams_AwayTeamId",
                table: "Matches",
                column: "AwayTeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Teams_HomeTeamId",
                table: "Matches",
                column: "HomeTeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Match_Time_Players_PlayerId",
                table: "Player_Match_Time",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Teams_TeamId",
                table: "Players",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Match_Goals_Players_AssistorId",
                table: "Match_Goals");

            migrationBuilder.DropForeignKey(
                name: "FK_Match_Goals_Players_ConcederId",
                table: "Match_Goals");

            migrationBuilder.DropForeignKey(
                name: "FK_Match_Goals_Players_ScorerId",
                table: "Match_Goals");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Teams_AwayTeamId",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Teams_HomeTeamId",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Player_Match_Time_Players_PlayerId",
                table: "Player_Match_Time");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Teams_TeamId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_TeamId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Player_Match_Time_PlayerId",
                table: "Player_Match_Time");

            migrationBuilder.DropIndex(
                name: "IX_Matches_AwayTeamId",
                table: "Matches");

            migrationBuilder.DropIndex(
                name: "IX_Matches_HomeTeamId",
                table: "Matches");

            migrationBuilder.DropIndex(
                name: "IX_Match_Goals_AssistorId",
                table: "Match_Goals");

            migrationBuilder.DropIndex(
                name: "IX_Match_Goals_ConcederId",
                table: "Match_Goals");

            migrationBuilder.DropIndex(
                name: "IX_Match_Goals_ScorerId",
                table: "Match_Goals");

            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "PlayerId",
                table: "Player_Match_Time");

            migrationBuilder.DropColumn(
                name: "AwayTeamId",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "Away_Match_Number",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "HomeTeamId",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "Home_Match_Number",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "AssistorId",
                table: "Match_Goals");

            migrationBuilder.DropColumn(
                name: "ConcederId",
                table: "Match_Goals");

            migrationBuilder.DropColumn(
                name: "ScorerId",
                table: "Match_Goals");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 40,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MatchId",
                table: "Teams",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Assist",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Goals",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Team_Id",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Match_Id",
                table: "Player_Match_Time",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Player_Id",
                table: "Player_Match_Time",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                name: "Match_No",
                table: "Matches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Assist_PID",
                table: "Match_Goals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Condeding_GK_PID",
                table: "Match_Goals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Match_Id",
                table: "Match_Goals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Scorer_PID",
                table: "Match_Goals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_MatchId",
                table: "Teams",
                column: "MatchId");

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
