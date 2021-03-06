﻿using System;
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
        public DateTime Date { get; set; }
        public int Match_No { get; set; } 
        public ICollection<Team> Teams { get; set; }
        public ICollection<MatchGoal> Goals { get; set; }
        public ICollection<PlayerMatchTime> Players { get; set; }
    }
}
