using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClickJacking.Controllers
{
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