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

        public List<Rushing> getRushingConnection(string name, int yr)
        {
            List<Rushing> rushingList = new List<Rushing>();
          
            this.client = new MongoClient("mongodb://football:football@ds044679.mlab.com:44679/nwmsufootball");
            this.database = client.GetDatabase("nwmsufootball");
            if (yr == 2015)
            {
                var collection = database.GetCollection<Rootobject>("individualplayerdetails");
                // var p = "Grove,Jordan";
                var year = collection.Find(b => b._id.Equals(name)).ToListAsync().Result;
                foreach (Rootobject v in year)
                {

                    String id = v._id;
                    int y = v.year;
                    for (int i = 0; i < v.Year2015.Length; i++)
                    {
                        //For Rushing
                        Rushing rush = new Rushing();
                        rush._id = id;
                        rush._year = y;
                        rush._date = v.Year2015[i].date;
                        rush._opponent = v.Year2015[i].opponent;
                        rush._no = v.Year2015[i].rushing.no;
                        rush._lg = v.Year2015[i].rushing.lg;
                        rush._td = v.Year2015[i].rushing.td;
                        rush._yards = v.Year2015[i].rushing.yards;
                        rushingList.Add(rush);

                    }

                }
            }
            else
            {
                var collection = database.GetCollection<Rootobject1>("individualplayerdetails_2014");
                // var p = "Grove,Jordan";
                var year = collection.Find(b => b._id.Equals(name)).ToListAsync().Result;
                foreach (Rootobject1 v in year)
                {

                    String id = v._id;
                    int y = v.year;
                    for (int i = 0; i < v.Year2014.Length; i++)
                    {
                        //For Rushing
                        Rushing rush = new Rushing();
                        rush._id = id;
                        rush._year = y;
                        rush._date = v.Year2014[i].date;
                        rush._opponent = v.Year2014[i].opponent;
                        rush._no = v.Year2014[i].rushing.no;
                        rush._lg = v.Year2014[i].rushing.lg;
                        rush._td = v.Year2014[i].rushing.td;
                        rush._yards = v.Year2014[i].rushing.yards;
                        rushingList.Add(rush);

                    }

                }
            }

            return rushingList;
        }

        public List<Recieving> getRecievingConnection(string name, int yr)
        {
            
            List<Recieving> recievingList = new List<Recieving>();
            this.client = new MongoClient("mongodb://football:football@ds044679.mlab.com:44679/nwmsufootball");
            this.database = client.GetDatabase("nwmsufootball");
            if (yr == 2015)
            {
                var collection = database.GetCollection<Rootobject>("individualplayerdetails");
                // var p = "Grove,Jordan";
                var year = collection.Find(b => b._id.Equals(name)).ToListAsync().Result;
                foreach (Rootobject v in year)
                {

                    String id = v._id;
                    int y = v.year;
                    for (int i = 0; i < v.Year2015.Length; i++)
                    {
                        //For Recieving
                        Recieving recieve = new Recieving();
                        recieve._id = id;
                        recieve._year = y;
                        recieve._date = v.Year2015[i].date;
                        recieve._opponent = v.Year2015[i].opponent;
                        recieve._no = v.Year2015[i].receiving.no;
                        recieve._lg = v.Year2015[i].receiving.lg;
                        recieve._td = v.Year2015[i].receiving.td;
                        recieve._yards = v.Year2015[i].receiving.yards;
                        recievingList.Add(recieve);

                    }

                }
            }
            else
            {
                var collection = database.GetCollection<Rootobject1>("individualplayerdetails_2014");
                // var p = "Grove,Jordan";
                var year = collection.Find(b => b._id.Equals(name)).ToListAsync().Result;
                foreach (Rootobject1 v in year)
                {

                    String id = v._id;
                    int y = v.year;
                    for (int i = 0; i < v.Year2014.Length; i++)
                    {
                        //For Recieving
                        Recieving recieve = new Recieving();
                        recieve._id = id;
                        recieve._year = y;
                        recieve._date = v.Year2014[i].date;
                        recieve._opponent = v.Year2014[i].opponent;
                        recieve._no = v.Year2014[i].receiving.no;
                        recieve._lg = v.Year2014[i].receiving.lg;
                        recieve._td = v.Year2014[i].receiving.td;
                        recieve._yards = v.Year2014[i].receiving.yards;
                        recievingList.Add(recieve);

                    }

                }
            }

            return recievingList;
        }

        public List<Tackles> getTacklesConnection(string name, int yr)
        {
            List<Tackles> tacklesList = new List<Tackles>();
            this.client = new MongoClient("mongodb://football:football@ds044679.mlab.com:44679/nwmsufootball");
            this.database = client.GetDatabase("nwmsufootball");
            if (yr == 2015)
            {
                var collection = database.GetCollection<Rootobject>("individualplayerdetails");
                // var p = "Grove,Jordan";
                var year = collection.Find(b => b._id.Equals(name)).ToListAsync().Result;
                foreach (Rootobject v in year)
                {

                    String id = v._id;
                    int y = v.year;
                    for (int i = 0; i < v.Year2015.Length; i++)
                    {
                        //For Recieving
                        Tackles tackles = new Tackles();
                        tackles._id = id;
                        tackles._year = y;
                        tackles._date = v.Year2015[i].date;
                        tackles._opponent = v.Year2015[i].opponent;
                        tackles._ast = v.Year2015[i].tackles.ast;
                        tackles._solo = v.Year2015[i].tackles.solo;
                        tacklesList.Add(tackles);
                    }

                }
            }
            else
            {
                var collection = database.GetCollection<Rootobject1>("individualplayerdetails_2014");
                // var p = "Grove,Jordan";
                var year = collection.Find(b => b._id.Equals(name)).ToListAsync().Result;
                foreach (Rootobject1 v in year)
                {

                    String id = v._id;
                    int y = v.year;
                    for (int i = 0; i < v.Year2014.Length; i++)
                    {
                        //For Recieving
                        Tackles tackles = new Tackles();
                        tackles._id = id;
                        tackles._year = y;
                        tackles._date = v.Year2014[i].date;
                        tackles._opponent = v.Year2014[i].opponent;
                        tackles._ast = v.Year2014[i].tackles.ast;
                        tackles._solo = v.Year2014[i].tackles.solo;
                        tacklesList.Add(tackles);
                    }

                }
            }

            return tacklesList;
        }

        public List<Passing> getPassingConnection(string name, int yr)
        {
            List<Passing> passingList = new List<Passing>();
            this.client = new MongoClient("mongodb://football:football@ds044679.mlab.com:44679/nwmsufootball");
            this.database = client.GetDatabase("nwmsufootball");
            if (yr == 2015)
            {
                var collection = database.GetCollection<Rootobject>("individualplayerdetails");
                // var p = "Grove,Jordan";
                var year = collection.Find(b => b._id.Equals(name)).ToListAsync().Result;
                foreach (Rootobject v in year)
                {

                    String id = v._id;
                    int y = v.year;
                    for (int i = 0; i < v.Year2015.Length; i++)
                    {
                        //For Recieving
                        Passing passing = new Passing();
                        passing._id = id;
                        passing._year = y;
                        passing._date = v.Year2015[i].date;
                        passing._opponent = v.Year2015[i].opponent;
                        passing.comp = v.Year2015[i].passing.comp;
                        passing.lg = v.Year2015[i].passing.lg;
                        passing.attempts = v.Year2015[i].passing.attempts;
                        passing._inter = v.Year2015[i].passing._inter;
                        passing.no = v.Year2015[i].passing.no;
                        passing.yards = v.Year2015[i].passing.yards;
                        passing.td = v.Year2015[i].passing.td;
                        passingList.Add(passing);
                    }

                }
            }
            else
            {
                var collection = database.GetCollection<Rootobject1>("individualplayerdetails_2014");
                // var p = "Grove,Jordan";
                var year = collection.Find(b => b._id.Equals(name)).ToListAsync().Result;
                foreach (Rootobject1 v in year)
                {

                    String id = v._id;
                    int y = v.year;
                    for (int i = 0; i < v.Year2014.Length; i++)
                    {
                        //For Recieving
                        Passing passing = new Passing();
                        passing._id = id;
                        passing._year = y;
                        passing._date = v.Year2014[i].date;
                        passing._opponent = v.Year2014[i].opponent;
                        passing.comp = v.Year2014[i].passing.comp;
                        passing.lg = v.Year2014[i].passing.lg;
                        passing.attempts = v.Year2014[i].passing.attempts;
                        passing._inter = v.Year2014[i].passing._inter;
                        passing.no = v.Year2014[i].passing.no;
                        passing.yards = v.Year2014[i].passing.yards;
                        passing.td = v.Year2014[i].passing.td;
                        passingList.Add(passing);
                    }

                }
            }

            return passingList;
        }

        public List<KickReturns> getKickReturnConnection(string name, int yr)
        {
            List<KickReturns> kickreturnsList = new List<KickReturns>();
            this.client = new MongoClient("mongodb://football:football@ds044679.mlab.com:44679/nwmsufootball");
            this.database = client.GetDatabase("nwmsufootball");
            if (yr == 2015)
            {
                var collection = database.GetCollection<Rootobject>("individualplayerdetails");
                // var p = "Grove,Jordan";
                var year = collection.Find(b => b._id.Equals(name)).ToListAsync().Result;
                foreach (Rootobject v in year)
                {

                    String id = v._id;
                    int y = v.year;
                    for (int i = 0; i < v.Year2015.Length; i++)
                    {
                        //For KickReturns
                        KickReturns kickreturns = new KickReturns();
                        kickreturns._id = id;
                        kickreturns._year = y;
                        kickreturns._date = v.Year2015[i].date;
                        kickreturns._opponent = v.Year2015[i].opponent;
                        kickreturns.lg = v.Year2015[i].passing.lg;
                        kickreturns.no = v.Year2015[i].passing.no;
                        kickreturns.yards = v.Year2015[i].passing.yards;
                        kickreturns.td = v.Year2015[i].passing.td;
                        kickreturnsList.Add(kickreturns);
                    }

                }
            }
            else
            {
                var collection = database.GetCollection<Rootobject1>("individualplayerdetails_2014");
                // var p = "Grove,Jordan";
                var year = collection.Find(b => b._id.Equals(name)).ToListAsync().Result;
                foreach (Rootobject1 v in year)
                {

                    String id = v._id;
                    int y = v.year;
                    for (int i = 0; i < v.Year2014.Length; i++)
                    {
                        //For KickReturns
                        KickReturns kickreturns = new KickReturns();
                        kickreturns._id = id;
                        kickreturns._year = y;
                        kickreturns._date = v.Year2014[i].date;
                        kickreturns._opponent = v.Year2014[i].opponent;
                        kickreturns.lg = v.Year2014[i].passing.lg;
                        kickreturns.no = v.Year2014[i].passing.no;
                        kickreturns.yards = v.Year2014[i].passing.yards;
                        kickreturns.td = v.Year2014[i].passing.td;
                        kickreturnsList.Add(kickreturns);
                    }

                }
            }

            return kickreturnsList;
        }

        public List<string> getPlayerNamesConnection(int yr)
        {
            List<string> playerNameList = new List<string>();
            this.client = new MongoClient("mongodb://football:football@ds044679.mlab.com:44679/nwmsufootball");
            this.database = client.GetDatabase("nwmsufootball");

            if (yr == 2015)
            {
               var collection = database.GetCollection<Rootobject>("individualplayerdetails");

                var year = collection.Find(b => b.year == yr).ToListAsync().Result;
                foreach (Rootobject v in year)
                {
                    String id = v._id;
                    playerNameList.Add(id);

                }
            }
            else
            {
                var collection = database.GetCollection<Rootobject1>("individualplayerdetails_2014");

                var year = collection.Find(b => b.year == yr).ToListAsync().Result;
                foreach (Rootobject1 v in year)
                {
                    String id = v._id;
                    playerNameList.Add(id);

                }
            }
            return playerNameList;
        }
    }
}



public class Rootobject
{
    public string _id { get; set; }
    public int year { get; set; }
    public Year2015[] Year2015 { get; set; }
}

public class Rootobject1
{
    public string _id { get; set; }
    public int year { get; set; }
    public Year2014[] Year2014 { get; set; }
}

public class Year2014
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

