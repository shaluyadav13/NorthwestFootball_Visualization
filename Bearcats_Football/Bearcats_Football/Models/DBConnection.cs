using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Diagnostics;
using System.Configuration;
using Bearcats_Football.Controllers;

namespace Bearcats_Football.Models
{
    public class DBConnection
    {

        public MongoClient client;
        public IMongoDatabase database;


        public List<Rushes> getConnection()
        {
            List<Rushes> rushesList = new List<Rushes>();
            this.client = new MongoClient("mongodb://football:football@ds044679.mlab.com:44679/nwmsufootball");
            this.database = client.GetDatabase("nwmsufootball");
            var collection = database.GetCollection<Test>("test");
            var p = "2015";
            var k = collection.Find(b => b._id.Equals(p)).ToListAsync().Result;
            foreach (var v in k)
            {
                Debug.WriteLine("cccccccccccccccc" + v.rushes.count);
                Debug.WriteLine(v.rushes.date);
                Debug.WriteLine(v.rushes.opponent_team);
                Debug.WriteLine(v.rushes.player_name);
                Rushes rushes = new Rushes() { count = v.rushes.count, Date = Convert.ToDateTime(v.rushes.date), opponent_team = v.rushes.opponent_team, player_name = v.rushes.player_name };
                rushesList.Add(rushes);
            }
            
            return rushesList;
        }
        //public List<Summary> getConnection1()
        //{
        //    List<Summary> summaryList = new List<Summary>();
        //    this.client = new MongoClient("mongodb://football:football@ds044679.mlab.com:44679/nwmsufootball");
        //    this.database = client.GetDatabase("nwmsufootball");
        //    var collection = database.GetCollection<Task1>("test");
        //    var p = "2014";
        //    var k = collection.Find(b => b._id.Equals("rushes")).ToListAsync().Result;
        //    int t = 0;
        //    foreach (Task1 v in k)
        //    {
        //        for(int i =0;i< v.summary.Length;i++)
        //          summaryList.Add(v.summary[i]);
               
        //    }

        //    return summaryList;
        //}

    }
    

}




public class Test
{
    public string _id { get; set; }
    public Rushes rushes { get; set; }
}

public class Rushes
{
    public int count { get; set; }
    public string player_name { get; set; }
    public string opponent_team { get; set; }
    public string date { get; set; }
}
