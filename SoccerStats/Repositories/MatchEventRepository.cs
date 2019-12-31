using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoccerStats.Models;
using SoccerStats.Contracts;

namespace SoccerStats.Repositories
{
    public class MatchEventRepository // : IMatchGoalRepository
    {/*
        private readonly SoccerStatsContext _context;
        public MatchEventRepository(SoccerStatsContext context)
        {
            _context = context;
        }
        public EventGoal GetMatchGoalsById(int matchGoalId)
        {
            return _context.Match_Goals.Find(matchGoalId);
        }
        /*public IEnumerable<MatchEvent> GetMatchGoalsByMatchId(int matchId)
        {
            return _context.Match_Goals.Where(match => match.Match.Id == matchId);
        }
        
        public EventGoal AddMatchGoal(EventGoal matchGoal)
        {
            _context.Match_Goals.Add(matchGoal);
            return matchGoal;
        }

        public EventGoal EditMatchGoal(EventGoal thisMatchGoal)
        {
            if (_context.Match_Goals.Find(thisMatchGoal.Id) != null)
            {
                var updatedMatchGoal = _context.Match_Goals.Attach(thisMatchGoal);
                updatedMatchGoal.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
                return thisMatchGoal;
            }
            return thisMatchGoal;
        }*/
    }
}
