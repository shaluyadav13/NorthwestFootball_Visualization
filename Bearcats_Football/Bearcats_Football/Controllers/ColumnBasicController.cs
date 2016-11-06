using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Highsoft.Web.Mvc.Charts;
using Bearcats_Football.Models;

namespace Bearcats_Football.Controllers
{
    public class ColumnBasicController : Controller
    {
        // GET: ColumnNegative
        public ActionResult ColumnBasic()
        {
            RushingDBConnection rushingDBConn = new RushingDBConnection();
            List<Bearcats_Football.Models.Rushing> listRushing = rushingDBConn.getRushingConnection();
            List<Bearcats_Football.Models.Recieving> listReceiving = rushingDBConn.getRecievingConnection();
            List<String> opponentsList = new List<string>();
            List<double> yardRushValues = new List<double>();
            List<double> yardReceiveValues = new List<double>();
            foreach (Bearcats_Football.Models.Rushing rushing in listRushing)
            {
                ViewData["playerName"] = rushing._id;
                opponentsList.Add(rushing._opponent);
                yardRushValues.Add(Convert.ToDouble(rushing._yards));
            }

            foreach (Bearcats_Football.Models.Recieving recieving in listReceiving)
            {
                yardReceiveValues.Add(Convert.ToDouble(recieving._yards));
            }

                //List<double> nyValues = new List<double> { 83.6, 78.8, 98.5, 93.4, 106.0, 84.5, 105.0, 104.3, 91.2, 83.5, 106.6, 92.3 };
                //List<double> berlinValues = new List<double> { 42.4, 33.2, 34.5, 39.7, 52.6, 75.5, 57.4, 60.4, 47.6, 39.1, 46.8, 51.1 };
                //List<double> londonValues = new List<double> { 48.9, 38.8, 39.3, 41.4, 47.0, 48.3, 59.0, 59.6, 52.4, 65.2, 59.3, 51.2 };

            List<ColumnSeriesData> yardRushData = new List<ColumnSeriesData>();
            List<ColumnSeriesData> yardReceiveData = new List<ColumnSeriesData>();
            //List<ColumnSeriesData> nyData = new List<ColumnSeriesData>();
            //List<ColumnSeriesData> berlinData = new List<ColumnSeriesData>();
            //List<ColumnSeriesData> londonData = new List<ColumnSeriesData>();

            yardRushValues.ForEach(p => yardRushData.Add(new ColumnSeriesData { Y = p }));
            yardReceiveValues.ForEach(p => yardReceiveData.Add(new ColumnSeriesData { Y = p }));
            //nyValues.ForEach(p => nyData.Add(new ColumnSeriesData { Y = p }));
            //berlinValues.ForEach(p => berlinData.Add(new ColumnSeriesData { Y = p }));
            //londonValues.ForEach(p => londonData.Add(new ColumnSeriesData { Y = p }));

            ViewData["opponents"] = opponentsList;
            ViewData["yardRushData"] = yardRushData;
            ViewData["yardReceiveData"] = yardReceiveData;

            //ViewData["nyData"] = nyData;
            //ViewData["berlinData"] = berlinData;
            //ViewData["londonData"] = londonData;
            return View();
        }
    }
}