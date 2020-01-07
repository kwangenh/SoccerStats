using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoccerStats.Models;

namespace SoccerStats.ViewModels.Admin.Matches
{
    public class AdminCreateMatchViewModel
    {
        public int Home_Goals { get; set; }
        public int Away_Goals { get; set; }
        public int Home_Match_Number { get; set; }
        public int Away_Match_Number { get; set; }
        public DateTime Date { get; set; }
        public ICollection<MatchGoal> Events { get; set; }
        public ICollection<PlayerMatchTime> Players { get; set; }
        public Team HomeTeam { get; set; }
        public Team AwayTeam { get; set; }
    }
}
