using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballAPI.Data
{
    public class GameBattingStats
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(Player))]
        public int PlayerId { get; set; }
        public virtual Player Player { get; set; }
        [ForeignKey(nameof(Game))]
        public int GameId { get; set; }
        public virtual GameInfo Game { get; set; }
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
        public GameBattingStats() { }
        public GameBattingStats(int playerId, int gameId, int ab, int r, int h, int rbi, int bb, int so, int hr, int doub, int trip, int sac, int hbp, int sb, int cs)
        {
            PlayerId = playerId;
            GameId = gameId;
            AB = ab;
            R = r;
            H = h;
            RBI = rbi;
            BB = bb;
            SO = so;
            HR = hr;
            Double = doub;
            Triple = trip;
            SAC = sac;
            HBP = hbp;
            SB = sb;
            CS = cs;
        }
    }
}
