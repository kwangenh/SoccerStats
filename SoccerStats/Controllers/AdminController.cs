﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SoccerStats.Models;
using SoccerStats.Contracts;
using SoccerStats.ViewModels.Admin.Teams;
using SoccerStats.ViewModels.Admin.Matches;
using SoccerStats.ViewModels.Admin.Players;

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
            IEnumerable<Team> teams = _teamRepository.GetAllTeams();
            //IEnumerable<AdminTeamsViewModel> teamViewModels
            foreach(var team in teams)
            {

            }
            return View(teams);
        }

        public ViewResult CreateTeam(AdminCreateTeamViewModel thisTeamViewModel)
        {
            Team thisTeam = _teamRepository.CreateTeamModel(thisTeamViewModel);
            _teamRepository.CreateTeam(thisTeam);

            // call the Teams view after creating this record
            return Teams();
        }

        public ViewResult CreateTeam()
        {
            return View();
        }

        public ViewResult DeleteTeam(int teamId)
        {
            _teamRepository.DeleteTeam(teamId);
            return Teams();
        }

        public ViewResult EditTeam(int id)
        {
            Team thisTeam = _teamRepository.GetTeamById(id);
            return View(thisTeam);
        }

        public ViewResult EditTeam(Team thisTeam)
        {
            _teamRepository.UpdateTeam(thisTeam);
            return Teams();
        }

        public ViewResult Players()
        {
            IEnumerable<Player> players = _playerRepository.GetAllPlayers();
            return View(players);
        }

        public ViewResult CreatePlayer(Player thisPlayer)
        {
            _playerRepository.CreatePlayer(thisPlayer);
            return Players();
        }

        public ViewResult CreatePlayer()
        {
            return View();
        }

        public ViewResult DeletePlayer(int playerId)
        {
            _playerRepository.DeletePlayer(playerId);
            return Players();
        }
        
        public ViewResult EditPlayer(int id)
        {
            Player thisPlayer = _playerRepository.GetPlayerById(id);
            return View(thisPlayer);
        }

        public ViewResult EditPlayer(Player thisPlayer)
        {
            _playerRepository.UpdatePlayer(thisPlayer);
            return Players();
        }

        public ViewResult Matches()
        {
            IEnumerable<Match> matches = _matchRepository.GetAllMatches();
            return View(matches);
        }

        public ViewResult CreateMatch()
        {
            return View();
        }

        public ViewResult CreateMatch(Match thisMatch)
        {
            _matchRepository.CreateMatch(thisMatch);
            return Matches();
        }

        public ViewResult DeleteMatch(int matchId)
        {
            _matchRepository.DeleteMatch(matchId);
            return Matches();
        }

        public ViewResult EditMatch(int id)
        {
            Match thisMatch = _matchRepository.GetMatchById(id);
            return View(thisMatch);
        }

        public ViewResult EditMatch(Match thisMatch)
        {
            _matchRepository.UpdateMatch(thisMatch);
            return Matches();
        }
    }
}