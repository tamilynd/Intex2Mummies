using Mummies.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Mummies.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //Home page controller
            return View();
        }

        public IActionResult DatabaseSearch(/*There will probably be a lot of inputs*/)
        {
            //This view will receive parameters (maybe) and then send them through a sql 
            //parameter to return a set of mummies

            return View(/*collection of mummies*/);
        }

        public IActionResult MummyAnalytics()
        {
            //Not sure how this will work yet, but it is here.
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
