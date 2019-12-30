using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoccerStats.Models;

namespace SoccerStats.ViewModels
{
    public class AdminPlayerViewModel
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }        
        public Team Team { get; set; }
        public ICollection<MatchGoal> Goals { get; set; }
        public ICollection<MatchGoal> Assists { get; set; }
        public ICollection<MatchGoal> GoalsConceded { get; set; }

        public Player ConvertToPlayer(AdminPlayerViewModel playerViewModel)
        {
            Player thisPlayer = new Player();

            thisPlayer.Name = playerViewModel.Name;
            thisPlayer.Birthday = playerViewModel.Birthday;
            thisPlayer.Team.Id = playerViewModel.Team.Id;
            thisPlayer.Goals = playerViewModel.Goals;
            thisPlayer.Assists = playerViewModel.Assists;
            thisPlayer.GoalsConceded = playerViewModel.GoalsConceded;

            return thisPlayer;
        }
    }


}
