using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WaMvTech.Controllers
{
    public class ComicBooksController : Controller
    {
        //: Build comic book controller
        public string Detail()
        {
            return "Hello From Comic Books";
        }

        public ActionResult NewDetail()
        {
            ViewBag.SeriesTitle = "The Amazing Spider-Man";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Final issue! Witness the final hour</p>";
            ViewBag.Artists = new string[]
            {
                "Scripts: Dan Slott",
                "Pencils: Humberto Ramos",
                "Inks: Victor Olazaba",
                "Colors: Edgar Delgado",
                "Letters: Chris Eliopoulos"
            };
            return View();            
        }
    }
}