using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModel.Model;
using ViewModel.ViewModel;

namespace ViewModel.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            PCGame pCGame1 = new PCGame
            {
                Name = "WOW",
                Company = "Blizzard"
            };
            PCGame pCGame2 = new PCGame
            {
                Name = "WOW2",
                Company = "Blizzard2"
            };
            PCGame pCGame3 = new PCGame
            {
                Name = "WOW3",
                Company = "Blizzard3"
            };
            XBoxGame xBoxGame1 = new XBoxGame
            {
                Name = "dota",
                Company = "valve"
            };
            XBoxGame xBoxGame2 = new XBoxGame
            {
                Name = "dota2",
                Company = "valve2"
            };
            XBoxGame xBoxGame3 = new XBoxGame
            {
                Name = "dota3",
                Company = "valve3"
            };
            List<PCGame> pCGames = new List<PCGame>();
            List<XBoxGame> xBoxGames = new List<XBoxGame>();
            pCGames.Add(pCGame1);
            pCGames.Add(pCGame2);
            pCGames.Add(pCGame3);
            xBoxGames.Add(xBoxGame1);
            xBoxGames.Add(xBoxGame2);
            xBoxGames.Add(xBoxGame3);
            ViewModelGames viewModelGames = new ViewModelGames
            {
                PCGames = pCGames,
                XBoxGames = xBoxGames
            };
            return View(viewModelGames);
        }
    }
}