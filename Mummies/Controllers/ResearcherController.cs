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

            return View("Index");
        }

        [HttpPost]
        public IActionResult AddConfirmation(string x /*mummy from confirmation*/)
        {


            return View("Index");
        }

        [HttpPost]
        public IActionResult UpdateMummy(int mummyid)
        {
            //Controller that returns the mummy info for the mummy id that was sent through the view
            //Only accessible by researchers
            return View(/*collection of mummies*/);
        }

        [HttpPost]
        public IActionResult UpdateConfirmation(int mummyid /*mummy passed through form*/)
        {
            //Returns the update confirmation for the updated mummy info
            //We will either need to make separate views, OR we need to pass in 
            //info that shows that this is an update rather than an add. 
            return View("MummyConfirmation");
        }
    }
}
