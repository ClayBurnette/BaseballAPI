using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballAPI.Models.GameBattingStatModels
{
    public class SeasonBattingStatSimple
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public int Season { get; set; }
        public double AVG { get; set; }
        public double OBP { get; set; }
        public double SLG { get; set; }
        public double OPS { get; set; }
        public int PA { get; set; }
        public int H { get; set; }
        public int BB { get; set; }
        public int R { get; set; }
        public int RBI { get; set; }
        [Display(Name = "2B")]
        public int Double { get; set; }
        [Display(Name = "3B")]
        public int Triple { get; set; }
        public int HR { get; set; }
    }
}
