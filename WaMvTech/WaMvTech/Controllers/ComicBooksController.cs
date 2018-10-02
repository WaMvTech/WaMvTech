using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WaMvTech.Models;

namespace WaMvTech.Controllers
{
    public class ComicBooksController : Controller
    {
        //: Build comic book controller
        public string StringDetail()
        {
            return "Hello From Comic Books";
        }

        public ActionResult Detail()
        {
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hour</p>",
                Artists = new Artist[] 
                {
                    new Artist() { Name = "Dan Slott", Role = "Scripts" },
                    new Artist() { Name = "Humberto Ramos", Role = "Pencils" },
                    new Artist() { Name = "Victor Olazaba", Role = "Inks" },
                    new Artist() { Name = "Edgar Delgado", Role = "Colors" },
                    new Artist() { Name = "Chris Eliopoulos", Role = "Letters" }
                }
            };

            return View(comicBook);            
        }
    }
}