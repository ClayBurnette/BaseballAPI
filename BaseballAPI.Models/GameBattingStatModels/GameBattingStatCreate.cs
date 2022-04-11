using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballAPI.Models.GameBattingStatsModels
{
    public class GameBattingStatCreate
    {
        [Required]
        public int PlayerId { get; set; }
        [Required]
        public int GameId { get; set; }
        [Required]
        public int AB { get; set; }
        [Required]
        public int R { get; set; }
        [Required]
        public int H { get; set; }
        [Required]
        public int RBI { get; set; }
        [Required]
        public int BB { get; set; }
        [Required]
        public int SO { get; set; }
        [Required]
        public int HR { get; set; }
        [Required]
        [Display(Name = "2B")]
        public int Double { get; set; }
        [Required]
        [Display(Name = "3B")]
        public int Triple { get; set; }
        [Required]
        public int SAC { get; set; }
        [Required]
        public int HBP { get; set; }
        [Required]
        public int SB { get; set; }
        [Required]
        public int CS { get; set; }
        public GameBattingStatCreate(string[] statArray)
        {
            int[] intConvert = Array.ConvertAll(statArray, s => int.Parse(s));
            PlayerId = intConvert[0];
            GameId = intConvert[1];
            AB = intConvert[2];
            R = intConvert[3];
            H = intConvert[4];
            RBI = intConvert[5];
            BB = intConvert[6];
            SO = intConvert[7];
            HR = intConvert[8];
            Double = intConvert[9];
            Triple = intConvert[10];
            SAC = intConvert[11];
            HBP = intConvert[12];
            SB = intConvert[13];
            CS = intConvert[14];
        }
    }
}
