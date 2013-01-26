
using System.Collections.Generic;
using ServiceStack.ServiceHost;

namespace FootballStatsApi
{
    [Route("/games")]
    public class Games : IReturn<List<Games>>
    {
        public string Season { get; set; }
        public string Division { get; set; }
        public string Date { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public int FullTimeHomeGoals { get; set; }
        public int FullTimeAwayGoals { get; set; }
        public string FullTimeResult { get; set; }

        public string HalfTimeHomeGoals { get; set; }
        public string HalfTimeAwayGoals { get; set; }
        public string HalfTimeResult { get; set; }

        public string Attendance { get; set; }
        public string Referee { get; set; }

        public string HomeShots { get; set; }
        public string AwayShots { get; set; }

        public string HomeShotsonTarget { get; set; }
        public string AwayShotsonTarget { get; set; }
        public string HomeHitWoodwork { get; set; }
        public string AwayHitWoodwork { get; set; }

        public string HomeCorners { get; set; }
        public string AwayCorners { get; set; }
        public string HomeFoulsCommitted { get; set; }
        public string AwayFoulsCommitted { get; set; }

        public string HomeOffsides { get; set; }
        public string AwayOffsides { get; set; }
        public string HomeYellowCards { get; set; }
        public string AwayYellowCards { get; set; }
        public string HomeRedCards { get; set; }
        public string AwayRedCards { get; set; }    
    }
}
