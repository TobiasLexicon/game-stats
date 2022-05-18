using System;
namespace PlayerStats.Models
{
    public class Result
    {
        public int Id { get; set; }

        public int HomeTeamGoalsRegular { get; set; }
        public int AwayTeamGoalsRegular { get; set; }

        public Result() { }

        public Result(int id, int homeGoal,int awayGoal)
        {
            Id = id;
            HomeTeamGoalsRegular = homeGoal;
            AwayTeamGoalsRegular = awayGoal;
        }

        public string ResultDisplay()
        {
            return $"{HomeTeamGoalsRegular} – {AwayTeamGoalsRegular}";
        }
    }
}
