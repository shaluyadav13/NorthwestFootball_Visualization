using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bearcats_Football.Models
{
    public class Rushes
    {
        public int count { get; set; }
        public DateTime date { get; set; }
        public string opponent_team { get; set; }
        public string player_name { get; set; }
    }
}