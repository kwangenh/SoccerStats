using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoccerStats.Models;
using SoccerStats.ViewModels;

namespace SoccerStats.Utility
{
    public class TeamUtilities
    {        
        public AdminCreateTeamViewModel CreateAdminCreateTeamViewModel(Team thisTeam)
        {
            AdminCreateTeamViewModel thisViewModel = new AdminCreateTeamViewModel
            {
                Name = thisTeam.Name,
                Points = thisTeam.Points,
                Wins = thisTeam.Wins,
                Losses = thisTeam.Losses,
                Ties = thisTeam.Ties,
                Games_Played = thisTeam.Games_Played,
                Goals_For = thisTeam.Goals_For,
                Goals_Against = thisTeam.Goals_Against
            };

            return thisViewModel;

        }

        public AdminEditTeamViewModel CreateAdminEditTeamViewModel(Team thisTeam)
        {
            AdminEditTeamViewModel thisViewModel = new AdminEditTeamViewModel
            {
                Id = thisTeam.Id,
                Name = thisTeam.Name,
                Points = thisTeam.Points,
                Wins = thisTeam.Wins,
                Losses = thisTeam.Losses,
                Ties = thisTeam.Ties,
                Games_Played = thisTeam.Games_Played,
                Goals_For = thisTeam.Goals_For,
                Goals_Against = thisTeam.Goals_Against
            };

            return thisViewModel;
        }

        
      public Team CreateTeamModel(AdminEditTeamViewModel thisViewModel)
        {
            var thisTeam = new Team
            {
                Id = thisViewModel.Id,
                Name = thisViewModel.Name,
                Points = thisViewModel.Points,
                Wins = thisViewModel.Wins,
                Losses = thisViewModel.Losses,
                Ties = thisViewModel.Ties,
                Games_Played = thisViewModel.Games_Played,
                Goals_For = thisViewModel.Goals_For,
                Goals_Against = thisViewModel.Goals_Against
            };

            return thisTeam;
        }

        public Team CreateTeamModel(AdminCreateTeamViewModel thisViewModel)
        {
            var thisTeam = new Team
            {
                Name = thisViewModel.Name,
                Points = thisViewModel.Points,
                Wins = thisViewModel.Wins,
                Losses = thisViewModel.Losses,
                Ties = thisViewModel.Ties,
                Games_Played = thisViewModel.Games_Played,
                Goals_For = thisViewModel.Goals_For,
                Goals_Against = thisViewModel.Goals_Against
            };

            return thisTeam;
        }
        
    }
}
