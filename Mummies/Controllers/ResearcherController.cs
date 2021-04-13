using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mummies.Models.MummyDb;
using System.Text.Encodings.Web;
using System.Reflection;
using System.Web;

namespace Mummies.Controllers
{
    //[Authorize (Roles = "Researcher, Admin")]
    public class ResearcherController : Controller
    {
        //add the _context (allows you to edit/delete)
        private MummyDbContext _context { get; set; }
        private HtmlEncoder _htmlEncoder { get; set; }
        private JavaScriptEncoder _javaScriptEncoder { get; set; }
        private UrlEncoder _urlEncoder { get; set; }

        //constructor
        public ResearcherController(MummyDbContext con, HtmlEncoder htmlEncoder, 
                             JavaScriptEncoder javascriptEncoder,
                             UrlEncoder urlEncoder)
        {
            _context = con;
            _htmlEncoder = htmlEncoder;
           _javaScriptEncoder = javascriptEncoder;
           _urlEncoder = urlEncoder;
        }

        [HttpGet]
        public IActionResult AddMummy()
        {
            //Simply returns the add mummy view with the form. (Only allowed for authenticated researchers)
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
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
       
        public IActionResult UpdateMummyData(string BurialId)
        {
            IEnumerable<FagElGamousDatabaseByLocation> fagElGamousDatabaseByLocations;
            fagElGamousDatabaseByLocations = _context.FagElGamousDatabaseByLocation.Where(x => x.BurialId == BurialId);
            FagElGamousDatabaseByLocation burial = fagElGamousDatabaseByLocations.FirstOrDefault();
            //foreach (PropertyInfo prop in burial.GetType().GetProperties())
            //{
            //    var type = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
            //    try
            //    {
            //        prop.SetValue(burial, HttpUtility.HtmlEncode(prop.GetValue(burial, null)), null);
            //    }
            //    catch
            //    {
            //        Console.WriteLine(prop.GetValue(burial));
            //    }
                
            //}
            return View("EditFullMummyData", burial);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult MummyUpdate(FagElGamousDatabaseByLocation Mummy)
        {
            //foreach (PropertyInfo prop in Mummy.GetType().GetProperties())
            //{
            //    var type = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
            //    try 
            //    { 
            //    prop.SetValue(Mummy, HttpUtility.HtmlEncode(prop.GetValue(Mummy, null)),null);
            //    }
            //    catch
            //    {
            //        Console.WriteLine(prop.GetValue(Mummy));
            //    }
            //}

            _context.FagElGamousDatabaseByLocation.Update(Mummy);
            _context.SaveChanges();


            return RedirectToAction("DatabaseSearch", "Home");
        }


        public IActionResult DeleteMummy(string mummyid)
        {
            FagElGamousDatabaseByLocation mummy = _context.FagElGamousDatabaseByLocation.Where(b => b.BurialId == mummyid).FirstOrDefault();
            _context.FagElGamousDatabaseByLocation.Remove(mummy);
            _context.SaveChanges();
            return RedirectToAction("DatabaseSearch", "Home");
        }

        //[HttpPost]
        //public IActionResult UpdateConfirmation(int mummyid /*mummy passed through form*/)
        //{
        //    //Submits update
        //    //Only accessible by researchers

        //    return View(/*collection of mummies*/);
        //}

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
