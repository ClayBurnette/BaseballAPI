using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballAPI.Models.GameBattingStatsModels
{
    public class GameBattingStatDetail
    {       
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public int GameId { get; set; }
        public int AB { get; set; }
        public int R { get; set; }
        public int H { get; set; }
        public int RBI { get; set; }
        public int BB { get; set; }
        public int PA
        {
            get
            {
                return AB + SAC + HBP;
            }
        }
        public int TB
        {
            get
            {
                return H + (2 * Double) + (3 * Triple) + (4 * HR);
            }
        }
        public int SO { get; set; }
        public int HR { get; set; }
        [Display(Name = "2B")]
        public int Double { get; set; }
        [Display(Name = "3B")]
        public int Triple { get; set; }
        public int SAC { get; set; }
        public int HBP { get; set; }
        public int SB { get; set; }
        public int CS { get; set; }
    }
}
