using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using SoccerStats.Models;

namespace SoccerStats.ViewModels.Admin.Players
{
    public class AdminCreatePlayerViewModel
    {   
        public string FirstName { get; set; }
        public string LastName {get;set;}
        public DateTime Birthday { get; set; }
        public Team Team { get; set; }
        public List<SelectListItem> AvailableTeams { get; set; }
        /*public ICollection<MatchGoal> Goals { get; set; }
        public ICollection<MatchGoal> Assists { get; set; }
        public ICollection<MatchGoal> GoalsConceded { get; set; }
        public ICollection<PlayerMatchTime> Matches { get; set; }
        */
    }
}
