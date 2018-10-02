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

            if(DateTime.Today.DayOfWeek == DayOfWeek.Tuesday)
            {
                return Redirect("/");
            }

            return Content("This is using the Content Result");
            
        }
    }
}