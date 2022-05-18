using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PlayerStats.Models;

namespace PlayerStats.Controllers
{
    public class TeamController : Controller
    {
   

        public TeamController()
        {
           
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

   
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Team team)
        {
            if (ModelState.IsValid)
            {
            
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        

        
    }
}
