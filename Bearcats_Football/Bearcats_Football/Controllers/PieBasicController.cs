using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Highsoft.Web.Mvc.Charts;
using Bearcats_Football.Models;

namespace Bearcats_Football.Controllers
{
    public class PieBasicController : Controller
    {
        // GET: PieBasic
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PieBasic()
        {
            List<PieSeriesData> pieData = new List<PieSeriesData>();
            DBConnection dbConnection = new DBConnection();
            List<Bearcats_Football.Models.Rushes> list = dbConnection.getConnection();
            foreach(Bearcats_Football.Models.Rushes rush in list)
            {
                pieData.Add(new PieSeriesData { Name = rush.opponent_team, Y = rush.count });
            }

            ViewData["pieData"] = pieData;
            return View();
        }
    }
}