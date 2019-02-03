using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRockers.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "What do you think?"; 

            return View();
        }

        [HttpPost]
        public ActionResult Contact(string message)
        {
            // TODO: Save this and act on it
            ViewBag.Message = "Thanks for the feedback";
            return View();
        }

        public ActionResult Backstage(string secret, string format)
        {
            if (secret != "giorgi")
                return new HttpStatusCodeResult(403);

            if (format == "text")
                return Content("Giorgi you are doing great!");
            else if (format == "json")
                return Json(new { password = "Kharshiladze", expires = DateTime.UtcNow.ToShortDateString() }, JsonRequestBehavior.AllowGet);
            else if (format == "clean")
                return PartialView();

            return View();
        }
    }
}