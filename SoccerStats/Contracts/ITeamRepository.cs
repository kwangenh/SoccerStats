using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoccerStats.Models;
using SoccerStats.ViewModels;
using SoccerStats.ViewModels.Admin.Teams;

namespace SoccerStats.Contracts
{
    public interface ITeamRepository
    {
        public Team GetTeamById(int teamId);
        public Team DeleteTeam(int teamId);
        public Team UpdateTeam(Team thisTeam);
        public Team CreateTeam(Team thisTeam);
        public IEnumerable<Team> GetAllTeams();
        public Team CreateTeamModel(AdminCreateTeamViewModel viewModel);
        public Team CreateTeamModel(AdminEditTeamViewModel viewModel);
        public AdminCreateTeamViewModel CreateAdminCreateTeamViewModel(Team thisTeam);
        public AdminEditTeamViewModel CreateAdminEditTeamViewModel(Team thisTeam);
        //public IEnumerable<Player> GetPlayersOnTeam(int teamId);
    }
}
