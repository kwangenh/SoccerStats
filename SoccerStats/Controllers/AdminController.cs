using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SoccerStats.Models;
using SoccerStats.Contracts;

namespace SoccerStats.Controllers
{
    public class AdminController : Controller
    {
        private readonly ITeamRepository _teamRepository;
        private readonly IPlayerRepository _playerRepository;
        private readonly IMatchRepository _matchRepository;

        public AdminController(IPlayerRepository playerRepository, ITeamRepository teamRepository, IMatchRepository matchRepository)
        {
            _playerRepository = playerRepository;
            _teamRepository = teamRepository;
            _matchRepository = matchRepository;
        }

        public ViewResult Teams()
        {
            return View();
        }

        public ViewResult Players()
        {
            return View();
        }

        public ViewResult Matches()
        {
            return View();
        }


        public Team CreateTeam(Team thisTeam)
        {
            _teamRepository.CreateTeam(thisTeam);
            return thisTeam;
        }

        public Team DeleteTeam(int teamId)
        {
            return _teamRepository.DeleteTeam(teamId);            
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