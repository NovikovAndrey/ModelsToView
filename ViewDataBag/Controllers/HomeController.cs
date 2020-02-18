using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ViewDataBag.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Test"] = "hello world";
            ViewBag.Test1 = "hello hell";
            return View();
        }
    }
}