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
        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MatchGoal>()
                .HasOne(x => x.)
                .WithMany(p => p.InvestorToWholesalers)
                .HasForeignKey(pt => pt.InvestorId);

            modelBuilder.Entity<InvestorToWholesaler>()
                .HasOne(pt => pt.Wholesaler)
                .WithMany(p => p.InvestorToWholesalers)
                .HasForeignKey(pt => pt.WholesalerId);
        }
        */
        public DbSet<Match> Matches { get; set; }
        public DbSet<MatchGoal> Match_Goals { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerMatchTime> Player_Match_Time { get; set; }
        public DbSet<Team> Teams { get; set; }

        

    }
}
