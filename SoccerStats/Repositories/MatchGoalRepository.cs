using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoccerStats.Models;
using SoccerStats.Contracts;

namespace SoccerStats.Repositories
{
    public class MatchGoalRepository : IMatchGoalRepository
    {
        private readonly SoccerStatsContext _context;
        public MatchGoalRepository(SoccerStatsContext context)
        {
            _context = context;
        }
        public MatchGoal GetMatchGoalsById(int matchGoalId)
        {
            return _context.Match_Goals.Find(matchGoalId);
        }
        public IEnumerable<MatchGoal> GetMatchGoalsByMatchId(int matchId)
        {
            return _context.Match_Goals.Where(match => match.Match_Id == matchId);
        }
        public MatchGoal AddMatchGoal(MatchGoal matchGoal)
        {
            _context.Match_Goals.Add(matchGoal);
            return matchGoal;
        }

        public MatchGoal EditMatchGoal(MatchGoal thisMatchGoal)
        {
            if(_context.Match_Goals.Find(thisMatchGoal.Id) != null)
            {
                var updatedMatchGoal = _context.Match_Goals.Attach(thisMatchGoal);
                updatedMatchGoal.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
                return thisMatchGoal;
            }
            return thisMatchGoal;
        }
    }
}
