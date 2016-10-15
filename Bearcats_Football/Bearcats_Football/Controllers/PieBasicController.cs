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
            DBConnection dbconnection = new DBConnection();
            List<Bearcats_Football.Models.Rushes> rushesList = dbconnection.getConnection();
            foreach (Bearcats_Football.Models.Rushes index in rushesList)
            {
                pieData.Add(new PieSeriesData { Name = index.opponent_team, Y = index.count });
            }
            //pieData.Add(new PieSeriesData { Name = "Win% in 2011", Y = 15.94 });
            //pieData.Add(new PieSeriesData { Name = "Win% in 2012", Y = 13.04 });
            //pieData.Add(new PieSeriesData { Name = "Win% in 2013", Y = 20.28 });
            //pieData.Add(new PieSeriesData { Name = "Win% in 2014", Y = 14.49 });
            //pieData.Add(new PieSeriesData { Name = "Win% in 2015", Y = 21.73 });
            //pieData.Add(new PieSeriesData { Name = "Overall matches lost%", Y = 14.52, Sliced = true, Selected = true });

            ViewData["pieData"] = pieData;
            return View();
        }
    }
}