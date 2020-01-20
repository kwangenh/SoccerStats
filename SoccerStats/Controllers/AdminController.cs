using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SoccerStats.Models;
using SoccerStats.Contracts;
using SoccerStats.ViewModels.Admin.Teams;
using SoccerStats.ViewModels.Admin.Matches;
using SoccerStats.ViewModels.Admin.Players;
using Microsoft.AspNetCore.Mvc.Rendering;

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
            IEnumerable<AdminTeamsViewModel> viewModels = _teamRepository.CreateAdminTeamViewModels(teams);

            return View(viewModels);
        }

        [HttpPost]
        public ActionResult CreateTeam(AdminCreateTeamViewModel thisTeamViewModel)
        {
            Team thisTeam = _teamRepository.CreateTeamModel(thisTeamViewModel);
            _teamRepository.CreateTeam(thisTeam);

            // call the Teams view after creating this record
            return RedirectToAction("Teams");
        }

        [HttpGet]
        public ViewResult CreateTeam()
        {
            AdminCreateTeamViewModel viewModel = new AdminCreateTeamViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult DeleteTeam(int id)
        {
            _teamRepository.DeleteTeam(id);
            return RedirectToAction("Teams");
        }

        [HttpGet]
        public ViewResult EditTeam(int id)
        {
            AdminEditTeamViewModel thisTeam = _teamRepository.CreateAdminEditTeamViewModel(_teamRepository.GetTeamById(id));
            return View(thisTeam);
        }

        [HttpPost]
        public ActionResult EditTeam(AdminEditTeamViewModel thisTeam)
        {
            _teamRepository.UpdateTeam(_teamRepository.CreateTeamModel(thisTeam));
            
            return RedirectToAction("Teams");
        }

        public ViewResult Players()
        {
            IEnumerable<Player> players = _playerRepository.GetAllPlayers();
            var viewModels = _playerRepository.CreateAdminPlayerViewModels(players);

            return View(viewModels);
        }

        [HttpPost]
        public ActionResult CreatePlayer(AdminCreatePlayerViewModel thisPlayer)
        {
            thisPlayer.Team = _teamRepository.GetTeamById(thisPlayer.Team.Id);
            _playerRepository.CreatePlayer(_playerRepository.CreatePlayerModel(thisPlayer));

            return RedirectToAction("Players");
        }

        [HttpGet]
        public ViewResult CreatePlayer()
        {
            AdminCreatePlayerViewModel viewModel = new AdminCreatePlayerViewModel();

            // would be best to have this as part of AdminCreatePlayerViewModel? - actually NOPE!!
            // i really dont like this
            viewModel.AvailableTeams = _teamRepository.GetTeamSelectList();
            return View(viewModel);
        }

        public ActionResult DeletePlayer(int id)
        {
            _playerRepository.DeletePlayer(id);

            return RedirectToAction("Players");
        }
        
        [HttpGet]   
        public ViewResult EditPlayer(int id)
        {
            AdminEditPlayerViewModel thisViewModel = _playerRepository.CreateAdminEditPlayerViewModel(_playerRepository.GetPlayerById(id));
            return View(thisViewModel);
        }

        [HttpPost]
        public ActionResult EditPlayer(AdminEditPlayerViewModel thisViewModel)
        {
            Player thisPlayer = _playerRepository.CreatePlayerModel(thisViewModel);
            _playerRepository.UpdatePlayer(thisPlayer);
            return RedirectToAction("Players");
        }

        public ViewResult Matches()
        {
            IEnumerable<Match> matches = _matchRepository.GetAllMatches();
            return View(matches);
        }

        public ViewResult CreateMatch()
        {
            AdminCreateMatchViewModel viewModel = new AdminCreateMatchViewModel();            

            return View(viewModel);
        }

        public ViewResult CreateMatch(Match thisMatch)
        {
            _matchRepository.CreateMatch(thisMatch);
            return Matches();
        }

        public ActionResult DeleteMatch(int matchId)
        {
            _matchRepository.DeleteMatch(matchId);
            return RedirectToAction("Matches");
        }

        public ViewResult EditMatch(int id)
        {
            Match thisMatch = _matchRepository.GetMatchById(id);
            return View(thisMatch);
        }

        public ActionResult EditMatch(Match thisMatch)
        {
            _matchRepository.UpdateMatch(thisMatch);
            return RedirectToAction("Mathces");
        }
    }
}