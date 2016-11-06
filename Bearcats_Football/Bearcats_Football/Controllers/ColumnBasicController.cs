using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Highsoft.Web.Mvc.Charts;
using Bearcats_Football.Models;
using MongoDB.Bson;
using MongoDB.Driver;


namespace Bearcats_Football.Controllers
{
    public class ColumnBasicController : Controller
    {

         

        // GET: ColumnNegative
        public ActionResult ColumnBasic()
        {
            List<double> v = new List<double>();
            //List<Summary> list = new List<Summary>();
            DBConnection dbConnection = new DBConnection();
            List<Bearcats_Football.Models.Summary> list = dbConnection.getConnection1();

            foreach (var v1 in list)
            {
                
                v.Add(v1.count);
                

            }

            List<double> tokyoValues = new List<double> { 99.9, 49.9, 99.9, 49.9, 144.0, 176.0, 176.0, 148.5, 216.4, 194.1, 95.6, 194.4 };
         //   List<double> nyValues = new List<double> { 83.6, 78.8, 98.5, 93.4, 106.0, 84.5, 105.0, 104.3, 91.2, 83.5, 106.6, 92.3 };
         //   List<double> berlinValues = new List<double> { 42.4, 33.2, 34.5, 39.7, 52.6, 75.5, 57.4, 60.4, 47.6, 39.1, 46.8, 51.1 };
          //  List<double> londonValues = new List<double> { 48.9, 38.8, 39.3, 41.4, 47.0, 48.3, 59.0, 59.6, 52.4, 65.2, 59.3, 51.2 };
            List<ColumnSeriesData> tokyoData = new List<ColumnSeriesData>();
            List<ColumnSeriesData> nyData = new List<ColumnSeriesData>();
            List<ColumnSeriesData> berlinData = new List<ColumnSeriesData>();
            List<ColumnSeriesData> londonData = new List<ColumnSeriesData>();

            v.ForEach(p => tokyoData.Add(new ColumnSeriesData { Y = p }));
            //nyValues.ForEach(p => nyData.Add(new ColumnSeriesData { Y = p }));
          //  berlinValues.ForEach(p => berlinData.Add(new ColumnSeriesData { Y = p }));
          //  londonValues.ForEach(p => londonData.Add(new ColumnSeriesData { Y = p }));

            ViewData["tokyoData"] = tokyoData;
            //ViewData["nyData"] = nyData;
           // ViewData["berlinData"] = berlinData;
           // ViewData["londonData"] = londonData;
            return View();
        }
    }
   
}