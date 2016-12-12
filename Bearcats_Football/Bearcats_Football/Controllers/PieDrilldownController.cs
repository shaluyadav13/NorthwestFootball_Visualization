using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Highsoft.Web.Mvc.Charts;
using Bearcats_Football.Models;

namespace Bearcats_Football.Controllers
{
    public partial class PieDrilldownController : Controller
    {
       
        public ActionResult PieDrilldown(String name,String year)
        {
            int yr = Convert.ToInt32(year);
            List<PieSeriesData> pieData = new List<PieSeriesData>();
            List<Series> drillList = new List<Series>();
            RushingDBConnection rushingDBConn = new RushingDBConnection();
            List<Bearcats_Football.Models.Passing> listPassing = rushingDBConn.getPassingConnection(name,yr);
            foreach (Bearcats_Football.Models.Passing pass in listPassing)
            {
                ViewData["playerName"] = pass._id;
                ViewData["Year"] = pass._year;
                pieData.Add(new PieSeriesData { Name = pass._opponent, Y = pass.comp,Drilldown = pass._opponent });
                drillList.Add(new PieSeries { Name = pass._opponent,Id=pass._opponent,Data = new List<PieSeriesData> { new PieSeriesData { Name = "Completed passes", Y = pass.comp },
                            new PieSeriesData { Name = "Not Completed passess", Y = (pass.attempts - pass.comp) } } });
            }

            ViewData["pieData"] = pieData;
            ViewData["drillList"] = drillList;
            return View();
        }
    }
}