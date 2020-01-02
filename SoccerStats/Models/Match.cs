using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerStats.Models
{
    public class Match
    {
        [Key]
        public int Id { get; set; }        
        public int Home_Goals { get; set; }
        public int Away_Goals { get; set; }
        /*
         *  hmm this may require a home and away team 
         *  class so each can have their own week number
         *  i'll just add prop instead on Match
         */
        public int Home_Match_Number { get; set; } 
        public int Away_Match_Number { get; set; }
        public DateTime Date { get; set; }
        public ICollection<MatchGoal> Events { get; set; }
        public ICollection<PlayerMatchTime> Players { get; set; }
        public Team HomeTeam { get; set; }
        public Team AwayTeam { get; set; }
    }
}
