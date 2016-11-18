using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bearcats_Football.Models
{
    public class Tackles
    {
        public string _id { get; set; }
        public string _date { get; set; }
        public string _opponent { get; set; }
        public int _solo { get; set; }
        public int _ast { get; set; }
    }
}