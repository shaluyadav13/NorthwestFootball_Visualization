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

        public ActionResult Player_Chart(string demo,string chartType,string year)
        {
            if (demo == null)
            {
                if (year == "2015")
                {
                    ViewBag.name = "Foster,ShaCorey";
                }
                else
                {
                    ViewBag.name = "Bolles,Brady";
                }
            }
            else
            {
                ViewBag.name = demo;
            }
            if (chartType == null)
            {
                ViewBag.type = "ColumnBasic";
            }
            else
            {
                ViewBag.type = chartType;
            }
            // ViewBag.Theme = theme;
            ViewBag.year = year;
            return View();
        }

        public ActionResult getPlayerDetails(string year)
        {
            ViewBag.year = year;
            List<String> playerList = new List<string>();
            RushingDBConnection rushDBConn = new RushingDBConnection();
            int yr = Convert.ToInt32(year);
            playerList = rushDBConn.getPlayerNamesConnection(yr);
            playerList.Sort();
            return Json(playerList);
        }
    }
}