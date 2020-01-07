using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoccerStats.Models;
using SoccerStats.ViewModels.Admin.Players;

namespace SoccerStats.Contracts
{
    public interface IPlayerRepository
    {
        public Player GetPlayerById(int playerId);
        public Player CreatePlayer(Player thisPlayer);
        public Player UpdatePlayer(Player thisPlayer);
        public Player DeletePlayer(int playerId);
        public IEnumerable<Player> GetAllPlayers();
        public Player CreatePlayerModel(AdminEditPlayerViewModel viewModel);
        public Player CreatePlayerModel(AdminCreatePlayerViewModel viewModel);
        public AdminCreatePlayerViewModel CreateAdminCreatePlayerViewModel(Player thisPlayer);
        public AdminEditPlayerViewModel CreateAdminEditPlayerViewModel(Player thisPlayer);
    }
}