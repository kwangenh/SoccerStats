using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerStats.Models
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        //need to set foreign key here
        public int Team_Id { get; set; }
        public int Goals { get; set; }
        public int Assist { get; set; }
        //public string Position { get; set; } will add after creating position table ? 
    }
}
