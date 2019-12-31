using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerStats.Models
{
    public class MatchGoal
    {
        public int Id { get; set; }
        public int Time { get; set; }
        public Match Match { get; set; }
        public Player Scorer { get; set; }
        public Player Assistor { get; set; }
        public Player Conceder { get; set; }
    }
}
