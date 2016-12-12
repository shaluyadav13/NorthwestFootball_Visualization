using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bearcats_Football.Models
{
    public class KickReturns
    {
        public string _id { get; set; }
        public int _year { get; set; }
        public string _date { get; set; }
        public string _opponent { get; set; }
        public int no { get; set; }
        public int yards { get; set; }
        public int td { get; set; }
        public int lg { get; set; }
    }
}