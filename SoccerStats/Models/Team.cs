using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerStats.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }        
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
