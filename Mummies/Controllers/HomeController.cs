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
        public IActionResult DatabaseSearch(int PageNum = 1)
        {

            IQueryable<FagElGamousDatabaseByLocation> query = _repository.FagElGamousDatabaseByLocation;

            SearchDatabaseViewModel model = new SearchDatabaseViewModel
            {
                Burials = query
                    .OrderBy(b => b.BurialId)
                    .Skip((PageNum - 1) * PageSize)
                    .Take(PageSize).ToList(),
                PagingInfo = new PagingInfo
                {
                    TotalNumItems = query
                        .Count(),
                    ItemsPerPage = PageSize,
                    CurrentPage = PageNum
                },
                CurrentSearch = new SearchInfo()
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult DatabaseSearch(SearchInfo search, int PageNum = 1)
        {

            IQueryable<FagElGamousDatabaseByLocation> query = _repository.FagElGamousDatabaseByLocation;

            //Location
            query = query.Where(b => b.BurialAreaNorthOrSouthUpper >= search.NorthMin);
            query = query.Where(b => b.BurialAreaEastOrWestUpper >= search.EastMin);
            query = query.Where(b => b.BurialAreaNorthOrSouthLower <= search.NorthMax);
            query = query.Where(b => b.BurialAreaEastOrWestLower <= search.EastMax);
            if (!search.West)
            {
                query = query.Where(b => b.Burialxeorw == "E");
            }

            //Orientation
            if (search.UnknownOrient || search.EastOrient || search.WestOrient)
            {
                if (!search.UnknownOrient)
                {
                    query = query.Where(b => b.BurialDirection != "U");
                    query = query.Where(b => b.BurialDirection != "");
                    query = query.Where(b => b.BurialDirection != null);

                }
                if (!search.WestOrient)
                {
                    query = query.Where(b => b.BurialDirection != "W");
                }
                if (!search.EastOrient)
                {
                    query = query.Where(b => b.BurialDirection != "E");
                }
            }
            //Depth
            if (search.DepthMax == 5 && search.DepthMin == 0)
            {
                query = query.Where(b => b.BurialDepth >= search.DepthMin || b.BurialDepth == null);
                query = query.Where(b => b.BurialDepth <= search.DepthMax || b.BurialDepth == null);
            }
            else
            {
                query = query.Where(b => b.BurialDepth >= search.DepthMin);
                query = query.Where(b => b.BurialDepth <= search.DepthMax);
            }

            //Hair
            if (search.Black || search.Blond || search.BrownRed || search.Brown || search.Red || search.UnknownColor)
            {
                if (!search.Black)
                {
                    query = query.Where(b => b.HairColorCode != "K");
                }
                if (!search.Blond)
                {
                    query = query.Where(b => b.HairColorCode != "D");
                }
                if (!search.Brown)
                {
                    query = query.Where(b => b.HairColorCode != "B");
                }
                if (!search.BrownRed)
                {
                    query = query.Where(b => b.HairColorCode != "A");
                }
                if (!search.Red)
                {
                    query = query.Where(b => b.HairColorCode != "R");
                }
                if (!search.UnknownColor)
                {
                    query = query.Where(b => b.HairColorCode != "U");
                    query = query.Where(b => b.HairColorCode != "");
                    query = query.Where(b => b.HairColorCode != null);
                }
            }


            //Gender
            if (search.Female || search.Male || search.UnknownGender)
            {
                if (!search.Female)
                {
                    query = query.Where(b => b.GenderCode != "F");
                }
                if (!search.Male)
                {
                    query = query.Where(b => b.GenderCode != "M");
                }
                if (!search.UnknownGender)
                {
                    query = query.Where(b => b.GenderCode != "U");
                    query = query.Where(b => b.GenderCode != "");
                    query = query.Where(b => b.GenderCode != null);

                }
            }

            //Age
            if (search.Adult || search.Child || search.Infant || search.Newborn || search.UnknownGender)
            {
                if (!search.Adult)
                {
                    query = query.Where(b => b.AgeCodeSingle != "A");
                }
                if (!search.Child)
                {
                    query = query.Where(b => b.AgeCodeSingle != "C");
                }
                if (!search.Infant)
                {
                    query = query.Where(b => b.AgeCodeSingle != "I");
                }
                if (!search.Newborn)
                {
                    query = query.Where(b => b.AgeCodeSingle != "N");
                }
                if (!search.UnknownAge)
                {
                    query = query.Where(b => b.AgeCodeSingle != "U");
                    query = query.Where(b => b.AgeCodeSingle != "");
                    query = query.Where(b => b.AgeCodeSingle != null);

                }
            }

            //Wrappings
            if (search.LittleBones || search.FullWrap || search.PartialWrap || search.UnknownWrap)
            {
                if (!search.LittleBones)
                {
                    query = query.Where(b => b.BurialWrappingCode != "B");
                }
                if (!search.FullWrap)
                {
                    query = query.Where(b => b.BurialWrappingCode != "W");
                }
                if (!search.PartialWrap)
                {
                    query = query.Where(b => b.BurialWrappingCode != "H");
                }
                if (!search.UnknownWrap)
                {
                    query = query.Where(b => b.BurialWrappingCode != "U");
                    query = query.Where(b => b.BurialWrappingCode != "");
                    query = query.Where(b => b.BurialWrappingCode != null);
                }
            }

            SearchDatabaseViewModel model = new SearchDatabaseViewModel
            {
                Burials = query
                    .OrderBy(b => b.BurialId)
                    .Skip((PageNum - 1) * PageSize)
                    .Take(PageSize).ToList(),
                PagingInfo = new PagingInfo
                {
                    TotalNumItems = query
                        .Count(),
                    ItemsPerPage = PageSize,
                    CurrentPage = PageNum
                },
                CurrentSearch = search
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
