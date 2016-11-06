using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Diagnostics;
using System.Configuration;
using Bearcats_Football.Models;

namespace Bearcats_Football.Models
{
    public class RushingDBConnection
    {
        public MongoClient client;
        public IMongoDatabase database;

        public List<Rushing> getRushingConnection()
        {
            List<Rushing> rushingList = new List<Rushing>();
          
            this.client = new MongoClient("mongodb://football:football@ds044679.mlab.com:44679/nwmsufootball");
            this.database = client.GetDatabase("nwmsufootball");
            var collection = database.GetCollection<Rootobject>("individualplayerdetails");
            var p = "Grove,Jordan";
            var year = collection.Find(b => b._id.Equals(p)).ToListAsync().Result;
            foreach (Rootobject v in year)
            {
                
                String id = v._id;
                for (int i = 0; i < v.Year2015.Length; i++)
                {
                    //For Rushing
                    Rushing rush = new Rushing();
                    rush._id = id;
                    rush._date = v.Year2015[i].date;
                    rush._opponent = v.Year2015[i].opponent;
                    rush._no = v.Year2015[i].rushing.no;
                    rush._lg = v.Year2015[i].rushing.lg;
                    rush._td = v.Year2015[i].rushing.td;
                    rush._yards = v.Year2015[i].rushing.yards;
                    rushingList.Add(rush);


                }

            }

            return rushingList;
        }
        public List<Recieving> getRecievingConnection()
        {
            
            List<Recieving> recievingList = new List<Recieving>();
            this.client = new MongoClient("mongodb://football:football@ds044679.mlab.com:44679/nwmsufootball");
            this.database = client.GetDatabase("nwmsufootball");
            var collection = database.GetCollection<Rootobject>("individualplayerdetails");
            var p = "Grove,Jordan";
            var year = collection.Find(b => b._id.Equals(p)).ToListAsync().Result;
            foreach (Rootobject v in year)
            {

                String id = v._id;
                for (int i = 0; i < v.Year2015.Length; i++)
                {
                    //For Recieving
                    Recieving recieve = new Recieving();
                    recieve._id = id;
                    recieve._date = v.Year2015[i].date;
                    recieve._opponent = v.Year2015[i].opponent;
                    recieve._no = v.Year2015[i].receiving.no;
                    recieve._lg = v.Year2015[i].receiving.lg;
                    recieve._td = v.Year2015[i].receiving.td;
                    recieve._yards = v.Year2015[i].receiving.yards;
                    recievingList.Add(recieve);

                }

            }

            return recievingList;
        }
    }
}



public class Rootobject
{
    public string _id { get; set; }
    public Year2015[] Year2015 { get; set; }
}

public class Year2015
{
    public string year { get; set; }
    public string date { get; set; }
    public string opponent { get; set; }
    public Rushing rushing { get; set; }
    public Receiving receiving { get; set; }
    public Passing passing { get; set; }
    public Kick_Returns kick_returns { get; set; }
    public Punt_Returns punt_returns { get; set; }
    public Tackles tackles { get; set; }
    public Sacks sacks { get; set; }
    public Fumble fumble { get; set; }
    public _Int _int { get; set; }
    public Pass pass { get; set; }
    public int blkd_kick { get; set; }
    public Pat pat { get; set; }
}

public class Rushing
{
    public int no { get; set; }
    public int yards { get; set; }
    public int td { get; set; }
    public int lg { get; set; }
}

public class Receiving
{
    public int no { get; set; }
    public int yards { get; set; }
    public int td { get; set; }
    public int lg { get; set; }
}

public class Passing
{
    public int comp { get; set; }
    public int attempts { get; set; }
    public int _inter { get; set; }
    public int no { get; set; }
    public int yards { get; set; }
    public int td { get; set; }
    public int lg { get; set; }
}

public class Kick_Returns
{
    public int no { get; set; }
    public int yards { get; set; }
    public int td { get; set; }
    public int lg { get; set; }
}

public class Punt_Returns
{
    public int no { get; set; }
    public int yards { get; set; }
    public int td { get; set; }
    public int lg { get; set; }
}

public class Tackles
{
    public int solo { get; set; }
    public int ast { get; set; }
    public int total { get; set; }
    public float tfl { get; set; }
    public int yards { get; set; }
}

public class Sacks
{
    public float no { get; set; }
    public int yards { get; set; }
}

public class Fumble
{
    public int ff { get; set; }
    public int fr { get; set; }
    public int yards { get; set; }
}

public class _Int
{
    public int no { get; set; }
    public int yards { get; set; }
}

public class Pass
{
    public int qbh { get; set; }
    public int brup { get; set; }
}

public class Pat
{
    public string kick { get; set; }
    public int rush { get; set; }
    public int rcv { get; set; }
    public int saf { get; set; }
}

