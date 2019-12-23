using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerStats.Models
{
    public class PlayerMatchTime
    {
        [Key]
        public int Id { get; set; }
        public int Player_Id { get; set; }
        public int Match_Id { get; set; }
        public int Start_Time { get; set; }
        public int End_Time { get; set; }
    }
}
