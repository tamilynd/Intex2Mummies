﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mummies.Models.MummyDb;

namespace Mummies.Controllers
{
    //[Authorize (Roles = "Researcher, Admin")]
    public class ResearcherController : Controller
    {
        //add the _context (allows you to edit/delete)
        private MummyDbContext _context { get; set; }

        //constructor
        public ResearcherController(MummyDbContext con)
        {
            _context = con;
        }

        [HttpGet]
        public IActionResult AddMummy()
        {
            //Simply returns the add mummy view with the form. (Only allowed for authenticated researchers)
            return View();
        }

        [HttpPost]
        public IActionResult AddMummy(FagElGamousDatabaseByLocation loc /*mummy from form*/)
        {
            //This will submit the confirmed mummy to the database and return the researcher 
            //back to the home page.

            //generate the primary key
            loc.BurialId = loc.Burialnors + " " + loc.BurialAreaNorthOrSouthLower + "/" +
                loc.BurialAreaNorthOrSouthUpper + " " + loc.Burialxeorw + " " +
                loc.BurialAreaEastOrWestLower + "/" + loc.BurialAreaEastOrWestUpper + " " +
                loc.Square + " #" + loc.BurialNumber;

            if (ModelState.IsValid)
            {
                _context.FagElGamousDatabaseByLocation.Add(loc);
                _context.SaveChanges();
            }

            return RedirectToAction("Index", "Home");
        }

        //[HttpPost]
        //public IActionResult AddConfirmation(string x /*mummy from confirmation*/)
        //{


        //    return View("Index");
        //}

        public IActionResult UpdateMummyData()
        {
            //Home page controller
            return View();
        }

        [HttpPost]
<<<<<<< HEAD
        public IActionResult UpdateMummy()
=======
        public IActionResult UpdateMummyData(String BurialId)
        {
            IEnumerable<FagElGamousDatabaseByLocation> fagElGamousDatabaseByLocations;
            fagElGamousDatabaseByLocations = _context.FagElGamousDatabaseByLocation.Where(x => x.BurialId == BurialId);

            return View("EditFullMummyData", fagElGamousDatabaseByLocations.First());
        }
        public IActionResult DeleteMummy(string mummyid)
        {
            FagElGamousDatabaseByLocation mummy = _context.FagElGamousDatabaseByLocation.Where(b => b.BurialId == mummyid).FirstOrDefault();
            _context.FagElGamousDatabaseByLocation.Remove(mummy);
            _context.SaveChanges();
            return RedirectToAction("DatabaseSearch", "Home");
        }

        [HttpPost]
        public IActionResult UpdateConfirmation(int mummyid /*mummy passed through form*/)
>>>>>>> 534b3657a33db0498df89b2c8ea098f6f4867c48
        {
            //Submits update
            //Only accessible by researchers

            return View(/*collection of mummies*/);
        }

        //[HttpPost]
        //public IActionResult UpdateConfirmation(int mummyid /*mummy passed through form*/)
        //{
        //    //Returns the update confirmation for the updated mummy info
        //    //We will either need to make separate views, OR we need to pass in 
        //    //info that shows that this is an update rather than an add. 
        //    return View("MummyConfirmation");
        //}
    }
}
