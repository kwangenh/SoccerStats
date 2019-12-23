using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoccerStats.Models;

namespace SoccerStats.Contracts
{
    public interface IMatchGoalRepository
    {        
        public MatchGoal GetMatchGoalsById(int match_goal_id);
        public IEnumerable<MatchGoal> GetMatchGoalsByMatchId(int match_id);
        public MatchGoal AddMatchGoal(MatchGoal match_goal);
    }
}
