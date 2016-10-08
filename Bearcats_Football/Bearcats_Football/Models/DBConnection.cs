﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Diagnostics;
using System.Configuration;

namespace Bearcats_Football.Models
{
    public class DBConnection
    {

        public MongoClient client;
        public IMongoDatabase database;


        public IMongoDatabase getConnection()
        {
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
                
            }
            
            return this.database;
        }

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