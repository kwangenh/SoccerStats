using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SoccerStats.Models;
using SoccerStats.Contracts;
using SoccerStats.ViewModels;
using SoccerStats.Utility;

namespace SoccerStats.Controllers
{
    public class AdminController : Controller
    {
        private readonly ITeamRepository _teamRepository;
        private readonly IPlayerRepository _playerRepository;
        private readonly IMatchRepository _matchRepository;

        private readonly TeamUtilities _teamUtilities = new TeamUtilities();

        public AdminController(IPlayerRepository playerRepository, ITeamRepository teamRepository, IMatchRepository matchRepository)
        {
            _playerRepository = playerRepository;
            _teamRepository = teamRepository;
            _matchRepository = matchRepository;
        }

        public ViewResult Teams()
        {
            IEnumerable<Team> teams = _teamRepository.GetAllTeams();
            return View(teams);
        }

        public ViewResult EditTeam(int id)
        {
            Team thisTeam = _teamRepository.GetTeamById(id);
            return View(thisTeam);            
        }

        public ViewResult Players()
        {
            return View();
        }

        public ViewResult Matches()
        {
            return View();
        }


        public ViewResult CreateTeam(AdminCreateTeamViewModel thisTeamViewModel)
        {
            Team thisTeam = _teamUtilities.CreateTeamModel(thisTeamViewModel);
            _teamRepository.CreateTeam(thisTeam);

            // call the Teams view after creating this record
            return Teams();
        }

        public ViewResult DeleteTeam(int teamId)
        {
            _teamRepository.DeleteTeam(teamId);

            return Teams(); 
        }

        public Player CreatePlayer(Player thisPlayer)
        {
            return _playerRepository.CreatePlayer(thisPlayer);
        }

        public Player DeletePlayer(int playerId)        
        {
            return _playerRepository.DeletePlayer(playerId);
        }

        public Match CreateMatch(Match thisMatch)
        {
            return _matchRepository.CreateMatch(thisMatch);
        }

        public Match DeleteMatch(int matchId)
        {
            return _matchRepository.DeleteMatch(matchId);
        }
    }
}