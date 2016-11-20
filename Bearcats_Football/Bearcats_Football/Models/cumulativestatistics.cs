using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bearcats_Football.Models
{

    public class cumulativestatistics
    {
        public string _id { get; set; }
        public string scoring { get; set; }
        public string points_per_game { get; set; }
        public string points_off_turnovers { get; set; }
        public string first_downs { get; set; }
        public string rushing { get; set; }
        public string passing { get; set; }
        public string penalty { get; set; }
        public string rushing_yardage { get; set; }
        public string rush_yards_gained_rushing { get; set; }
        public string rush_yards_lost_rushing { get; set; }
        public string rush_rushing_attempts { get; set; }
        public string rush_average_per_rush { get; set; }
        public string rush_average_per_game { get; set; }
        public string rush_td_rushing { get; set; }
        public string passing_yardage { get; set; }
        public string compattint { get; set; }
        public string pass_average_per_pass { get; set; }
        public string pass_average_per_catch { get; set; }
        public string pass_average_per_game { get; set; }
        public string pass_td_passing { get; set; }
        public string total_offense { get; set; }
        public string total_plays { get; set; }
        public string total_average_per_play { get; set; }
        public string total_average_per_game { get; set; }
        public string kick_returns_yards { get; set; }
        public string punt_returns_yards { get; set; }
        public string int_returns_yards { get; set; }
        public string kick_returns_average { get; set; }
        public string punt_returns_average { get; set; }
        public string int_returns_average { get; set; }
        public string fumble_lost { get; set; }
        public string penalties_yards { get; set; }
        public string average_per_game { get; set; }
        public string punt_yards { get; set; }
        public string average_per_punt { get; set; }
        public string net_punt_average { get; set; }
        public string kickoff_yards { get; set; }
        public string average_per_kick { get; set; }
        public string net_kick_average { get; set; }
        public string timepossession_game { get; set; }
        public string thirddown_conv { get; set; }
        public string thirddown_pct { get; set; }
        public string fourthdown_conv { get; set; }
        public string fourthdown_pct { get; set; }
        public string sacksbyyards { get; set; }
        public string miscyards { get; set; }
        public string touchdownsscored { get; set; }
        public string fieldgoal_attempts { get; set; }
        public string onsidekicks { get; set; }
        public string redzonescores { get; set; }
        public string redzonetouchdowns { get; set; }
        public string patattempts { get; set; }
        public string attendance { get; set; }
        public string games_avg_pergame { get; set; }
    }

}