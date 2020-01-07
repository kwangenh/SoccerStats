using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoccerStats.Contracts;
using SoccerStats.Models;
using SoccerStats.ViewModels.Admin.Matches;

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

        public Match CreateMatchModel(AdminCreateMatchViewModel viewModel)
        {
            Match match = new Match
            {
                HomeTeam = viewModel.HomeTeam,
                AwayTeam = viewModel.AwayTeam,
                Home_Goals = viewModel.Home_Goals,
                Away_Goals = viewModel.Away_Goals,
                Home_Match_Number = viewModel.Home_Match_Number,
                Away_Match_Number = viewModel.Away_Match_Number,
                Date = viewModel.Date,
                Events = viewModel.Events,
                Players = viewModel.Players                
            };

            return match;
        
        }
        public Match CreateMatchModel(AdminEditMatchViewModel viewModel)
        {
            Match match = new Match
            {
                Id = viewModel.Id,
                HomeTeam = viewModel.HomeTeam,
                AwayTeam = viewModel.AwayTeam,
                Home_Goals = viewModel.Home_Goals,
                Away_Goals = viewModel.Away_Goals,
                Home_Match_Number = viewModel.Home_Match_Number,
                Away_Match_Number = viewModel.Away_Match_Number,
                Date = viewModel.Date,
                Events = viewModel.Events,
                Players = viewModel.Players
            };

            return match;
        }
        public AdminCreateMatchViewModel CreateAdminCreateMatchViewModel(Match thisMatch)
        {
            AdminCreateMatchViewModel viewModel = new AdminCreateMatchViewModel
            {
                HomeTeam = thisMatch.HomeTeam,
                AwayTeam = thisMatch.AwayTeam,
                Home_Goals = thisMatch.Home_Goals,
                Away_Goals = thisMatch.Away_Goals,
                Home_Match_Number = thisMatch.Home_Match_Number,
                Away_Match_Number = thisMatch.Away_Match_Number,
                Date = thisMatch.Date,
                Events = thisMatch.Events,
                Players = thisMatch.Players
            };

            return viewModel;
        }
        public AdminEditMatchViewModel CreateAdminEditMatchViewModel(Match thisMatch)
        {
            AdminEditMatchViewModel viewModel = new AdminEditMatchViewModel
            {
                Id = thisMatch.Id,
                HomeTeam = thisMatch.HomeTeam,
                AwayTeam = thisMatch.AwayTeam,
                Home_Goals = thisMatch.Home_Goals,
                Away_Goals = thisMatch.Away_Goals,
                Home_Match_Number = thisMatch.Home_Match_Number,
                Away_Match_Number = thisMatch.Away_Match_Number,
                Date = thisMatch.Date,
                Events = thisMatch.Events,
                Players = thisMatch.Players
            };

            return viewModel;
        }
    }
}
