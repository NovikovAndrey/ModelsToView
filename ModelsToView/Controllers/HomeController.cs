using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SingeModel.Model;

namespace SingeModel.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Game game = new Game
            {
                Name="WOW", 
                Platform="PC", 
                Engine="Unknown"
            };
            return View(game);
        }
    }
}