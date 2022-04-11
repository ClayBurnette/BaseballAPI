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
        public int TeamId1 { get; set; }

        public int TeamId2 { get; set; }

        [Range(0, int.MaxValue)]
        public int HomeScore { get; set; }

        [Range(0, int.MaxValue)]
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