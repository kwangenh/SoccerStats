using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoccerStats.Models;

namespace SoccerStats.ViewModels
{
    public class AdminCreateTeamViewModel
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Ties { get; set; }
        public int Games_Played { get; set; }
        public int Goals_For { get; set; }
        public int Goals_Against { get; set; }
    }
}
