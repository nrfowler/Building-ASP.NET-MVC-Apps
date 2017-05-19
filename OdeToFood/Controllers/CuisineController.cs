using OdeToFood.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    //[Authorize]
    [Log]
    public class CuisineController : Controller
    {
       //[Authorize(Roles="Admin")]
        [HttpGet]
        public ActionResult Search(string name = "french")
        {
            //throw new Exception("Something terrible has happened");

            var message = Server.HtmlEncode(name);
            //return RedirectToAction("Index", "Home", new { name = name });
            //return RedirectToRoute("Default", new { controller = "Home", name = name });
            //return File(Server.MapPath("~/Content/site.css"), "text/css");
            //return Json(new { Message = message, Name = "Scott" }, JsonRequestBehavior.AllowGet);

            return Content(message);
        }

        [HttpPost]
        public ActionResult Search()
        {
            
            return Content("Search");
        }
    }
}
