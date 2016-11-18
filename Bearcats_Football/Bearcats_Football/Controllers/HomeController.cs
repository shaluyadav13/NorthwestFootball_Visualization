using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Highsoft.Web.Mvc.Charts;
using Bearcats_Football.Models;


namespace Bearcats_Football.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TempHomePage()
        {
            return View();
        }

        public ActionResult Glossary()
        {
            return View();
        }

        public ActionResult Player_Chart(string demo, string theme)
        {
            ViewBag.Demo = demo;
            ViewBag.Theme = theme;
            return View();
        }
    }
}