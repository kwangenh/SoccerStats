using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SoccerStats.Contracts;
using SoccerStats.Models;

namespace SoccerStats.Controllers
{
    public class TeamsController : Controller
    {
        private readonly ITeamRepository _teamRepository;
        public TeamsController(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IEnumerable<Team> GetAllTeams()
        {
            return _teamRepository.GetAllTeams();
        }

        public Team Team(int teamId)
        {
            return _teamRepository.GetTeamById(teamId);
        }
    }
}