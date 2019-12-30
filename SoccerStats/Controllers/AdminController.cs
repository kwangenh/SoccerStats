using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SoccerStats.Models;
using SoccerStats.Contracts;
using SoccerStats.ViewModels;

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


        public AdminCreateTeamsViewModel CreateTeam(AdminCreateTeamsViewModel thisTeamViewModel)
        {
            // is this even good?

            // should i just rename AdminCreatTeamsViewModel --> AdminViewModels instead and use same viewmodel thorughout page?
            // using constructor each time for each unique viewmodel will get cumbersone
            //Team thisTeam = thisTeamViewModel.CreateTeamModel(thisTeamViewModel);
            Team thisTeam = new Team(
                thisTeamViewModel.Name,
                thisTeamViewModel.Points,
                thisTeamViewModel.Wins,
                thisTeamViewModel.Losses,
                thisTeamViewModel.Ties,
                thisTeamViewModel.Games_Played,
                thisTeamViewModel.Goals_For,
                thisTeamViewModel.Goals_Against
                );
            _teamRepository.CreateTeam(thisTeam);
            
            // need to create utility to convert AdminCreateTeamsViewModel.cs --> Team.cs
            return thisTeamViewModel;
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