using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Highsoft.Web.Mvc.Charts;
using Bearcats_Football.Models;

namespace Bearcats_Football.Controllers
{
    public partial class ColumnBasicController : Controller
    {
        // GET: ColumnNegative
        public ActionResult ColumnBasic(String name, String year)
        {
            int yr = Convert.ToInt32(year);
            RushingDBConnection rushingDBConn = new RushingDBConnection();
            List<Bearcats_Football.Models.Rushing> listRushing = rushingDBConn.getRushingConnection(name, yr);
            List<Bearcats_Football.Models.Recieving> listReceiving = rushingDBConn.getRecievingConnection(name, yr);
            List<String> opponentsList = new List<string>();
            List<double> yardRushValues = new List<double>();
            List<double> yardReceiveValues = new List<double>();
            foreach (Bearcats_Football.Models.Rushing rushing in listRushing)
            {
                ViewData["playerName"] = rushing._id;
                ViewData["Year"] = rushing._year;
                opponentsList.Add(rushing._opponent);
                yardRushValues.Add(Convert.ToDouble(rushing._yards));
            }

            foreach (Bearcats_Football.Models.Recieving recieving in listReceiving)
            {
                yardReceiveValues.Add(Convert.ToDouble(recieving._yards));
            }
            List<ColumnSeriesData> yardRushData = new List<ColumnSeriesData>();
            List<ColumnSeriesData> yardReceiveData = new List<ColumnSeriesData>();
            yardRushValues.ForEach(p => yardRushData.Add(new ColumnSeriesData { Y = p }));
            yardReceiveValues.ForEach(p => yardReceiveData.Add(new ColumnSeriesData { Y = p }));
            ViewData["opponents"] = opponentsList;
            ViewData["yardRushData"] = yardRushData;
            ViewData["yardReceiveData"] = yardReceiveData;
            return View();
        }
    }
}