using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bearcats_Football.Models
{
 
    public class overallindividualstatistics
    {
        public string _id { get; set; }
        public int year { get; set; }
        public int GP { get; set; }
        public int Att { get; set; }
        public int Gain { get; set; }
        public int Loss { get; set; }
        public int Net { get; set; }
        public float Avg { get; set; }
        public int TD { get; set; }
        public int Long { get; set; }
        public float AvgG { get; set; }
    }

}