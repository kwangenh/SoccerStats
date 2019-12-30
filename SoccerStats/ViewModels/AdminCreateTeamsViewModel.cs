    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoccerStats.Models;

namespace SoccerStats.ViewModels
{
    public class AdminCreateTeamsViewModel
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Ties { get; set; }
        public int Games_Played { get; set; }
        public int Goals_For { get; set; }
        public int Goals_Against { get; set; }

        public Team CreateTeamModel(AdminCreateTeamsViewModel thisViewModel)
        {
            Team thisTeam = new Team();

            thisTeam.Name = thisViewModel.Name;
            thisTeam.Points = thisViewModel.Points;
            thisTeam.Wins = thisViewModel.Wins;
            thisTeam.Losses = thisViewModel.Losses;
            thisTeam.Ties = thisViewModel.Ties;
            thisTeam.Games_Played = thisViewModel.Games_Played;
            thisTeam.Goals_For = thisViewModel.Goals_For;
            thisTeam.Goals_Against = thisViewModel.Goals_Against;

            return thisTeam;
        }

    }
} 
