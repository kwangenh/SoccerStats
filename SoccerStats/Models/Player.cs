using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerStats.Models
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public Team Team { get; set; }

        [InverseProperty("Scorer")]
        public ICollection<MatchGoal> Goals { get; set; }

        [InverseProperty("Assistor")]
        public ICollection<MatchGoal> Assists { get; set; }

        [InverseProperty("Conceder")]
        public ICollection<MatchGoal> GoalsConceded { get; set; }
        public ICollection<PlayerMatchTime> Matches { get; set; }
    }
}
