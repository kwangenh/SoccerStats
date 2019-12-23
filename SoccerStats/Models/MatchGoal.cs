using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerStats.Models
{
    public class MatchGoal
    {
        [Key]
        public int Id { get; set; }
        public int Match_Id { get; set; } // need foreign key to Matches.cs
        public int Scorer_PID { get; set; }
        public int Assist_PID { get; set; } // need to allow for null
        public int Condeding_GK_PID { get; set; }
        public int Time { get; set; }
    }
}
