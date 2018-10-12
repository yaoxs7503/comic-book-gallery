using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery2.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Friday)
            {
                return Redirect("/");
                //return new RedirectResult("/");
            }
            return Content("Hello from the comic books controller!");
            //return new contentresult()
            //{
            //    content = "hello from the comic books controller!"
            //};
            //return "Hello from the comic books controller!";
        }
    }
}