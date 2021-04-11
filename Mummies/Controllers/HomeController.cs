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

        [HttpGet]
        public IActionResult DatabaseSearch(string queryUrl = "", int PageNum = 1)
        {
            SearchInfo CurrentSearch = new SearchInfo();

            CurrentSearch.SetSearch(queryUrl);

            IQueryable<FagElGamousDatabaseByLocation> burials = _context.FagElGamousDatabaseByLocation;
            IQueryable<Cranial2002> cranial = _context.Cranial2002;
            IEnumerable<FagElGamousDatabaseByLocation> query = CurrentSearch.GetBurials(burials, cranial);

            SearchDatabaseViewModel model = new SearchDatabaseViewModel
            {
                Burials = query
                    .OrderBy(b => b.BurialId)
                    .Skip((PageNum - 1) * PageSize)
                    .Take(PageSize).ToList(),
                Cranial = _context.Cranial2002,
                PagingInfo = new PagingInfo
                {
                    TotalNumItems = query
                        .Count(),
                    ItemsPerPage = PageSize,
                    CurrentPage = PageNum
                },
                CurrentSearch = CurrentSearch,
                queryUrl = queryUrl
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult DatabaseSearch(SearchInfo search, int PageNum = 1)
        {
            IQueryable<FagElGamousDatabaseByLocation> burials = _context.FagElGamousDatabaseByLocation;
            IQueryable<Cranial2002> cranial = _context.Cranial2002;
            IEnumerable<FagElGamousDatabaseByLocation> query = search.GetBurials(burials, cranial);

            SearchDatabaseViewModel model = new SearchDatabaseViewModel
            {
                Burials = query
                    .OrderBy(b => b.BurialId)
                    .Skip((PageNum - 1) * PageSize)
                    .Take(PageSize).ToList(),
                Cranial = _context.Cranial2002,
                PagingInfo = new PagingInfo
                {
                    TotalNumItems = query
                        .Count(),
                    ItemsPerPage = PageSize,
                    CurrentPage = PageNum
                },
                CurrentSearch = search,
                queryUrl = search.GetUrl()
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
