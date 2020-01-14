using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using SoccerStats.Models;

namespace SoccerStats.ViewModels.Admin.Players
{

    public class AdminCreatePlayerViewModel
    {
        public AdminCreatePlayerViewModel() { }

        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName {get;set;}
        public DateTime Birthday { get; set; }
        public Team Team { get; set; }
        public int Number { get; set; }
        public List<SelectListItem> AvailableTeams { get; set; }
    }
}
