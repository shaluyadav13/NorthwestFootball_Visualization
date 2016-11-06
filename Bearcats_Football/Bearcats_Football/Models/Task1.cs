using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bearcats_Football.Models
{
    public class Task1
    {
        public string _id { get; set; }
        public Summary[] summary { get; set; }
    }

    public class Summary
    {
        public int year { get; set; }
        public int count { get; set; }
        public string player_name { get; set; }
        public string opponent_team { get; set; }
        public string date { get; set; }
    }
}