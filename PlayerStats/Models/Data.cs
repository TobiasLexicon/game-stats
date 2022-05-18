using System;
using Microsoft.EntityFrameworkCore;

namespace PlayerStats.Models
{
    public class Data : DbContext
    {
        public Data(DbContextOptions<Data> options) : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<City> Cities { get; set; }




    }
}
