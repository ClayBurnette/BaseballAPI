using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballAPI.Models.GameInfoModel
{
    public class GameDetail
    {
        public int GameId { get; set; }
        public int HomeTeamID { get; set; }

        public int AwayTeamID { get; set; }

        public int HomeScore { get; set; }

        public int AwayScore { get; set; }

        public double Innings { get; set; }
        public bool ExtraInnings
        {
            get
            {
                if (Innings > 9)
                    return true;
                return false;
            }
        }

        public int SeasonYear { get; set; }


    }
}
