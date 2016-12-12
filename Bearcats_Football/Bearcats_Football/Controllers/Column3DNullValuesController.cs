using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Highsoft.Web.Mvc.Charts;
using Bearcats_Football.Models;

namespace Bearcats_Football.Controllers
{
    public partial class Column3DNullValuesController : Controller
    {
        // GET: Column3DNullValues
        public ActionResult Column3DNullValues(String name, String year)
        {
            int yr = Convert.ToInt32(year);
            RushingDBConnection rushingDBConn = new RushingDBConnection();
            List<Bearcats_Football.Models.KickReturns> listKickReturns = rushingDBConn.getKickReturnConnection(name, yr);
            List<String> opponentsList = new List<string>();
            List<double> yardKickValues = new List<double>();
            foreach (Bearcats_Football.Models.KickReturns kickreturns in listKickReturns)
            {
                ViewData["playerName"] = kickreturns._id;
                ViewData["Year"] = kickreturns._year;
                opponentsList.Add(kickreturns._opponent);
                yardKickValues.Add(Convert.ToDouble(kickreturns.yards));
            }
            List<ColumnSeriesData> chartData = new List<ColumnSeriesData>();

            yardKickValues.ForEach(p => chartData.Add(new ColumnSeriesData { Y = p }));

            ViewData["chartData"] = chartData;
            ViewData["opponents"] = opponentsList;
            return View();
        }
    }
}