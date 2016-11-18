using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Highsoft.Web.Mvc.Charts;
using Bearcats_Football.Models;

namespace Bearcats_Football.Controllers
{
    public partial class BarStackedController : Controller
    {
        // GET: BarStacked
        public ActionResult BarStacked(String name)
        {
            RushingDBConnection rushingDBConn = new RushingDBConnection();
            List<Bearcats_Football.Models.Tackles> listTackles = rushingDBConn.getTacklesConnection(name);
            List<String> opponentsList = new List<string>();
            List<int> soloTackleValues = new List<int>();
            List<int> astTackleValues = new List<int>();
            foreach (Bearcats_Football.Models.Tackles tackle in listTackles)
            {
                ViewData["playerName"] = tackle._id;
                opponentsList.Add(tackle._opponent);
                astTackleValues.Add(tackle._ast);
                soloTackleValues.Add(tackle._solo);
            }

            //List<double?> johnValues = new List<double?> { 5, 3, 4, 7, 2 };
            //List<double?> janeValues = new List<double?> { 2, -2, -3, 2, 1 };
            //List<double?> joeValues = new List<double?> { 3, 4, 4, -2, 5 };

            //List<BarSeriesData> johnData = new List<BarSeriesData>();
            List<BarSeriesData> soloData = new List<BarSeriesData>();
            List<BarSeriesData> astData = new List<BarSeriesData>();

            astTackleValues.ForEach(p => astData.Add(new BarSeriesData { Y = p }));
            soloTackleValues.ForEach(p => soloData.Add(new BarSeriesData { Y = p }));
            // joeValues.ForEach(p => joeData.Add(new BarSeriesData { Y = p }));
            ViewData["opponents"] = opponentsList;
            ViewData["astData"] = astData;
            ViewData["soloData"] = soloData;
            return View();
        }
    }
}