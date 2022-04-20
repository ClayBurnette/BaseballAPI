using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;

namespace BaseballAPI.Models.GameInfoModel
{
    public class GameEdit
    {
        public int GameId { get; set; }
        public int HomeTeamID { get; set; }

        public int AwayTeamID { get; set; }

        [Range(0, int.MaxValue)]
        public int HomeScore { get; set; }

        [Range(0, int.MaxValue)]
        public int AwayScore { get; set; }

        public double Innings { get; set; }

       public int SeasonYear { get; set; }
    }
}