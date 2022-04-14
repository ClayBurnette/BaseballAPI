using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballAPI.Models.GameBattingStatModels
{
    public class SeasonBattingStat
    {
        public int PlayerId { get; set; }
        public int Season { get; set; }
        public string PlayerName { get; set; }
        public decimal AVG
        {
            get
            {
                decimal avg = (decimal)H / (decimal)AB;
                return Math.Round(avg, 3);
            }
        }
        public decimal OBP
        {
            get
            {
                decimal numerator = H + BB + HBP;
                decimal obp = (numerator) / PA;
                return Math.Round(obp, 3);
            }
        }
        public decimal SLG
        {
            get
            {
                decimal slg = (decimal)TB / (decimal)AB;
                return Math.Round(slg, 3);
            }
        }
        public decimal OPS
        {
            get
            {
                return OBP + SLG;
            }
        }
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
        public int SBP
        {
            get
            {
                if (SB + CS == 0)
                    return 0;
                return 100*(SB / (SB + CS));
            }
        }
    }
}
