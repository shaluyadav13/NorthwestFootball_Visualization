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
        DBConnection db = new DBConnection();
        YearWiseGamesPlayedConnection yws = new YearWiseGamesPlayedConnection();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Glossary()
        {
            return View();
        }

        //Returns view for the indexpage
        public ActionResult IndexPage()
        {
            yws.getCollection();
            //db.getConnection();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

       
    }
}