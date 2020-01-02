using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoccerStats.Contracts;
using SoccerStats.Models;

namespace SoccerStats.Repositories
{
    //private SoccerStatsContext _context;
    public class MatchRepository : IMatchRepository
    {
        private readonly SoccerStatsContext _context;
        
        public MatchRepository(SoccerStatsContext context)
        {
            _context = context;
        }
        public Match GetMatchById(int matchId)
        {
            Match thisMatch = _context.Matches.FirstOrDefault(match => match.Id == matchId);
            return thisMatch;
        }
        public Match CreateMatch(Match thisMatch)
        {
            _context.Matches.Add(thisMatch);
            _context.SaveChanges();
            return thisMatch;
        }
        public Match UpdateMatch(Match thisMatch)
        {
            if(_context.Matches.Find(thisMatch.Id) != null)
            {
                var updatedMatch = _context.Matches.Attach(thisMatch);
                updatedMatch.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
                return thisMatch;
            }
            return thisMatch;
        }

        public Match DeleteMatch(int matchId)
        {
            Match deletedMatch = _context.Matches.Find(matchId);
            if(deletedMatch != null)
            {
                _context.Remove(deletedMatch);
                _context.SaveChanges();
            }
            return deletedMatch;
        }

        public IEnumerable<Match> GetAllMatches()
        {
            return _context.Matches;
        }
    }
}
