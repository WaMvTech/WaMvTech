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
        private ComicBookRepository _comicBookRepository = null;

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
            var comicBook = _comicBookRepository.GetComicBook( (int)Id ); 
            
            return View(comicBook);            
        }
    }
}