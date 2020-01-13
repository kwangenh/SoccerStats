using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoccerStats.Models;
using SoccerStats.Contracts;
using SoccerStats.ViewModels.Admin.Players;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SoccerStats.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly SoccerStatsContext _context;

        public PlayerRepository(SoccerStatsContext context)
        {
            _context = context;
        }
        public Player GetPlayerById(int playerId)
        {
            Player thisPlayer = _context.Players.FirstOrDefault(playerMatchTime => playerMatchTime.Id == playerId);
            return thisPlayer;
        }
        public Player CreatePlayer(Player thisPlayer)
        {
            _context.Players.Add(thisPlayer);
            return thisPlayer;
        }
        public Player UpdatePlayer(Player thisPlayer)
        {
            if (_context.Players.Find(thisPlayer.Id) != null)
            {
                var updatedPlayer = _context.Players.Attach(thisPlayer);
                updatedPlayer.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
                return thisPlayer;
            }
            return thisPlayer;
        }

        public Player DeletePlayer(int playerId)
        {
            Player deletedPlayer = _context.Players.Find(playerId);
            if (deletedPlayer != null)
            {
                _context.Remove(deletedPlayer);
                _context.SaveChanges();
            }
            return deletedPlayer;
        }

        public IEnumerable<Player> GetAllPlayers()
        {
            return _context.Players;
        }        

        public Player CreatePlayerModel(AdminEditPlayerViewModel viewModel)
        {
            Player player = new Player
            {
                Id = viewModel.Id,
                Birthday = viewModel.Birthday,
                FirstName = viewModel.FirstName,
                LastName = viewModel.LastName,
                Team = viewModel.Team,
            };
            return player;
        }
        public Player CreatePlayerModel(AdminCreatePlayerViewModel viewModel)
        {
            Player player = new Player
            {
                Birthday = viewModel.Birthday,
                FirstName = viewModel.FirstName,
                LastName = viewModel.LastName,
                Team = viewModel.Team
            };

            return player;
        }
        public AdminCreatePlayerViewModel CreateAdminCreatePlayerViewModel(Player thisPlayer)
        {
            AdminCreatePlayerViewModel viewModel = new AdminCreatePlayerViewModel
            {
                Birthday = thisPlayer.Birthday,
                FirstName = thisPlayer.FirstName,
                LastName = thisPlayer.LastName,
                Team = thisPlayer.Team,                
            };

            return viewModel;
        }
        public AdminEditPlayerViewModel CreateAdminEditPlayerViewModel(Player thisPlayer)
        {
            AdminEditPlayerViewModel viewModel = new AdminEditPlayerViewModel
            {
                Id = thisPlayer.Id,
                Birthday = thisPlayer.Birthday,
                FirstName = thisPlayer.FirstName,
                LastName = thisPlayer.LastName,
                Team = thisPlayer.Team
            };
            var teams = _context.Teams.ToList();

            foreach (var team in teams)
            {
                viewModel.AvailableTeams.Add(new SelectListItem { Text = team.Name, Value = team.Id.ToString() });
            }

            return viewModel;
        }
    }
}
