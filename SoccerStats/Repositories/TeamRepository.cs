using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoccerStats.Contracts;
using SoccerStats.Models;

namespace SoccerStats.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private readonly SoccerStatsContext _context;

        public TeamRepository(SoccerStatsContext context)
        {
            _context = context;
        }
        public Team GetTeamById(int teamId)
        {
            Team thisTeam = _context.Teams.FirstOrDefault(team => team.Id == teamId);
            return thisTeam;
        }
        public Team CreateTeam(Team thisTeam)
        {
            _context.Teams.Add(thisTeam);
            return thisTeam;
        }
        public Team UpdateTeam(Team thisTeam)
        {
            if (_context.Teams.Find(thisTeam.Id) != null)
            {
                var updatedTeam = _context.Teams.Attach(thisTeam);
                updatedTeam.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
                return thisTeam;
            }
            return thisTeam;
        }

        public Team DeleteTeam(int teamId)
        {
            Team deletedTeam = _context.Teams.Find(teamId);
            if (deletedTeam != null)
            {
                _context.Remove(deletedTeam);
                _context.SaveChanges();
            }
            return deletedTeam;
        }

        public IEnumerable<Team> GetAllTeams()
        {
            return _context.Teams;
        }
    }
}
