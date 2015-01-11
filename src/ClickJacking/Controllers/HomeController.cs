using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace ClickJacking.Controllers
{
    [OutputCache(Location = OutputCacheLocation.Any, Duration = 31536000)]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Jacked()
        {
            return View();
        }

        public ActionResult SafeIndex()
        {
            HttpContext.Response.AddHeader("X-Frame-Options", "DENY");
            return View();
        }

        public ActionResult NotJacked()
        {
            return View();
        }
    }
}