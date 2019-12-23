using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoccerStats.Contracts;
using SoccerStats.Models;

namespace SoccerStats.Repositories
{
    public class PlayerMatchTimeRepository : IPlayerMatchTimeRepository
    {
        private readonly SoccerStatsContext _context;

        public PlayerMatchTimeRepository(SoccerStatsContext context)
        {
            _context = context;
        }
        public PlayerMatchTime GetMatchById(int playerMatchTimeId)
        {
            PlayerMatchTime thisPlayerMatchTime = _context.Player_Match_Time.FirstOrDefault(playerMatchTime => playerMatchTime.Id == playerMatchTimeId);
            return thisPlayerMatchTime;
        }
        public PlayerMatchTime CreateMatch(PlayerMatchTime thisPlayerMatchTime)
        {
            _context.Player_Match_Time.Add(thisPlayerMatchTime);
            return thisPlayerMatchTime;
        }
        public PlayerMatchTime UpdateMatch(PlayerMatchTime thisPlayerMatchTime)
        {
            if (_context.Matches.Find(thisPlayerMatchTime.Id) != null)
            {
                var updatedPlayerMatchTime = _context.Player_Match_Time.Attach(thisPlayerMatchTime);
                updatedPlayerMatchTime.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
                return thisPlayerMatchTime;
            }
            return thisPlayerMatchTime;
        }

        public PlayerMatchTime DeletePlayerMatch(int playerMatchId)
        {
            PlayerMatchTime deletedPlayerMatchTime = _context.Player_Match_Time.Find(playerMatchId);
            if (deletedPlayerMatchTime != null)
            {
                _context.Remove(deletedPlayerMatchTime);
                _context.SaveChanges();
            }
            return deletedPlayerMatchTime;
        }

        public IEnumerable<PlayerMatchTime> GetAllPlayerMatchTimes()
        {
            return _context.Player_Match_Time;
        }
    }
}

