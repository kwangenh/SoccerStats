using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoccerStats.Models;

namespace SoccerStats.Contracts
{
    public interface ITeamRepository
    {
        public Team GetTeamById(int teamId);
        public Team DeleteTeam(int teamId);
        public Team UpdateTeam(Team thisTeam);
        public Team CreateTeam(Team thisTeam);
        public IEnumerable<Team> GetAllTeams();
        //public IEnumerable<Player> GetPlayersOnTeam(int teamId);
    }
}
