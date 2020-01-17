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
            _context.SaveChanges();

            return thisPlayerMatchTime;
        }
        public PlayerMatchTime UpdateMatch(PlayerMatchTime thisPlayerMatchTime)
        {
            if (_context.Players.Find(thisPlayerMatchTime.Id) != null)
            {
                var matchTime = _context.Player_Match_Time.First(g => g.Id == thisPlayerMatchTime.Id);
                _context.Entry(matchTime).CurrentValues.SetValues(thisPlayerMatchTime);
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

