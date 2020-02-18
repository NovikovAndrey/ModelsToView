using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Collection.Model;
using Microsoft.AspNetCore.Mvc;

namespace Collection.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Game game = new Game
            {
                Name = "Wow", 
                Paltform="PC", 
                Engine="Unknown"
            };
            Game game1 = new Game
            {
                Name = "Wow1",
                Paltform = "PC1",
                Engine = "Unknown"
            };
            Game game2 = new Game
            {
                Name = "Wow2",
                Paltform = "PC2",
                Engine = "Unknown"
            };
            List<Game> games = new List<Game>();
            games.Add(game);
            games.Add(game1);
            games.Add(game2);
            return View(games);
        }
    }
}