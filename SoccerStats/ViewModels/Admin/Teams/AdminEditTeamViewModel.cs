using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerStats.ViewModels.Admin.Teams
{
    public class AdminEditTeamViewModel : AdminCreateTeamViewModel
    {
        [HiddenInput]
        public int Id { get; set; }
    }
}
