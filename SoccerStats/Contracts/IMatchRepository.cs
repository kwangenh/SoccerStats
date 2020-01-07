using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoccerStats.Models;
using SoccerStats.ViewModels.Admin.Matches;

namespace SoccerStats.Contracts
{
    public interface IMatchRepository
    {
        public Match GetMatchById(int matchId);
        public Match CreateMatch(Match thisMatch);
        public Match UpdateMatch(Match thisMatch);
        public Match DeleteMatch(int matchId);
        public IEnumerable<Match> GetAllMatches();
        public Match CreateMatchModel(AdminCreateMatchViewModel viewModel);
        public Match CreateMatchModel(AdminEditMatchViewModel viewModel);
        public AdminCreateMatchViewModel CreateAdminCreateMatchViewModel(Match thisMatch);
        public AdminEditMatchViewModel CreateAdminEditMatchViewModel(Match thisMatch);
    }
}
