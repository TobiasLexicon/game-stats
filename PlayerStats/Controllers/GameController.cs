using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PlayerStats.Models;
using PlayerStats.Models.ViewModels;

namespace PlayerStats.Controllers
{
    public class GameController : Controller
    {

        public GameController()
        {           
        }


        public IActionResult Index()
        {
            List<GameViewModel> games = new List<GameViewModel>();
            foreach(Game game in Repository.Games)
            {
                GameViewModel model = new GameViewModel()
                {
                    Id = game.Id,
                    HomeTeamName = game.HomeTeam.Name,
                    AwayTeamName = game.AwayTeam.Name,
                    Date = game.Date,
                    Result = game.Result.ResultDisplay()
                };                
                games.Add(model);
            }

            return View(games);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Game game)
        {
            if (ModelState.IsValid)
            {
                
                return RedirectToAction(nameof(Index));
            }
            return View(game);
        }

        [HttpGet]
        public string GetTeamCity(string teamName)
        {
            foreach(Team team in Repository.Teams)
            {
                if(team.Name == teamName)
                {
                    return team.City.Name;
                }
            }
            return "";
        }

        

        

        
    }
}
