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

        public ActionResult Glossary()
        {
            return View();
        }

        public ActionResult Player_Chart(string demo)
        {
            if (demo == null)
                ViewBag.name = "Foster,ShaCorey";
            else
            ViewBag.name = demo;
            // ViewBag.Theme = theme;

            return View();
        }

        public ActionResult getPlayerDetails(string year)
        {
            List<String> playerList = new List<string>();
            RushingDBConnection rushDBConn = new RushingDBConnection();
            int yr = Convert.ToInt32(year);
            playerList = rushDBConn.getPlayerNamesConnection(yr);
            return Json(playerList);
        }
    }
}