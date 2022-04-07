using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BaseballAPI.Models.GameInfoModel
{
    public class GameEdit
    {
        public int Id { get; set; }
        public int TeamId1 { get; set; }

        public int TeamId2 { get; set; }

        public int HomeScore { get; set; }

        public int AwayScore { get; set; }

        public double Innings { get; set; }

        public int SeasonYear { get; set; }
    }
}