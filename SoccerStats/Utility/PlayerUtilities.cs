using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoccerStats.Models;
using SoccerStats.ViewModels;

namespace SoccerStats.Utility
{
    public class PlayerUtilities
    {
        public Player CreatePlayerModel(AdminCreatePlayerViewModel thisViewModel)
        {
            Player player = new Player
            {
                Name = thisViewModel.Name,
                Assists = thisViewModel.Assists,
                Goals = thisViewModel.Goals,
                GoalsConceded = thisViewModel.GoalsConceded,
                Birthday = thisViewModel.Birthday,
                Matches = thisViewModel.Matches,
                Team = thisViewModel.Team
            };

            return player;
        }
    }
}
