using System;
using System.Collections.Generic;

namespace PlayerStats.Models
{
    public static class Repository
    {
        public static IEnumerable<City> Cities = new List<City>()
        {
            new City(1, "Liverpool"),
            new City(2, "London")
        };

        public static List<Team> Teams = new List<Team>()
        {
            new Team(1, "Everton", ReturnCity(1)),
            new Team(2, "Tottenham",ReturnCity(2)),
            new Team(3, "Fulham", ReturnCity(2))
        };

        public static List<Result> Results = new List<Result>()
        {
            new Result(1, 2, 3),
            new Result(2, 0, 0),
            new Result(3, 1, 0)
        };

        public static List<Game> Games = new List<Game>()
        {

            new Game(1, ReturnTeam(2), ReturnTeam(3), ReturnResult(2) ),
            new Game(2, ReturnTeam(1), ReturnTeam(2), ReturnResult(2) ),
            new Game(1, ReturnTeam(3), ReturnTeam(2), ReturnResult(3) ),
        };

        public static City ReturnCity(int id)
        {

            foreach(City city in Cities)
            {
                if(city.Id == id)
                {
                    return city;
                }
            }
            return new City();
        }

        public static Result ReturnResult(int id)
        {

            foreach (Result result in Results)
            {
                if (result.Id == id)
                {
                    return result;
                }
            }
            return new Result();
        }

        public static Team ReturnTeam(int id)
        {

            foreach (Team team in Teams)
            {
                if (team.Id == id)
                {
                    return team;
                }
            }
            return new Team();
        }
    }
}
