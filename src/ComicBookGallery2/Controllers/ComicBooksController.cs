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
            ViewBag.SeriestTitle = "The Amazing Spider-Man";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Final issue Witness <h2>the final hour</h2></p>";
            ViewBag.Artists = new string[]
            {
            "Script: Dan Slott",
            "Pencils: Humberto Ramos",
            "Inks: Victor Olazaba",
            "Colors: Edgar Delgado",
            "Letters: Chris Eliopoulos"
            };
            return View();
            //if (DateTime.Today.DayOfWeek == DayOfWeek.Friday)
            //{
            //    return Redirect("/");
            //    //return new RedirectResult("/");
            //}
            //return Content("Hello from the comic books controller!");
            //return new contentresult()
            //{
            //    content = "hello from the comic books controller!"
            //};
            //return "Hello from the comic books controller!";
        }
    }
}