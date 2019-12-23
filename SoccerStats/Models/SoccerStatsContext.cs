using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SoccerStats.Models;

namespace SoccerStats.Models
{
    public class SoccerStatsContext : DbContext
    {
        public SoccerStatsContext(DbContextOptions<SoccerStatsContext> options) 
            : base(options)            
        {

        }

        public DbSet<Match> Matches { get; set; }
        public DbSet<MatchGoal> Match_Goals { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerMatchTime> Player_Match_Time { get; set; }
        public DbSet<Team> Teams { get; set; }

    }
}
