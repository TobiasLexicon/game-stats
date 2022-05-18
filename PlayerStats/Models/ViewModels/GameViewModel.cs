using System;
using System.ComponentModel.DataAnnotations;

namespace PlayerStats.Models.ViewModels
{
    public class GameViewModel
    {

        public int Id { get; set; }

        [Display(Name="Home team")]
        public string HomeTeamName { get; set; }

        [Display(Name = "Away team")]
        public string AwayTeamName { get; set; }
        public DateTime Date { get; set; }
        public string Result { get; set; }

        public GameViewModel()
        {

        }

        public GameViewModel(int id, string homeTeamName, string awayTeamName, DateTime date, string result)
        {
            Id = id;
            HomeTeamName = homeTeamName;
            AwayTeamName = awayTeamName;
            Date = date;
            Result = result;
        }
    }
}
