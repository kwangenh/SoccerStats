using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        // this needs to be MatchGoalViewModel instead since i wont be calling the actual DB
        public ICollection<MatchGoal> Events { get; set; }
        // this needs to be PlayerMatchTimeViewModel instead since i wont be calling the actual DB
        public ICollection<PlayerMatchTime> Players { get; set; }
        public List<SelectListItem> Home_Team { get; set; }
        public List<SelectListItem> Away_Team { get; set; }
    }
}
