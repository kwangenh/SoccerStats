using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SoccerStats.Contracts;
using SoccerStats.Models;
using SoccerStats.Repositories;
using Microsoft.EntityFrameworkCore; // needed to add manually for options.UseSqlServer to work

namespace SoccerStats
{
    public class Startup
    {
        private readonly IConfiguration _config;
        public Startup (IConfiguration config)
        {
            _config = config; 
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // needed to manually install "Microsoft.EntityFrameworkCore.SqlServer" to get required assemblies
            services.AddDbContextPool<SoccerStatsContext>(options => options.UseSqlServer(_config.GetConnectionString("SoccerStatsDb")));
            services.AddMvc();
            
            // mapping contracts to repos
            //services.AddScoped<IMatchGoalRepository, MatchGoalRepository>();
            services.AddScoped<IMatchRepository, MatchRepository>();                        
            services.AddScoped<IPlayerMatchTimeRepository, PlayerMatchTimeRepository>();
            services.AddScoped<IPlayerRepository, PlayerRepository>();
            services.AddScoped<ITeamRepository, TeamRepository>();          
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseEndpoints(endpoints =>
            {
                logger.LogInformation("Called the app.UseEndPoints()");

                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Heya!");
                });
            });
        }
    }
}
