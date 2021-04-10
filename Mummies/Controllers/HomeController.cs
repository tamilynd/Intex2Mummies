using Mummies.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Mummies.Models.MummyDb;
using Mummies.Models.ViewModels;
using Mummies.Models.ViewModels.Home;
using Microsoft.EntityFrameworkCore;

namespace Mummies.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MummyDbContext _context;
        private IMummyRepository _repository;
        public int PageSize = 15;

        public HomeController(ILogger<HomeController> logger, MummyDbContext context, IMummyRepository repository)
        {
            _logger = logger;
            _context = context;
            _repository = repository;
        }

        public IActionResult Index()
        {
            //Home page controller
            return View();
        }

        public IActionResult DatabaseSearch(SearchInfo? search, int PageNum = 1)
        {
            string query = search.GetQuery();
            SearchDatabaseViewModel model;

        
            model = new SearchDatabaseViewModel
            {
                Burials = _context.FagElGamousDatabaseByLocation/*.FromSqlRaw(query)*/
                    .OrderBy(b => b.BurialId)
                    .Skip((PageNum - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    TotalNumItems = _context.FagElGamousDatabaseByLocation
                        //.FromSqlRaw(query)
                        .Count(),
                    ItemsPerPage = PageSize,
                    CurrentPage = PageNum
                },
                CurrentSearch = search,
                Query = query
            };
            
            return View(model);
        }

        public IActionResult MummyAnalytics()
        {
            //Not sure how this will work yet, but it is here.
            return View();
        }
        public IActionResult FullMummyData()
        {
            //Home page controller
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
