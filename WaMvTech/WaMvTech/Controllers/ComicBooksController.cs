using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WaMvTech.Models;
using WaMvTech.Data;

namespace WaMvTech.Controllers
{
    public class ComicBooksController : Controller
    {
        //: Properties
        private ComicBookRepository _comicBookRepository = null;


        //: Init Constructor
        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }


        public ActionResult Index()
        {

            var comicBooks = _comicBookRepository.GetComicBooks();

            return View(comicBooks);

        }

        public ActionResult Detail(int? Id)
        {

            if (Id == null)
            {
                return HttpNotFound();
            }

            //:This is using the GetComicBook method from the Repository to get the comic book equal to the id passed.
            var comicBook = _comicBookRepository.GetComicBook( (int)Id ); 
            
            return View(comicBook);            
        }
    }
}