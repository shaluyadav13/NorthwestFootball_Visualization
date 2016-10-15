using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bearcats_Football.Models
{
    public class Rushes
    {
        public int count { get; set; }
        public DateTime Date { get; set; }
        public String opponent_team { get; set; }
        public String player_name { get; set; }
    }
} 