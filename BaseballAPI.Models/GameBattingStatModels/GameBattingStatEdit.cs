using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballAPI.Models.GameBattingStatsModels
{
    public class GameBattingStatEdit
    {   
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public int GameId { get; set; }
        public int AB { get; set; }
        public int R { get; set; }
        public int H { get; set; }
        public int RBI { get; set; }
        public int BB { get; set; }
        public int SO { get; set; }
        public int HR { get; set; }
        public int Double { get; set; }
        public int Triple { get; set; }
        public int SAC { get; set; }
        public int HBP { get; set; }
        public int SB { get; set; }
        public int CS { get; set; }
    }
}
