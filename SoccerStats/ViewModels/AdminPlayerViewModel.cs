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
        public int Team_Id { get; set; }
        public int Goals { get; set; }
        public int Assist { get; set; }


        public Player ConvertToPlayer(AdminPlayerViewModel playerViewModel)
        {
            Player thisPlayer = new Player();

            thisPlayer.Name = playerViewModel.Name;
            thisPlayer.Birthday = playerViewModel.Birthday;
            thisPlayer.Team_Id = playerViewModel.Team_Id;
            thisPlayer.Goals = playerViewModel.Goals;
            thisPlayer.Assist = playerViewModel.Assist;

            return thisPlayer;
        }
    }


}
