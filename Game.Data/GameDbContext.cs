using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Data
{
    public class GameDbContext : DbContext
    {
        public DbSet<Player> Players { get; set; }

        public GameDbContext(DbContextOptions<GameDbContext> options) : base(options)
        {
        }


    }
}
