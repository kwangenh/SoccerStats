using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using SoccerStats.Contracts;
using SoccerStats.Models;
using SoccerStats.ViewModels;
using SoccerStats.ViewModels.Admin.Teams;

namespace SoccerStats.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private readonly SoccerStatsContext _context;

        public TeamRepository(SoccerStatsContext context)
        {
            _context = context;
        }
        public Team GetTeamById(int teamId)
        {
            Team thisTeam = _context.Teams.FirstOrDefault(team => team.Id == teamId);
            return thisTeam;
        }
        public Team CreateTeam(Team thisTeam)
        {
            _context.Teams.Add(thisTeam);
            return thisTeam;
        }
        public Team UpdateTeam(Team thisTeam)
        {
            if (_context.Teams.Find(thisTeam.Id) != null)
            {
                var updatedTeam = _context.Teams.Attach(thisTeam);
                updatedTeam.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
                return thisTeam;
            }
            return thisTeam;
        }

        public Team DeleteTeam(int teamId)
        {
            Team deletedTeam = _context.Teams.Find(teamId);
            if (deletedTeam != null)
            {
                _context.Remove(deletedTeam);
                _context.SaveChanges();
            }
            return deletedTeam;
        }

        public IEnumerable<Team> GetAllTeams()
        {
            return _context.Teams;
        }
        
        public List<SelectListItem> GetTeamSelectList()
        {
            List<Team> teams = GetAllTeams().ToList();
            List<SelectListItem> teamItems = new List<SelectListItem>();

            //todo - loop through teams and add id/name to teamItems

            return teamItems;
        }

        public AdminCreateTeamViewModel CreateAdminCreateTeamViewModel(Team thisTeam)
        {
            AdminCreateTeamViewModel thisViewModel = new AdminCreateTeamViewModel
            {
                Name = thisTeam.Name,
                Points = thisTeam.Points,
                Wins = thisTeam.Wins,
                Losses = thisTeam.Losses,
                Ties = thisTeam.Ties,
                Games_Played = thisTeam.Games_Played,
                Goals_For = thisTeam.Goals_For,
                Goals_Against = thisTeam.Goals_Against
            };

            return thisViewModel;
        }

        public AdminEditTeamViewModel CreateAdminEditTeamViewModel(Team thisTeam)
        {
            AdminEditTeamViewModel thisViewModel = new AdminEditTeamViewModel
            {
                Id = thisTeam.Id,
                Name = thisTeam.Name,
                Points = thisTeam.Points,
                Wins = thisTeam.Wins,
                Losses = thisTeam.Losses,
                Ties = thisTeam.Ties,
                Games_Played = thisTeam.Games_Played,
                Goals_For = thisTeam.Goals_For,
                Goals_Against = thisTeam.Goals_Against
            };

            return thisViewModel;
        }


        public Team CreateTeamModel(AdminEditTeamViewModel thisViewModel)
        {
            Team thisTeam = new Team
            {
                Id = thisViewModel.Id,
                Name = thisViewModel.Name,
                Points = thisViewModel.Points,
                Wins = thisViewModel.Wins,
                Losses = thisViewModel.Losses,
                Ties = thisViewModel.Ties,
                Games_Played = thisViewModel.Games_Played,
                Goals_For = thisViewModel.Goals_For,
                Goals_Against = thisViewModel.Goals_Against
            };
            return thisTeam;
        }

        public Team CreateTeamModel(AdminCreateTeamViewModel thisViewModel)
        {
            Team thisTeam = new Team
            {
                Name = thisViewModel.Name,
                Points = thisViewModel.Points,
                Wins = thisViewModel.Wins,
                Losses = thisViewModel.Losses,
                Ties = thisViewModel.Ties,
                Games_Played = thisViewModel.Games_Played,
                Goals_For = thisViewModel.Goals_For,
                Goals_Against = thisViewModel.Goals_Against
            };
            return thisTeam;
        }

        public AdminTeamsViewModel CreateAdminTeamViewModel(Team thisTeam)
        {
            AdminTeamsViewModel viewModel = new AdminTeamsViewModel
            {
                Id = thisTeam.Id,
                Name = thisTeam.Name,
                Points = thisTeam.Points,
                Wins = thisTeam.Wins,
                Losses = thisTeam.Losses,
                Ties = thisTeam.Ties,
                Games_Played = thisTeam.Games_Played,
                Goals_For = thisTeam.Goals_For,
                Goals_Against = thisTeam.Goals_Against
            };

            return viewModel;
        }

        public IEnumerable<AdminTeamsViewModel> CreateAdminTeamViewModels(IEnumerable<Team> teams)
        {
            List<AdminTeamsViewModel> viewModels = new List<AdminTeamsViewModel>();
            foreach(Team team in teams)
            {
                viewModels.Add(CreateAdminTeamViewModel(team));
            }

            IEnumerable<AdminTeamsViewModel> enumViewModels = viewModels;
            return (enumViewModels);
        }
    }
}
