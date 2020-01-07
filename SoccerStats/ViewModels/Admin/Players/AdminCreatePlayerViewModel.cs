using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoccerStats.Models;

namespace SoccerStats.ViewModels
{
    public class AdminCreatePlayerViewModel
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public Team Team { get; set; }
        public ICollection<MatchGoal> Goals { get; set; }
        public ICollection<MatchGoal> Assists { get; set; }
        public ICollection<MatchGoal> GoalsConceded { get; set; }
        public ICollection<PlayerMatchTime> Matches { get; set; }
    }
}
