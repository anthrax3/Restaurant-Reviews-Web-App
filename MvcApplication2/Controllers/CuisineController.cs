using System;
using MvcApplication2.Filters;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Controllers{

    //[Authorize]
    [Log]
    public class CuisineController : Controller
    {
        //
        // GET: /Cuisine/
        
        
        public ActionResult Search(string name="french")
        {
            //throw new Exception("Something went terribly wrong");
            var message = Server.HtmlEncode(name);
           // return RedirectToAction("Index", "Home", new { name = name });
            //return RedirectToRoute("Default", new { controller = "Home", action = "About" });
            //return File(Server.MapPath("~/Content/Site.css"), "text/css");
           // return Json(new { Message = message, Name = "Scott" }, JsonRequestBehavior.AllowGet);
            return Content(message);
        }
        
    }
}
