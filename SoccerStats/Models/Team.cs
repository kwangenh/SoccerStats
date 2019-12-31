using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerStats.Models
{
    public class Team
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Ties { get; set; }
        public int Games_Played { get; set; }
        public int Goals_For { get; set; }
        public int Goals_Against { get; set; }
        public ICollection<Player> Players { get; set; }
        [InverseProperty("HomeTeam")]
        public ICollection<Match> HomeMatches { get; set; }
        [InverseProperty("AwayTeam")]
        public ICollection<Match> AwayMatches { get; set; }

        public Team(string name, int points, int wins, int losses, int ties, int gamesPlayed, int goalsFor, int goalsAgainst)
        {
            this.Name = name;
            this.Points = points;
            this.Wins = wins;
            this.Losses = losses;
            this.Ties = ties;
            this.Games_Played = gamesPlayed;
            this.Goals_For = goalsFor;
            this.Goals_Against = goalsAgainst;
        }

        public Team()
        {
        }
    }
}
