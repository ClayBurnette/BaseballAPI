﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballAPI.Models.GameInfoModel
{
    public class GameCreate
    {
        public int TeamId1 { get; set; }

        public int TeamId2 { get; set; }

        public int HomeScore { get; set; }

        public int AwayScore { get; set; }

        public double Innings { get; set; }

        public int SeasonYear { get; set; }


    }
}
