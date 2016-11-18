using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bearcats_Football.Models
{
    public class Passing
    {
        public string _id { get; set; }
        public string _date { get; set; }
        public string _opponent { get; set; }
        public int comp { get; set; }
        public int attempts { get; set; }
        public int _inter { get; set; }
        public int no { get; set; }
        public int yards { get; set; }
        public int td { get; set; }
        public int lg { get; set; }
    }
}