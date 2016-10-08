using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;

namespace Bearcats_Football.Models
{
    public class YearWiseGamesPlayedConnection
    {
        public MongoClient client;
        public IMongoDatabase database;
        public IMongoCollection<YearWiseGamesPlayed> getCollection()
        {
            this.client = null;
            this.client = new MongoClient("mongodb://football:football@ds044679.mlab.com:44679/nwmsufootball");
            this.database = client.GetDatabase("nwmsufootball");
            var collection = database.GetCollection<YearWiseGamesPlayed>("yearwisegamesplayed");
            var p = "57f1254f263a1e9f4fd3869d";
            var k = collection.Find(b => b._id.Equals(p)).ToListAsync().Result;
            Debug.WriteLine("HHHHHHHHHHH");
            Debug.WriteLine(k);
            int i = 0;
            foreach (var v in k)
            {
                Debug.WriteLine(v.years[0].year);
                Debug.WriteLine(v.years[0].matchesPlayed);
                Debug.WriteLine(v.years[0].matchesWon);
            }
            return collection;
        }
    }

    public class YearWiseGamesPlayed
    {
        public string _id { get; set; }
        public years[] years { get; set; }
    }

    public class years
    {
        public int year { get; set; }
        public int matchesPlayed { get; set; }
        public int matchesWon { get; set; }
    }
}