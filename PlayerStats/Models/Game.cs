using System;
namespace PlayerStats.Models
{
    public class Game
    {
        public int Id { get; set; }
        public Team HomeTeam { get; set; }
        public Team AwayTeam { get; set; }
        public DateTime Date { get; set; }
        public Result Result { get; set; }

        public Game()
        {

        }

        public Game (int id, Team homeTeam, Team awayTeam, Result result)
        {
            Id = id;
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
            Date = DateTime.Now;
            Result = result;
        }
    }
}
